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
    public class UserStoryTests
    {
        [TestMethod()]
        public void UserStoryTest()
        {
            try
            {
                //verifichiamo che l'istanza creata non è nulla
                UserStory u = new UserStory("story", "descrizione");
                Assert.IsNotNull(u);
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
                //verifichiamo inserendo il primo task
                UserStory u = new UserStory("story", "descrizione");
                Assert.AreEqual("0", u.InserisciNuovoTask("task", "descrizione"));

                //verifichiamo inserendo il secondo task
                Assert.AreEqual("1", u.InserisciNuovoTask("descrizione", "task"));

            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}