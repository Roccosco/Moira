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
                string id = p.InserisciUserStory("story", "descrizione");
                Assert.AreEqual("0", id);

                //verifichiamo id seconda user story
                string id2 = p.InserisciUserStory("story2", "descrizione2");
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

                p.InserisciUserStory("story", "LaPrima");
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
                //vale sia la posizione 0 che la posizione 1 perche la posizione è >=0 e <= alla grandezza del backlog
                int i = 0;
                Progetto p = new Progetto("progetto", "ciao");
                
                //creiamo piu user story per aumentare la grandezza del backlog (in questo caso 0 e 1, due posti nel backlog)
                p.InserisciUserStory("story", "descrizione");
                p.ConfermaInserimentoUserStory();

                p.InserisciUserStory("story2", "descrizione2");
                p.ConfermaInserimentoUserStory();
                p.SetPosizioneNuovaUserStory(i);
                

                Assert.IsNotNull(i);    
                
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
                p.SetPosizioneNuovaUserStory(i);
                p.CheckPosizionePossibile(i);
                Assert.IsNotNull(i);
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
                p.InserisciUserStory("story", "descrizione");
                Assert.AreEqual("story", p.Corrente.NomeUserStory);

            }
            catch
            {

                Assert.Fail();
            }
        }
    }
}