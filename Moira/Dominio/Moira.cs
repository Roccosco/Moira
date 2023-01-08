using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public class Moira
    {

        private Dictionary<string, Progetto> progetti;
        private Dictionary<string, Cliente> clienti;
        private Dictionary<string, Team> teams;

        private Progetto corrente;

        public Moira()
        {
            progetti = new Dictionary<string, Progetto>();
            clienti = new Dictionary<string, Cliente>();
            teams = new Dictionary<string, Team>();
        }

        public void InserisciNuovoProgetto(string nome, string descrizione)
        {
            corrente = new Progetto(nome, descrizione);
        }

        public void AssociaTeamAProgetto(string codiceUnivoco)
        {
            try
            {
                Team tm = teams[codiceUnivoco];
                tm.Progetto = corrente;
            }
            catch (KeyNotFoundException)
            {
                //messaggio di errore: team non esistente
            }
            catch (Exception e)
            {
                //messaggio di errore nel messaggio di e
            }
        }

        public void AssiciaClienteAProgetto(string codiceUnivoco)
        {
            try
            {
                Cliente cl = clienti[codiceUnivoco];
                corrente.SetCliente(cl);
            }
            catch (KeyNotFoundException)
            {
            }
        }

        public void ConfermaInserimentoProgetto()
        {
            string nome = corrente.Nome;
            progetti.Add(nome, corrente);
        }

        public void InserisciNuovaUserStory(string nome, string descrizione) {
            corrente.InserisciUserStory(nome, descrizione);
        }

    }
}
