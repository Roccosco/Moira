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
    public class ProgettoTests
    {
        [TestMethod()]
        public void ProgettoTest()
        {
            //verifichiamo che l'istanza creata non è nulla
            Progetto p = new Progetto("progetto", "ciao");
            Assert.IsNotNull(p);    
        }

        [TestMethod()]
        public void SetClienteTest()
        {
            try
            {
                //verichiamo se un cliente è inserito correttamente
                Progetto p = new Progetto("progetto", "ciao");
                Cliente c = new Cliente("gabri", "greco");
                p.SetCliente(c);
                Assert.IsTrue(p.IsClienteInterested(c));
            }
            catch 
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void InserisciUserStoryTest()
        {
            try
            {   
                //progetto associato all user story
                Progetto p = new Progetto("progetto", "ciao");

                //verifichiamo id prima user story
                string id = p.InserisciNuovaUserStory("story", "descrizione");
                Assert.AreEqual("0", id);

                //verifichiamo id seconda user story
                string id2 = p.InserisciNuovaUserStory("story2", "descrizione2");
                Assert.AreEqual("1", id2);

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
                //progetto corrente associato alla user story
                Progetto p = new Progetto("progetto", "descrizione");

                p.InserisciNuovaUserStory("story", "LaPrima");
                //abbiamo verificato che si tratta del primo task
                Assert.AreEqual("0", p.InserisciNuovoTask("task", "primo"));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void SetPosizioneNuovaUserStoryTest()
        {
            try
            {
                //creo un nuovo progetto in cui inserisco due UserStory
                int i = 0;
                Progetto p = new Progetto("progetto", "ciao");
                
                //creiamo piu user story per aumentare la grandezza del backlog 
                p.InserisciNuovaUserStory("story", "descrizione");
                p.ConfermaInserimentoUserStory();

                p.InserisciNuovaUserStory("story2", "descrizione2");
                p.ConfermaInserimentoUserStory();
                
                //le due stories possono essere selezionate passando come parametro 0 per
                //la prima e 1 per la seconda
                //il test va a buon fine se possiamo accedere ad entrambe le stories
                p.SetPosizioneNuovaUserStory(i);
                Assert.AreEqual(i,p.PosizioneUserStory);

                i = i + 1;
                p.SetPosizioneNuovaUserStory(i);
                Assert.AreEqual(i, p.PosizioneUserStory);

            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void CheckPosizionePossibileTest()
        {
            try
            {
                int i = 0;
                //serve un'istanza di progetto
                Progetto p = new Progetto("progetto", "ciao");
                //di default ho solo una userstory e si trova in posizione 0
                p.SetPosizioneNuovaUserStory(i);

                Assert.IsTrue(p.CheckPosizionePossibile(i));
                Assert.IsFalse(p.CheckPosizionePossibile(i + 1));
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
                //la user story inserita è uguale alla user story corrente
                Progetto p = new Progetto("progetto", "ciao");
                p.InserisciNuovaUserStory("story", "descrizione");
                p.ConfermaInserimentoUserStory();
                Assert.IsTrue(p.CheckPosizionePossibile(0));
            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}