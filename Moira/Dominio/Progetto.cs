using Moira.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public class Progetto : Subject
    {
        private string nome;
        private string descrizione;

        private int posNuovaUserStory;

        private HashSet<Cliente> clienti;
        private List<UserStory> backlog;
        private UserStory userStoryCorrente;
        private MoiraTask taskModifica;

        private HashSet<Observer> observers;

        public Progetto(string nome, string descrizione)
        {
            this.nome = nome;
            this.descrizione = descrizione;

            clienti = new HashSet<Cliente>();
            backlog = new List<UserStory>();

            observers = new HashSet<Observer>();
        }

        public string Nome { get => nome; set => nome = value; }

        public string Descrizione { get => descrizione; }

        public MoiraTask TaskModifica { get => taskModifica; }

        public void SetCliente(Cliente cliente)
        {
            if (!clienti.Add(cliente))
                throw new Exception("Cliente già presente");
        }

        public bool removeCliente(Cliente cliente) => clienti.Remove(cliente);

        public string InserisciNuovaUserStory(string nome, string descrizione)
        {
            userStoryCorrente = new UserStory(nome, descrizione);

            return userStoryCorrente.CodiceIdentificativo;

        }

        public string InserisciNuovoTask(string nome, string descrizione)
        {
            return userStoryCorrente.InserisciNuovoTask(nome, descrizione);
        }

        public void SetPosizioneNuovaUserStory(int posizione)
        {
            if (CheckPosizionePossibile(posizione))
                posNuovaUserStory = posizione;
            else
                throw new Exception("Posizione non valida!");
        }

        //serve per verificare che esiste un test con quella posizione. In un backlog con 8
        //elementi restituisce vero se passiamo un intero compreso tra 0 e 7 (estremi inclusi)
        public bool CheckPosizionePossibile(int posizione) => posizione >= 0 && posizione <= backlog.Count;

        public void ConfermaInserimentoUserStory()
        {
            backlog.Insert(posNuovaUserStory, userStoryCorrente);
            Notify();
        }

        //vado a verificare se il cliente che viene passato è presente nella hashset
        //restituisce vero se il cliente è presente (quindi interessato al progetto in questione)
        public bool IsClienteInterested(Cliente cl)
        {
            return clienti.Contains(cl);
        }

        public bool IsClienteInterested(string codiceUnivocoCliente)
        {
            return clienti.Any(x => x.CodiceUnivoco == codiceUnivocoCliente);
        }

        public MoiraTask getTask(string codiceTask)
        {
            foreach (UserStory userStory in backlog)
            {
                MoiraTask task = userStory.getTask(codiceTask);
                if (task != null)
                    return task;
            }
            throw new Exception("Task con codice identificativo " + codiceTask + " non presente nel progetto!");
        }

        public List<MoiraTask> getTasks()
        {
            List<MoiraTask> moiraTasks = new List<MoiraTask>();

            foreach (UserStory userStory in backlog)
                moiraTasks.AddRange(userStory.getAllTasks());

            return moiraTasks;
        }

        [Browsable(false)]
        public int PosizioneUserStory { get => posNuovaUserStory; }

        [Browsable(false)]
        public UserStory Corrente { get => userStoryCorrente; }

        public void DrawBacklog(Panel panelBacklog) => new BacklogUI(new List<UserStory>(backlog)).Draw(panelBacklog);

        public void Register(Observer observer) => observers.Add(observer);

        public void Remove(Observer observer) => observers.Remove(observer);

        public void Notify()
        {
            foreach (Observer observer in observers)
                observer.update();
        }

        public void SelezionaTaskModifica(string codiceTask)
        {
            taskModifica = getTask(codiceTask);
        }

        public void ConfermaModificaTask(string nome, string descrizione)
        {
            taskModifica.Nome = nome;
            taskModifica.Descrizione = descrizione;
            Notify();
        }

        public void SpostaUserStory(string codiceUserStory, int posizione)
        {
            if (posizione < 0 || posizione >= backlog.Count)
                throw new Exception("Posizione fuori dal range");

            List<UserStory> newBacklog = new List<UserStory>();

            UserStory userStory = backlog.Where(x => x.CodiceIdentificativo == codiceUserStory).FirstOrDefault();
            if (userStory == null)
                throw new Exception("User story non presente nel backlog!");

            newBacklog = backlog;
            newBacklog.Remove(userStory);
            newBacklog.Insert(posizione, userStory);
            backlog = newBacklog;



            Notify();
        }
    }
}
