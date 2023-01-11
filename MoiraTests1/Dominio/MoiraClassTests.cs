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
                m.AssociaTeamAProgetto("0"); // a primo avviamento viene creato di default un team con codice univoco 0
                //seppur brutto, dovrebbe funzionare a primo colpo
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
                Cliente c = new Cliente("peppino", "impanato");
                m.InserisciNuovoProgetto("progetto", "descrizione");
                m.NuovoCliente(c);
                m.AssociaClienteAProgetto(c.CodiceUnivoco);
                Assert.IsTrue(m.Corrente.IsClienteInterested(c));
            }
            catch
            {
                Assert.Fail();
            }
        }

        //ConfermaInserimentoProgetto e SelezionaProgetto vengono verificati con la stessa procedura
        //secondo la nostra logica [gabri e ale] l'uno serve all'altro per verificarsi
        //creo un nuovo progetto con "InserisciNuovoProgetto" e questo viene inserito automaticamente in "corrente"
        //successivamente faccio "ConfermaInserimentoProgetto" per farlo aggiungere al dizionario dei progetti di Moira
        //per verificare che corrente si aggiorni con il progetto dal dizionario, inserisco ciarpame in "corrente" e poi aggiorno quest'ultimo con il progetto precedente ["progetto"]
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

            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}