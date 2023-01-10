using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public class MoiraClass
    {

        private static MoiraClass instance;

        public static MoiraClass Instance
        {
            get
            {
                if (instance == null)
                    instance = new MoiraClass();
                return instance;
            }
        }

        private Dictionary<string, Progetto> progetti;
        private Dictionary<string, Cliente> clienti;
        private Dictionary<string, Team> teams;

        private Progetto corrente;

        private MoiraClass()
        {
            progetti = new Dictionary<string, Progetto>();
            clienti = new Dictionary<string, Cliente>();
            teams = new Dictionary<string, Team>();

            Avviamento();
        }

        private void Avviamento()
        {
            Team team = new Team();
            teams.Add(team.CodiceUnivoco, team);

        }

        public void InserisciNuovoProgetto(string nome, string descrizione)
        {
            if (!progetti.TryGetValue(nome, out _))
                corrente = new Progetto(nome, descrizione);
            else
                throw new Exception("Esiste già un progetto con questo nome.");
        }

        public void AssociaTeamAProgetto(string codiceUnivoco)
        {
            try
            {
                Team tm = teams[codiceUnivoco];
                tm.Progetto = corrente;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void AssociaClienteAProgetto(string codiceUnivoco)
        {
            try
            {
                Cliente cl = clienti[codiceUnivoco];
                corrente.SetCliente(cl);
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }

        public void ConfermaInserimentoProgetto()
        {
            string nome = corrente.Nome;
            progetti.Add(nome, corrente);
        }

        public void SelezionaProgetto(string nome)
        {
            try
            {
                corrente = progetti[nome];
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }

        public string InserisciNuovaUserStory(string nome, string descrizione) => corrente.InserisciUserStory(nome, descrizione);

        public string InserisciNuovoTask(string nome, string descrizione) => corrente.InserisciNuovoTask(nome, descrizione);

        public void InserisciPosizioneUserStory(int posizione)
        {
            corrente.SetPosizioneNuovaUserStory(posizione);
        }

        public void ConfermaInserimentoUserStory()
        {
            corrente.ConfermaInserimentoUserStory();
        }

    }
}
