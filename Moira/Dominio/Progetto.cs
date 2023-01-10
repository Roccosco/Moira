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

        public bool CheckPosizionePossibile(int posizione) => posizione >= 0 && posizione <= backlog.Count;

        public void ConfermaInserimentoUserStory()
        {
            backlog.Insert(posNuovaUserStory, corrente);
        }
    }
}
