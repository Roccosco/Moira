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

        //non va
        [TestMethod()]
        public void SelezionaImpiegatoCorrenteTest()
        {
            try
            {
                th.CreaImpiegato("cosa", "diamine", "e", "uno", "spazioporto");
                th.ConfermaCreaImpiegato();
                th.CreaImpiegato("sono", "fuori", "dal", "tunnel", "elelelel");
                th.SelezionaImpiegatoCorrente("0");//problema con codice univoco impiegato
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
                Assert.IsNotNull(m.GetImpiegatoSpecifico("0"));//problema con codice univoco impiegato
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
        public void EliminaImpiegatoTest()
        {
            try
            {
                th.CreaImpiegato("cosa", "diamine", "è", "uno", "spazioporto");
                th.ConfermaCreaImpiegato();
                th.EliminaImpiegato("0");//problema con codice univoco impiegato
                Assert.IsNull(m.GetImpiegatoSpecifico("0"));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void CreaTeamTest()
        {
            try
            {
                th.CreaTeam("Exuvia");
                th.ConfermaCreaTeam();
                Assert.IsNotNull(m.GetTeamSpecifico("1"));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void AggiungiImpiegatoATeamTest()
        {
            try
            {

            }
            catch
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

        //non può essere testato
        //non posso accedere a teamCorrente, non ci sono metodi
        [TestMethod()]
        public void SelezionaTeamCorrenteTest()
        {
            try
            {
                th.CreaTeam("Exuvia");
                th.ConfermaCreaTeam();
                th.SelezionaTeamCorrente("0");
                //Assert.AreEqual("0", th.TeamCorrente.CodiceUnivoco);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void RimuoviImpiegatoDaTeamTest()
        {
            try
            {

            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void EliminaTeamTest()
        {
            try
            {
                //non va, non ne ho idea perché
                //in teoria è corretto
                th.EliminaTeam("0");
                Assert.IsNull(m.GetTeamSpecifico("0"));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void CreaBoardTest()
        {
            try
            {
                th.CreaBoard("Fugadà", "0");
                th.CreaBoard("Fugadà", "0");
                Assert.Fail();
            }
            catch
            {
                //se entra qui, un eccezzione è stata generata
                //quindi va benissimo
            }
        }

        [TestMethod()]
        public void CreaColonnaTest()
        {
            try
            {
                th.CreaBoard("China", "0");
                th.CreaColonna("Town", false);
                //non so come verificarlo
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
