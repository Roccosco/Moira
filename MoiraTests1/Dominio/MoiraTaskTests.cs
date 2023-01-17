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
    public class MoiraTaskTests
    {
        [TestMethod()]
        public void MoiraTaskTest()
        {
            try
            {
                //verifichiamo che l'istanza creata non è nulla
                MoiraTask tsk = new MoiraTask("task", "descrizione");
                Assert.IsNotNull(tsk);
            }
            catch 
            {
                Assert.Fail();
            }
        }
    }
}