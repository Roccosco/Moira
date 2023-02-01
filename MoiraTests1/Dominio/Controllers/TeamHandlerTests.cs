using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moira.Dominio;
using Moira.Dominio.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoiraTests1.Dominio.Controllers
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

        //non va
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

        //non va
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
                Assert.IsNotNull(m.GetTeamSpecifico("1")); //1 perchè esiste già un team
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
                th.CreaBoard("China", "0");
                th.CreaColonna("Town", false);
                th.ConfermaCreaBoard();
                Assert.Fail();
                //non è ancora ben definita questa parte
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
    }
}
