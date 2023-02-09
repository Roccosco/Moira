using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moira.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio.Controllers.Tests
{
    [TestClass()]
    public class Class1
    {
        static ClienteHandler ch;
        static MoiraClass m;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            //m = MoiraClass.Instance;
            //ch = new ClienteHandler();
        }

        [TestInitialize]
        public static void TestInitialize(TestContext context)
        {
            m = MoiraClass.Instance;
            ch = new ClienteHandler();
        }

        [TestMethod()]
        public void AssociaClienteAProgettoTest()
        {
            try
            {
                m.addProgetto(new Progetto("kilimangiaro", "batussi"));
                ch.SelezionaClienteCorrente("0");
                ch.AssociaClienteAProgetto("kilimangiaro");
                Assert.IsTrue(m.GetProgettoSpecifico("kilimangiaro").IsClienteInterested(ch.ClienteCorrente));
            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}
