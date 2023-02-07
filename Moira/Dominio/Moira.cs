using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Moira.Dominio.Controllers;

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

        private MoiraClass()
        {
            progetti = new Dictionary<string, Progetto>();
            clienti = new Dictionary<string, Cliente>();
            teams = new Dictionary<string, Team>();
            impiegati = new Dictionary<string, Impiegato>();

            Avviamento();
        }

        private void Avviamento()
        {
            Team team = new Team("MoiraTeam");
            teams.Add(team.CodiceUnivoco, team);

            Cliente cliente = new Cliente("peppino", "impanato");
            clienti.Add(cliente.CodiceUnivoco, cliente);
        }

        //metodo public per ottenere un team dal dizionario tramite suo codiceUnivoco
        public Team GetTeamSpecifico(string codiceUnivoco)
        {
            return teams[codiceUnivoco];
        }

        public Cliente GetClienteSpecifico(string codiceUnivoco)
        {
            return clienti[codiceUnivoco];
        }
        public Progetto GetProgettoSpecifico(string nomeProgetto) => progetti[nomeProgetto];
        public bool IsProgettoSpecifico(string nomeProgetto) => progetti.ContainsKey(nomeProgetto);

        public Impiegato GetImpiegatoSpecifico(string codiceImpiegato) => impiegati[codiceImpiegato];

        public void addTeam(Team teamCorrente) => teams.Add(teamCorrente.CodiceUnivoco, teamCorrente);

        public void deleteTeam(string codiceTeam)
        {
            if (!teams.Remove(codiceTeam))
                throw new KeyNotFoundException();
        }

        public void addProgetto(Progetto progetto) => progetti.Add(progetto.Nome, progetto);
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


        public void deleteCliente(string codiceClente)
        {
            if (!clienti.TryGetValue(codiceClente, out Cliente cliente))
                throw new KeyNotFoundException();

            foreach (Progetto progetto in progetti.Values)
                progetto.removeCliente(cliente);

            clienti.Remove(codiceClente);
        }

        public List<Team> GetTeams() => new List<Team>(teams.Values);
        public List<Cliente> GetClienti() => new List<Cliente>(clienti.Values);
        public List<Progetto> GetProgetti() => new List<Progetto>(progetti.Values);
        public List<Impiegato> GetImpiegati() => new List<Impiegato>(impiegati.Values);

    }
}
