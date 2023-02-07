using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio.Controllers
{
    public class TeamHandler
    {
        private MoiraClass moira;
        private Team teamCorrente;
        private Impiegato impiegatoCorrente;
        private Cerimonia cerimoniaCorrente;


        public TeamHandler()
        {
            moira = MoiraClass.Instance;
        }

        public Team TeamCorrente { get => teamCorrente; }

        public Impiegato ImpiegatoCorrente { get => impiegatoCorrente; }

        public void CreaImpiegato(string nome, string cognome, string email, string numeroTelefono, string indirizzo) => impiegatoCorrente = new Impiegato(nome, cognome, email, numeroTelefono, indirizzo);

        public void SelezionaImpiegatoCorrente(string codiceImpiegato)
        {
            try
            {
                impiegatoCorrente = moira.GetImpiegatoSpecifico(codiceImpiegato);
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }

        public void ConfermaCreaImpiegato() => moira.addImpiegato(impiegatoCorrente);

        public void ResetInfoImpiegato(string email, string numeroTelefono, string indirizzo)
        {
            impiegatoCorrente.Email = email;
            impiegatoCorrente.Telefono = numeroTelefono;
            impiegatoCorrente.Indirizzo = indirizzo;
        }

        public void EliminaImpiegato(string codiceImpiegato)
        {
            try
            {
                moira.deleteImpiegato(codiceImpiegato);
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }


        public void CreaTeam(string nome)
        {
            teamCorrente = new Team(nome);
        }

        public void AggiungiImpiegatoATeam(string codiceImpiegato)
        {
            try
            {
                Impiegato impiegato = moira.GetImpiegatoSpecifico(codiceImpiegato);
                if (!teamCorrente.addImpiegato(impiegato))
                    throw new Exception("L'impiegato è già presente nel team!");
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }

        public void ConfermaCreaTeam() => moira.addTeam(teamCorrente);

        //modifica
        public void SelezionaTeamCorrente(string codiceTeam)
        {
            try
            {
                teamCorrente = moira.GetTeamSpecifico(codiceTeam);
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }

        public void RimuoviImpiegatoDaTeam(string codiceImpiegato)
        {
            try
            {
                Impiegato impiegato = moira.GetImpiegatoSpecifico(codiceImpiegato);
                if (!teamCorrente.removeImpiegato(impiegato))
                    throw new Exception("L'impiegato non era presente nel team!");
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }

        //elimina
        public void EliminaTeam(string codiceTeam)
        {
            try
            {
                moira.deleteTeam(codiceTeam);
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }

        public void CreaBoard(string nome, string codiceTeam)
        {
            try
            {
                teamCorrente = moira.GetTeamSpecifico(codiceTeam);
                teamCorrente.creaBoard(nome);
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }

        public void CreaColonna(string nome, bool daRivedere) => teamCorrente.creaColonna(nome, daRivedere);

        public void CreaColonna(string nome, bool daRivedere, int limiteTask) => teamCorrente.creaColonna(nome, daRivedere, limiteTask);

        public void ConfermaCreaBoard()
        {
            try
            {
                teamCorrente.confermaCreaBoard();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CreaCerimonia(string nome, string descrizione, DateTime data, TimeSpan durata, TipoCerimonia tipo, string codiceTeam)
        {
            try
            {
                teamCorrente = moira.GetTeamSpecifico(codiceTeam);
                if (teamCorrente.HaGiaCerimonie(data, durata))
                    throw new Exception("Il team è già impiegato in un'altra cerimonia quel giorno a quelle ore!");
                teamCorrente.CreaCerimonia(nome, descrizione, tipo, data, durata);
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }

        public void InvitoCerimonia(string codiceCliente)
        {
            try
            {
                if (teamCorrente.Progetto == null)
                    throw new Exception("Il team non lavora ad alcun progetto e quindi il cliente non può essere aggiunto!");

                Cliente cliente = moira.GetClienteSpecifico(codiceCliente);
                if (!teamCorrente.Progetto.IsClienteInterested(cliente))
                    throw new Exception("Il cliente " + cliente.Nome + " non è interessato al progetto!");
                cerimoniaCorrente.AggiungiCliente(cliente);
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void ConfermaCreaCerimonia()
        {
            teamCorrente.confermaCreaCerimonia();
        }

        public void AvviaNuovoSprint(string codiceTeam)
        {
            try
            {
                teamCorrente = moira.GetTeamSpecifico(codiceTeam);
                teamCorrente.AvviaNuovoSprint();

            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }

        public void AggiungiTaskASprint(string codiceTask, int storyPoints)
        {
            teamCorrente.AggiungiTaskASprint(codiceTask, storyPoints);
        }

        public void AssociaTaskSprintAImpiegato(string codiceImpiegato)
        {
            try
            {
                Impiegato impiegato = moira.GetImpiegatoSpecifico(codiceImpiegato);
                teamCorrente.AssociaTaskSprintAImpiegato(impiegato);
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }

        public void ConfermaAvvioSprint()
        {
            teamCorrente.confermaAvvioSprint();
        }

        public void SelezionaTeamBoard(string codiceTeam)
        {
            try
            {
                Team team = moira.GetTeamSpecifico(codiceTeam);
                Board board = team.Board;
                if (board == null)
                    throw new Exception("Il team selezionato non ha una board!");
                teamCorrente = team;
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }

        public void SelezionaTaskBacklogs(string codiceTask)
        {
            teamCorrente.selezionaTaskBacklogs(codiceTask);
        }

        public void AggiungiTaskAColonna(string codiceColonna)
        {
            teamCorrente.AggiungiTaskAColonna(codiceColonna);
        }

        public void SelezionaTaskBoard(string codiceTask, string codiceColonna) => teamCorrente.SelezionaTaskBoard(codiceTask, codiceColonna);

        public void SpostaTaskTraColonne(string codiceColonnaDestinazione, bool daRivedereDa, bool daRivedereA) => teamCorrente.SpostaTaskTraColonne(codiceColonnaDestinazione, daRivedereDa, daRivedereA);

        public void SpostaTaskInDaRivedere(string codiceColonnaDaRivedere) => TeamCorrente.SpostaTaskInDaRivedere(codiceColonnaDaRivedere);


        public List<Impiegato> GetImpiegati() => moira.GetImpiegati();

        public List<Team> GetTeams() => moira.GetTeams();

        public List<Cliente> GetClienti() => moira.GetClienti();
    }
}
