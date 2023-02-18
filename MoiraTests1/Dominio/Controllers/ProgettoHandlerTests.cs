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
    public class ProgettoHandlerTests
    {
        static ProgettoHandler ph;
        static MoiraClass m;

        [ClassInitialize]
        public static void AssemblyInit(TestContext context)
        {
            ph = new ProgettoHandler();
            m = MoiraClass.Instance;
        }

        [TestInitialize]
        public void TestInitialize()
        {
            ph = new ProgettoHandler();
            m = MoiraClass.Instance;
        }

        [TestMethod()]
        public void AssociaTeamAProgettoTest()
        {
            try
            {
                Team team = new Team("MoiraTeam");
                m.addTeam(team);

                Progetto p = new Progetto("progetto", "descrizione");
                m.addProgetto(p);
                // con il caso d'uso d'avviamento viene creato di default un team con codice univoco 0
                ph.SelezionaProgetto("progetto");
                ph.AssociaTeamAProgetto(team.CodiceUnivoco);
                Assert.IsNotNull(m.GetTeamSpecifico(team.CodiceUnivoco).Progetto);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void AssociaClienteAProgettoTest()
        {
            try
            {
                //inseriamo progetto
                Progetto p = new Progetto("progetto", "descrizione");
                m.addProgetto(p);
                // con il caso d'uso d'avviamento viene creato di default un cliente con codice univoco 0
                Cliente c = new Cliente("mario", "mario");
                m.addCliente(c);
                ph.SelezionaProgetto("progetto");
                ph.AssociaClienteAProgetto(c.CodiceUnivoco);
                //verifichiamo che il cliente è inserito nel dizionario
                Assert.IsTrue(m.GetProgettoSpecifico("progetto").IsClienteInterested(c));
            }
            catch
            {
                Assert.Fail();
            }
        }

        //ConfermaInserimentoProgetto e SelezionaProgetto vengono verificati secondo la stessa metodologia
        //creo un nuovo progetto con "InserisciNuovoProgetto" e questo viene inserito automaticamente in "progettoCorrente"
        //successivamente faccio "ConfermaInserimentoProgetto" per farlo aggiungere al dizionario dei progetti di Moira
        //per verificare che "progettoCorrente" si aggiorni con il progetto dal dizionario, richiamo "InserisciNuovoProgetto" con altri
        //dati per modificare "progettoCorrente" e chiamo "SelezionaProgetto" passando il nome di quello che ho creato all'inizio
        [TestMethod()]
        public void ConfermaInserimentoProgettoTest()
        {
            try
            {
                ph.InserisciNuovoProgetto("progetto", "descrizione");
                ph.ConfermaInserimentoProgetto();
                ph.InserisciNuovoProgetto("agagagaga", "ciao");
                ph.SelezionaProgetto("progetto");
                Assert.AreEqual("progetto", ph.ProgettoCorrente.Nome);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void SelezionaProgettoTest()
        {
            try
            {
                ph.InserisciNuovoProgetto("progetto", "descrizione");
                ph.ConfermaInserimentoProgetto();
                ph.InserisciNuovoProgetto("agagagaga", "ciao");
                ph.SelezionaProgetto("progetto");
                Assert.AreEqual("progetto", ph.ProgettoCorrente.Nome);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void InserisciNuovaUserStoryTest()
        {
            try
            {
                //progetto corrente
                ph.InserisciNuovoProgetto("banana", "descrizione");

                //verifichiamo il corretto inserimento della user story
                Assert.IsNotNull(ph.InserisciNuovaUserStory("story", "la prima"));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void InserisciNuovoTaskTest()
        {
            try
            {
                //progetto corrente
                ph.InserisciNuovoProgetto("banana", "descrizione");

                //user story corrente
                ph.InserisciNuovaUserStory("story", "la prima");

                //verifica inserimento primo task
                Assert.AreEqual("0", ph.InserisciNuovoTask("task", "primo"));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void InserisciPosizioneUserStoryTest()
        {
            try
            {
                //progetto corrente
                ph.InserisciNuovoProgetto("banana", "descrizione");

                //set posizione
                ph.InserisciPosizioneUserStory(0);

                //verifichiamo che sia la prima user story
                Assert.AreEqual(0, ph.ProgettoCorrente.PosizioneUserStory);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void ConfermaInserimentoUserStoryTest()
        {
            try
            {
                ph.InserisciNuovoProgetto("banana", "descrizione");
                ph.InserisciNuovaUserStory("story", "la prima");

                ph.ConfermaInserimentoUserStory();
                Assert.IsTrue(ph.ProgettoCorrente.CheckPosizionePossibile(0));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void SelezionaTaskModificaTest()
        {
            try
            {
                Team team = new Team("nonloso");
                m.addTeam(team);
                Progetto progetto = new Progetto("ilaria", "condizionata");
                m.addProgetto(progetto);
                ph.SelezionaProgetto("ilaria");
                ph.InserisciNuovaUserStory("prisoner", "709");
                ph.InserisciNuovoTask("comunque", "dada");
                ph.ConfermaInserimentoUserStory();
                ph.SelezionaTaskModifica(ph.ProgettoCorrente.getTasks()[0].CodiceIdentificativo);
                Assert.AreEqual(ph.ProgettoCorrente.TaskModifica.Nome, "comunque");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void ConfermaModificaTaskTest()
        {
            try
            {
                Team team = new Team("nonloso");
                m.addTeam(team);
                Progetto progetto = new Progetto("ilaria", "condizionata");
                m.addProgetto(progetto);
                ph.SelezionaProgetto("ilaria");
                ph.InserisciNuovaUserStory("prisoner", "709");
                ph.InserisciNuovoTask("comunque", "dada");
                ph.ConfermaInserimentoUserStory();
                ph.SelezionaTaskModifica(ph.ProgettoCorrente.getTasks()[0].CodiceIdentificativo);
                ph.ProgettoCorrente.TaskModifica.Nome = "cabaret";
                ph.ConfermaModificaTask("cabaret", "voltaire");
                Assert.AreEqual(ph.ProgettoCorrente.TaskModifica.Nome, "cabaret");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void SpostaUserStoryTest()
        {
            try
            {
                Team team = new Team("nonloso");
                m.addTeam(team);
                Progetto progetto = new Progetto("ilaria", "condizionata");
                m.addProgetto(progetto);
                ph.SelezionaProgetto("ilaria");
                ph.InserisciNuovaUserStory("se", "pensi");
                ph.InserisciNuovoTask("che", "possa"); //0
                ph.InserisciNuovoTask("cambiare", "il");//1
                ph.InserisciNuovoTask("mondo", "ti");//2
                ph.InserisciPosizioneUserStory(0);
                ph.ConfermaInserimentoUserStory();

                ph.InserisciNuovaUserStory("sbagli", "alla");
                ph.InserisciNuovoTask("grande", "è");//3
                ph.InserisciNuovoTask("già", "tanto");//4
                ph.InserisciNuovoTask("se", "mi");//5
                ph.InserisciPosizioneUserStory(1);
                ph.ConfermaInserimentoUserStory();

                string codice_userstory = ph.InserisciNuovaUserStory("cambio", "le");
                ph.InserisciNuovoTask("mutande", "voglio");//6
                ph.InserisciNuovoTask("solo", "darti");//7
                ph.InserisciNuovoTask("un_emicrania", "lancinante");//8
                ph.InserisciPosizioneUserStory(2);
                ph.ConfermaInserimentoUserStory();

                ph.SpostaUserStory(codice_userstory, 1);
                string nome_effective = ph.ProgettoCorrente.getTasks()[3].Nome;

                Assert.AreEqual("mutande", nome_effective);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
