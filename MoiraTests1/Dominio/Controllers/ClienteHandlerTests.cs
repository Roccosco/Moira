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
    public class ClienteHandlerTests
    {
        static ClienteHandler ch;
        static MoiraClass m;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
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

        [TestMethod()]
        public void ConfermaCreaClienteTest()
        {
            try
            {
                ch.CreaCliente("lello", "bello", "ciello@mello.com", "1240", "SuonaFischiaECanta", "vialemanidalnaso");
                ch.ConfermaCreaCliente();
                Assert.IsNotNull(m.GetClienteSpecifico("1"));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void SelezionaClienteCorrenteTest()
        {
            try
            {
                ch.CreaCliente("lello", "bello", "ciello@mello.com", "1240", "SuonaFischiaECanta", "vialemanidalnaso");
                ch.ConfermaCreaCliente();
                ch.SelezionaClienteCorrente("0");
                ch.SelezionaClienteCorrente("1");
                Assert.AreEqual("1240", ch.ClienteCorrente.PartitaIVA);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void ResetInfoClienteTest()
        {
            try
            {
                ch.CreaCliente("tu", "sei", "pazzo", "mica", "Van", "Gogh");
                ch.ResetInfoCliente("sono", "fuori", "dal", "tunnel");
                Assert.AreEqual("fuori", ch.ClienteCorrente.PartitaIVA);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void DisassociaClienteAProgettoTest()
        {
            try
            {
                ch.CreaCliente("delfini", "spiaggie", "elefanti", "cimiteri", "nuvole", "orizzonte");
                m.addProgetto(new Progetto("gru", "giù"));
                m.GetProgettoSpecifico("gru").SetCliente(ch.ClienteCorrente);
                ch.DisassociaClienteAProgetto("gru");
                Assert.IsFalse(m.GetProgettoSpecifico("gru").IsClienteInterested(ch.ClienteCorrente));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void EliminaClienteTest()
        {
            ch.EliminaCliente("0");
            ch.EliminaCliente("0");
        }
    }
}
