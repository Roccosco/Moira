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

        [TestMethod()]
        public void AssociaTeamAProgettoTest()
        {
            try
            {
                Progetto p = new Progetto("progetto", "descrizione");
                m.addProgetto(p);
                // con il caso d'uso d'avviamento viene creato di default un team con codice univoco 0
                ph.SelezionaProgetto("progetto");
                ph.AssociaTeamAProgetto("0");
                Assert.IsNotNull(m.GetTeamSpecifico("0").Progetto);
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
                ph.AssociaClienteAProgetto("1");
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
                Assert.AreEqual("progetto", ph.Corrente.Nome);
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
                Assert.AreEqual("progetto", ph.Corrente.Nome);
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
                Assert.AreEqual(0, ph.Corrente.PosizioneUserStory);
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
                Assert.IsTrue(ph.Corrente.CheckPosizionePossibile(0));
            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}
