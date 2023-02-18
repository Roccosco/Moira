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
                th.ConfermaCreaImpiegato();
                th.SelezionaImpiegatoCorrente("0");
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
                Assert.IsNotNull(m.GetImpiegatoSpecifico("0"));
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
        public void CreaCerimoniaTest()
        {
            try
            {
                th.CreaTeam("filippoargenti");
                th.ConfermaCreaTeam();
                th.TeamCorrente.Progetto = new Progetto("undos", "tres");
                DateTime dateTime = DateTime.Now;
                TimeSpan timeSpan = TimeSpan.FromSeconds(6);
                string codice_team = th.TeamCorrente.CodiceUnivoco;
                th.CreaCerimonia("Nepeta", "Buono", dateTime, timeSpan, TipoCerimonia.sporadica, codice_team);
                th.ConfermaCreaCerimonia();
                Assert.IsTrue(th.TeamCorrente.HaGiaCerimonie(dateTime, timeSpan));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void InvitoCerimoniaTest()
        {
            try
            {
                th.CreaTeam("filippoargenti");
                th.ConfermaCreaTeam();
                Cliente cliente = new Cliente("Capa", "Rezza");
                m.addCliente(cliente);
                th.TeamCorrente.Progetto = new Progetto("undos", "tres");
                th.TeamCorrente.Progetto.SetCliente(cliente);
                DateTime dateTime = DateTime.Now;
                TimeSpan timeSpan = TimeSpan.FromSeconds(6);
                string codice_team = th.TeamCorrente.CodiceUnivoco;
                th.CreaCerimonia("Acufene", "Brutto", dateTime, timeSpan, TipoCerimonia.sporadica, codice_team);

                th.InvitoCerimonia(cliente.CodiceUnivoco);
                th.ConfermaCreaCerimonia();
                Assert.IsTrue(th.TeamCorrente.CerimoniaCorrente.IsClienteInterested(cliente.CodiceUnivoco));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ConfermaCreaCerimoniaTest()
        {//CreaCerimonia e ConfermaCreaCerimonia hanno bisogno l'uno dell'altro, quindi si possono testare allo stesso modo
            try
            {
                th.CreaTeam("filippoargenti");
                th.ConfermaCreaTeam();
                th.TeamCorrente.Progetto = new Progetto("undos", "tres");
                DateTime dateTime = DateTime.Now;
                TimeSpan timeSpan = TimeSpan.FromSeconds(6);
                string codice_team = th.TeamCorrente.CodiceUnivoco;
                th.CreaCerimonia("Nepeta", "Buono", dateTime, timeSpan, TipoCerimonia.sporadica, codice_team);
                th.ConfermaCreaCerimonia();
                Assert.IsTrue(th.TeamCorrente.HaGiaCerimonie(dateTime, timeSpan));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
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
                Team team = new Team("cipollino");
                m.addTeam(team);
                m.GetTeamSpecifico(team.CodiceUnivoco).creaBoard("formazione555");
                m.GetTeamSpecifico(team.CodiceUnivoco).confermaCreaBoard();
                th.SelezionaTeamBoard(team.CodiceUnivoco);
                Assert.IsNotNull(th.TeamCorrente);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void SelezionaTaskBacklogsTest()
        {
            try
            {
                th.CreaTeam("Larsen");
                th.ConfermaCreaTeam();
                th.TeamCorrente.creaBoard("ilariacondizionata");
                th.TeamCorrente.confermaCreaBoard();
                th.TeamCorrente.Progetto = new Progetto("Torna", "Catalessi");
                th.TeamCorrente.Progetto.InserisciNuovaUserStory("el", "sendero");
                th.TeamCorrente.Progetto.InserisciNuovoTask("come", "prypjat");
                th.TeamCorrente.Progetto.ConfermaInserimentoUserStory();
                MoiraTask task = th.TeamCorrente.Progetto.getTasks()[0];
                th.SelezionaTaskBacklogs(task.CodiceIdentificativo);
                th.TeamCorrente.Board.addTaskColonna("0");
                Assert.IsNotNull(th.TeamCorrente.Board.Colonne[0].getTask(task.CodiceIdentificativo));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void SelezionaSprintAttivoTest()
        {
            th.CreaTeam("filippoargenti");
            th.ConfermaCreaTeam();
            th.TeamCorrente.Progetto = new Progetto("undos", "tres");
            th.SelezionaSprintAttivo(th.TeamCorrente.CodiceUnivoco);
        }

        [TestMethod()]
        public void ConfermaTerminaSprintTest()
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

                th.ConfermaTerminaSprint();
                Assert.IsFalse(th.TeamCorrente.haSprintAttivo());
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}
