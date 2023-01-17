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

        private Progetto progettoCorrente;

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

            Cliente cliente = new Cliente("peppino", "impanato");
            clienti.Add(cliente.CodiceUnivoco, cliente);
        }

        public void InserisciNuovoProgetto(string nome, string descrizione)
        {
            if (!progetti.TryGetValue(nome, out _))
                progettoCorrente = new Progetto(nome, descrizione);
            else
                throw new Exception("Esiste già un progetto con questo nome.");
        }

        public void AssociaTeamAProgetto(string codiceUnivoco)
        {
            try
            {
                Team tm = teams[codiceUnivoco];
                tm.Progetto = progettoCorrente;
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
                progettoCorrente.SetCliente(cl);
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }

        public void ConfermaInserimentoProgetto()
        {
            string nome = progettoCorrente.Nome;
            progetti.Add(nome, progettoCorrente);
        }

        public void SelezionaProgetto(string nome)
        {
            try
            {
                progettoCorrente = progetti[nome];
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }

        public string InserisciNuovaUserStory(string nome, string descrizione) => progettoCorrente.InserisciUserStory(nome, descrizione);

        public string InserisciNuovoTask(string nome, string descrizione) => progettoCorrente.InserisciNuovoTask(nome, descrizione);

        public void InserisciPosizioneUserStory(int posizione)
        {
            progettoCorrente.SetPosizioneNuovaUserStory(posizione);
        }

        public void ConfermaInserimentoUserStory()
        {
            progettoCorrente.ConfermaInserimentoUserStory();
        }

        public Progetto Corrente { get => progettoCorrente; }

        //metodo public per ottenere un team dal dizionario tramite suo codiceUnivoco
        public Team TeamSpecifico(string codiceUnivoco)
        {
            return teams[codiceUnivoco];
        }

        public Cliente ClienteSpecifico(string codiceUnivoco)
        {
            return clienti[codiceUnivoco];
        }

    }
}
