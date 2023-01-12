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
            Progetto p = new Progetto("progetto", "ciao");
            Assert.IsNotNull(p);    
        }

        [TestMethod()]
        public void SetClienteTest()
        {
            try
            {
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
                //perche funziona con 0?
                Progetto p = new Progetto("progetto", "ciao");
                string id = p.InserisciUserStory("story", "descrizione");
                Assert.AreEqual("0", id);

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
        public void SetPosizioneNuovaUserStoryTest()
        {
            try
            {
                int i = 0;  
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
        public void CheckPosizionePossibileTest()
        {
            try
            {
                int i = 0;
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