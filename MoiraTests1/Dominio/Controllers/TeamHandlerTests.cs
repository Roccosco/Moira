using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moira.Dominio;
using Moira.Dominio.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio.Controllers.Tests
{
    [TestClass()]
    public class TeamHandlerTests
    {
        static TeamHandler th;
        static MoiraClass m;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            //th = new TeamHandler();
            //m = MoiraClass.Instance;
        }

        [TestInitialize]
        public void TestInitialize()
        {
            th = new TeamHandler();
            m = MoiraClass.Instance;
        }


        [TestMethod()]
        public void CreaImpiegatoTest()
        {
            try
            {
                th.CreaImpiegato("sono", "fuori", "dal", "tunnel", "elelelel");
                Assert.IsNotNull(th.ImpiegatoCorrente);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void SelezionaImpiegatoCorrenteTest()
        {
            try
            {
                th.CreaImpiegato("cosa", "diamine", "e", "uno", "spazioporto");
                th.ConfermaCreaImpiegato();
                th.CreaImpiegato("sono", "fuori", "dal", "tunnel", "elelelel");
                th.SelezionaImpiegatoCorrente("1");
                Assert.AreEqual("e", th.ImpiegatoCorrente.Email);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void ConfermaCreaImpiegatoTest()
        {
            try
            {
                th.CreaImpiegato("cosa", "diamine", "è", "uno", "spazioporto");
                th.ConfermaCreaImpiegato();
                Assert.IsNotNull(m.GetImpiegatoSpecifico("1"));//problema con codice univoco impiegato
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void ResetInfoImpiegatoTest()
        {
            try
            {
                th.CreaImpiegato("cosa", "diamine", "è", "uno", "spazioporto");
                th.ResetInfoImpiegato("abiura", "di", "me");
                Assert.AreEqual("abiura", th.ImpiegatoCorrente.Email);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void EliminaImpiegatoTest()
        {
            Impiegato prisoner = new Impiegato("cosa", "diamine", "è", "uno", "spazioporto");
            m.addImpiegato(prisoner);
            th.EliminaImpiegato(prisoner.CodiceUnivoco);
            th.EliminaImpiegato(prisoner.CodiceUnivoco);

        }

        [TestMethod()]
        public void CreaTeamTest()
        {
            try
            {
                th.CreaTeam("Exuvia");
                th.ConfermaCreaTeam();
                Assert.IsNotNull(m.GetTeamSpecifico(th.TeamCorrente.CodiceUnivoco));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void AggiungiImpiegatoATeamTest()
        {
            try
            {
                Impiegato im = new Impiegato("ilariacondizionata", "ha", "raffreddato", "lamia", "giornata");
                m.addImpiegato(im);
                th.CreaTeam("ProvaTeam");
                th.AggiungiImpiegatoATeam(im.CodiceUnivoco);
                th.AggiungiImpiegatoATeam(im.CodiceUnivoco);
            }
            catch (KeyNotFoundException)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void ConfermaCreaTeamTest()
        {
            try
            {
                th.CreaTeam("Exuvia");
                th.ConfermaCreaTeam();
                Assert.IsNotNull(m.GetTeamSpecifico(th.TeamCorrente.CodiceUnivoco));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void SelezionaTeamCorrenteTest()
        {
            try
            {
                string nomeTeam = "ExuviaComplex";
                th.CreaTeam(nomeTeam);
                th.ConfermaCreaTeam();
                string codiceUnivoco = th.TeamCorrente.CodiceUnivoco;
                th.SelezionaTeamCorrente(codiceUnivoco);
                Assert.AreEqual(nomeTeam, th.TeamCorrente.Nome);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void RimuoviImpiegatoDaTeamTest()
        {
            try
            {
                Impiegato impiegato = new Impiegato("fuori", "di", "me", "ex", "uvia");
                th.CreaTeam("Lallallero");
                m.addImpiegato(impiegato);
                th.AggiungiImpiegatoATeam(impiegato.CodiceUnivoco);
                th.RimuoviImpiegatoDaTeam(impiegato.CodiceUnivoco);
                th.RimuoviImpiegatoDaTeam(impiegato.CodiceUnivoco);
            }
            catch (KeyNotFoundException)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void EliminaTeamTest()
        {
            th.EliminaTeam("0");
            m.GetTeamSpecifico("0");
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void CreaBoardTest()
        {
            th.CreaBoard("Fugadà", "0");
            th.ConfermaCreaBoard();
            th.CreaBoard("Pippo", "0");
        }

        [TestMethod()]
        public void CreaColonnaTest()
        {
            try
            {
                th.CreaTeam("fuoridaltunnel");
                th.ConfermaCreaTeam();
                IEnumerable<Team> search = m.GetTeams().Where(x => x.Nome == "fuoridaltunnel");
                th.CreaBoard("China", search.ToList()[0].CodiceUnivoco);
                th.ConfermaCreaBoard();
                th.CreaColonna("Town", false);
                Assert.IsTrue((int)th.TeamCorrente.Board.Colonne.Count() == 2);
                // Assert.AreEqual((int)th.TeamCorrente.Board.Colonne.Count(),(int)3);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void ConfermaCreaBoardTest()
        {
            try
            {
                th.CreaBoard("China", "0");
                th.ConfermaCreaBoard();
                Assert.Fail();

            }
            catch
            {
                //se entra qui, un eccezzione è stata generata
                //quindi va benissimo
            }
        }

        [TestMethod()]
        public void InvitoCerimoniaTest()
        {
            try
            {

            }
            catch
            {

            }
        }

        [TestMethod()]
        public void ConfermaCreaCerimoniaTest()
        {
            try
            {

            }
            catch
            {

            }
        }

        [TestMethod()]
        public void AvviaNuovoSprintTest()
        {
            try
            {
                th.CreaTeam("filippoargenti");
                th.ConfermaCreaTeam();
                th.TeamCorrente.Progetto = new Progetto("undos", "tres");
                th.AvviaNuovoSprint(th.TeamCorrente.CodiceUnivoco);
                th.TeamCorrente.confermaAvvioSprint();
                Assert.IsTrue(th.TeamCorrente.haSprintAttivo());
            }
            catch (KeyNotFoundException)
            {
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ConfermaAvvioSprintTest()
        {//AvviaNuovoSprint e ConfermaAvvioSprint sono testati insieme. L'uno ha bisogno dell'altro
            try
            {
                th.CreaTeam("filippoargenti");
                th.ConfermaCreaTeam();
                th.TeamCorrente.Progetto = new Progetto("undos", "tres");
                th.AvviaNuovoSprint(th.TeamCorrente.CodiceUnivoco);
                th.TeamCorrente.confermaAvvioSprint();
                Assert.IsTrue(th.TeamCorrente.haSprintAttivo());
            }
            catch (KeyNotFoundException)
            {
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void AggiungiTaskASprintTest()
        {
            try
            {
                th.CreaTeam("filippoargenti");
                th.ConfermaCreaTeam();
                th.TeamCorrente.Progetto = new Progetto("undos", "tres");
                th.TeamCorrente.Progetto.InserisciNuovaUserStory("nome", "descrizione");

                th.TeamCorrente.Progetto.InserisciNuovoTask("nome", "descrizione");

                th.TeamCorrente.Progetto.ConfermaInserimentoUserStory();
                th.AvviaNuovoSprint(th.TeamCorrente.CodiceUnivoco);
                th.TeamCorrente.confermaAvvioSprint();
                string codice_task = th.TeamCorrente.Progetto.getTasks()[0].CodiceIdentificativo;
                th.AggiungiTaskASprint(codice_task, 0);

                Assert.IsNotNull(th.TeamCorrente.SprintAttivo.getTask(codice_task));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void AssociaTaskSprintAImpiegato()
        {
            try
            {
                th.CreaTeam("filippoargenti");
                th.ConfermaCreaTeam();
                th.TeamCorrente.Progetto = new Progetto("undos", "tres");
                th.TeamCorrente.Progetto.InserisciNuovaUserStory("nome", "descrizione");

                th.TeamCorrente.Progetto.InserisciNuovoTask("nome", "descrizione");

                th.TeamCorrente.Progetto.ConfermaInserimentoUserStory();
                th.AvviaNuovoSprint(th.TeamCorrente.CodiceUnivoco);
                th.TeamCorrente.confermaAvvioSprint();
                string codice_task = th.TeamCorrente.Progetto.getTasks()[0].CodiceIdentificativo;
                th.AggiungiTaskASprint(codice_task, 0);

                Impiegato impiegato = new Impiegato("gh", "fdh", "dfhs", "dsf", "fds");
                th.TeamCorrente.addImpiegato(impiegato);
                m.addImpiegato(impiegato);
                th.AssociaTaskSprintAImpiegato(impiegato.CodiceUnivoco);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void SelezionaTeamBoardTest()
        {
            try
            {

            }
            catch
            {

            }
        }

        [TestMethod()]
        public void SelezionaTaskBacklogsTest()
        {
            try
            {

            }
            catch
            {

            }
        }

        [TestMethod()]
        public void AggiungiTaskAColonnaTest()
        {
            try
            {

            }
            catch
            {

            }
        }

        [TestMethod()]
        public void SelezionaTaskBoardTest()
        {
            try
            {

            }
            catch
            {

            }
        }

        [TestMethod()]
        public void SpostaTaskTraColonneTest()
        {
            try
            {

            }
            catch
            {

            }
        }

        [TestMethod()]
        public void EliminaTaskDaBoardTest()
        {
            try
            {

            }
            catch
            {

            }
        }

        [TestMethod()]
        public void SelezionaSprintAttivoTest()
        {
            try
            {

            }
            catch
            {

            }
        }

        [TestMethod()]
        public void ConfermaTerminaSprintTest()
        {
            try
            {

            }
            catch
            {

            }
        }
    }
}
