using Microsoft.VisualStudio.TestPlatform.Common.Telemetry;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moira.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio.Tests
{
    [TestClass()]
    public class MoiraClassTests
    {

        static MoiraClass m;

        [ClassInitialize]
        public static void AssemblyInit(TestContext context)
        {
            m = MoiraClass.Instance;
        }



        [TestMethod()]
        public void InserisciNuovoProgettoTest()
        {

            try
            {
                //verifichiamo che il progetto corrente non sia nullo
                m.InserisciNuovoProgetto("progetto", "descrizione");
                Assert.IsNotNull(m.Corrente);
            }
            catch 
            {

                Assert.Fail();
            }
            
        }

        [TestMethod()]
        public void AssociaTeamAProgettoTest()
        {

            try
            {
                m.InserisciNuovoProgetto("progetto", "descrizione");

                // a primo avviamento viene creato di default un team con codice univoco 0
                m.AssociaTeamAProgetto("0");
                Assert.IsNotNull(m.TeamSpecifico("0"));
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
                //creiamo un istanza di cliente
                Cliente c = new Cliente("peppino", "impanato");

                //inseriamo progetto
                m.InserisciNuovoProgetto("progetto", "descrizione");

                //aggiungiamo il nuovo cliente
                m.NuovoCliente(c);
                m.AssociaClienteAProgetto(c.CodiceUnivoco);

                //verifichiamo che il cliente è inserito nel dizionario
                Assert.IsTrue(m.Corrente.IsClienteInterested(c));
            }
            catch
            {
                Assert.Fail();
            }
        }

        //ConfermaInserimentoProgetto e SelezionaProgetto vengono verificati con la stessa procedura
        //creo un nuovo progetto con "InserisciNuovoProgetto" e questo viene inserito automaticamente in "corrente"
        //successivamente faccio "ConfermaInserimentoProgetto" per farlo aggiungere al dizionario dei progetti di Moira
        //per verificare che corrente si aggiorni con il progetto dal dizionario, inserisco ciarpame in "corrente" e poi
        //aggiorno quest'ultimo con il progetto precedente ["progetto"]
        [TestMethod()]
        public void ConfermaInserimentoProgettoTest()
        {
            try
            {
                m.InserisciNuovoProgetto("banana", "descrizione");
                m.ConfermaInserimentoProgetto();
                m.InserisciNuovoProgetto("agagagaga", "ciao");
                m.SelezionaProgetto("banana");
                Assert.AreEqual("banana", m.Corrente.Nome);
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
                m.InserisciNuovoProgetto("banana", "descrizione");
                m.ConfermaInserimentoProgetto();
                m.InserisciNuovoProgetto("fdsfdsf", "ciao");
                m.SelezionaProgetto("banana");
                Assert.AreEqual("banana", m.Corrente.Nome);
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
                m.InserisciNuovoProgetto("banana", "descrizione");

                //verifihiamo il corretto inserimento della user story
                Assert.IsNotNull(m.InserisciNuovaUserStory("story", "laPrima"));
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
                m.InserisciNuovoProgetto("banana", "descrizione");

                //user story corrente
                m.InserisciNuovaUserStory("story", "LaPrima");

                //verifica inserimento primo task
                Assert.AreEqual("0", m.InserisciNuovoTask("task", "primo"));
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
                m.InserisciNuovoProgetto("banana", "descrizione");

                //set posizione
                m.InserisciPosizioneUserStory(0);

                //verifichiamo che sia la prima user story
                Assert.AreEqual(0, m.Corrente.PosizioneUserStory);
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
                UserStory u = new UserStory("story", "LaPrima");  
                m.InserisciNuovoProgetto("banana", "descrizione");
                m.ConfermaInserimentoUserStory();

                //verichiamo la user story è inserita correttamente
                Assert.AreEqual("story", u.NomeUserStory);

            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}