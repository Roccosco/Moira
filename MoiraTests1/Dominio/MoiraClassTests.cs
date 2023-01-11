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

        MoiraClass m;



        [TestMethod()]
        public void InserisciNuovoProgettoTest()
        {
            

            try
            {
                m.InserisciNuovoProgetto("progetto", "descrizione");
                Assert.IsNotNull(m.Project);
            }
            catch 
            {

                Assert.Fail();
            }
           
            

            
        }

        [TestMethod()]
        public void AssociaTeamAProgettoTest()
        {

            

            
        }

        [TestMethod()]
        public void AssociaClienteAProgettoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ConfermaInserimentoProgettoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SelezionaProgettoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InserisciNuovaUserStoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InserisciNuovoTaskTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InserisciPosizioneUserStoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ConfermaInserimentoUserStoryTest()
        {
            Assert.Fail();
        }
    }
}