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

        public TeamHandler()
        {
            moira = MoiraClass.Instance;
        }

        public Impiegato ImpiegatoCorrente { get => impiegatoCorrente; }

        public void CreaImpiegato(string nome,string cognome, string email,string numeroTelefono, string indirizzo) => impiegatoCorrente = new Impiegato(nome, cognome, email, numeroTelefono, indirizzo);

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

        public void ConfermaCreaBoard()
        {
            try
            {
                teamCorrente.confermaCreaBoard();
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }
    }
}
