using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public class Progetto
    {
        private string nome;
        private string descrizione;

        private int posNuovaUserStory;

        private HashSet<Cliente> clienti;
        private List<UserStory> backlog;
        private UserStory userStoryCorrente;

        public Progetto(string nome, string descrizione)
        {
            this.nome = nome;
            this.descrizione = descrizione;

            clienti = new HashSet<Cliente>();
            backlog = new List<UserStory>();
        }

        public string Nome { get => nome; set => nome = value; }

        public string Descrizione { get => descrizione; }

        public void SetCliente(Cliente cliente)
        {
            if(!clienti.Add(cliente))
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
            foreach(UserStory userStory in backlog)
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
    }
}
