namespace Moira.Dominio.Controllers
{
    public class ProgettoHandler
    {

        private MoiraClass moira;
        private Progetto progettoCorrente;

        public Progetto Corrente { get => progettoCorrente; }

        public ProgettoHandler()
        {
            moira = MoiraClass.Instance;
        }

        public void AssociaClienteAProgetto(string codiceUnivoco)
        {
            try
            {
                Cliente cl = moira.GetClienteSpecifico(codiceUnivoco);
                progettoCorrente.SetCliente(cl);
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }

        public void AssociaTeamAProgetto(string codiceUnivoco)
        {
            try
            {
                Team tm = moira.GetTeamSpecifico(codiceUnivoco);
                tm.Progetto = progettoCorrente;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void ConfermaInserimentoProgetto()
        {
            moira.addProgetto(progettoCorrente);
        }

        public void ConfermaInserimentoUserStory()
        {
            progettoCorrente.ConfermaInserimentoUserStory();
        }

        public string InserisciNuovaUserStory(string nome, string descrizione) => progettoCorrente.InserisciNuovaUserStory(nome, descrizione);

        public void InserisciNuovoProgetto(string nome, string descrizione)
        {
            try
            {
                moira.GetProgettoSpecifico(nome);
            }
            catch (Exception)
            {
                progettoCorrente = new Progetto(nome, descrizione);
            }
        }

        public string InserisciNuovoTask(string nome, string descrizione) => progettoCorrente.InserisciNuovoTask(nome, descrizione);

        public void InserisciPosizioneUserStory(int posizione)
        {
            progettoCorrente.SetPosizioneNuovaUserStory(posizione);
        }

        public void SelezionaProgetto(string nome)
        {
            try
            {
                progettoCorrente = moira.GetProgettoSpecifico(nome);
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }
    }
}