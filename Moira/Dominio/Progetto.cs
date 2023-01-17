using System;
using System.Collections.Generic;
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
        private UserStory corrente;

        public Progetto(string nome, string descrizione)
        {
            this.nome = nome;
            this.descrizione = descrizione;

            clienti = new HashSet<Cliente>();
            backlog = new List<UserStory>();
        }

        public string Nome { get => nome; set => nome = value; }
        
        public void SetCliente(Cliente cliente)
        {
            clienti.Add(cliente);
        }

        public string InserisciUserStory(string nome, string descrizione)
        {
            corrente = new UserStory(nome, descrizione);

            return corrente.CodiceIdentificativo;

        }

        public string InserisciNuovoTask(string nome, string descrizione)
        {
            return corrente.InserisciNuovoTask(nome, descrizione);
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
            backlog.Insert(posNuovaUserStory, corrente);
        }

        //vado a verificare se il cliente che viene passato è presente nella hashset
        //restituisce vero se il cliente è presente (quindi interessato al progetto in questione)
        public bool IsClienteInterested(Cliente cl)
        {
            return clienti.Contains(cl);
        }

        public int PosizioneUserStory { get => posNuovaUserStory; }

        public UserStory Corrente { get => corrente; }
    }
}
