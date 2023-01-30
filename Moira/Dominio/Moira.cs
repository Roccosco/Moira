using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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
        private Dictionary<string, Impiegato> impiegati;

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
            Team team = new Team("MoiraTeam");
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

        public string InserisciNuovaUserStory(string nome, string descrizione) => progettoCorrente.InserisciNuovaUserStory(nome, descrizione);

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

        public Team getTeam(string codiceTeam) => teams[codiceTeam];

        public Impiegato getImpiegato(string codiceImpiegato) => impiegati[codiceImpiegato];

        public void addTeam(Team teamCorrente) => teams.Add(teamCorrente.CodiceUnivoco, teamCorrente);

        public void deleteTeam(string codiceTeam)
        {
            if (!teams.Remove(codiceTeam))
                throw new KeyNotFoundException();
        }

        public void addImpiegato(Impiegato impiegato) => impiegati.Add(impiegato.CodiceUnivoco, impiegato);

        public void deleteImpiegato(string codiceImpiegato)
        {
            if (!impiegati.TryGetValue(codiceImpiegato, out Impiegato impiegato))
                throw new KeyNotFoundException();

            foreach (Team team in teams.Values)
                team.removeImpiegato(impiegato);

            impiegati.Remove(codiceImpiegato);

        }

        public void addCliente(Cliente cliente) => clienti.Add(cliente.CodiceUnivoco, cliente);

        public Progetto getProgetto(string nomeProgetto) => progetti[nomeProgetto];

        public Cliente getCliente(string codiceCliente) => clienti[codiceCliente];

        public void deleteCliente(string codiceClente)
        {
            if (!clienti.TryGetValue(codiceClente, out Cliente cliente))
                throw new KeyNotFoundException();

            foreach (Progetto progetto in progetti.Values)
                progetto.removeCliente(cliente);

            clienti.Remove(codiceClente);
        }
    }
}
