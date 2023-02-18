using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moira.Dominio.Controllers;
using Moira.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio.Controllers.Tests
{
    [TestClass]
    public class ClienteHandlerTests
    {
        static ClienteHandler ch;
        static MoiraClass m;

        [TestInitialize]
        public void TestInitialize()
        {
            ch = new ClienteHandler();
            m = MoiraClass.Instance;
        }

        [TestMethod()]
        public void AssociaClienteAProgettoTest()
        {
            try
            {
                m.addProgetto(new Progetto("kilimangiaro", "batussi"));
                Cliente c = new Cliente("nome", "cognome");
                m.addCliente(c);
                ch.SelezionaClienteCorrente(c.CodiceUnivoco);
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
                Assert.IsNotNull(m.GetClienteSpecifico("0"));
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

                ch.CreaCliente("nome", "cognome", "nome@gmail.com", "11", "3714524501", "vialemanidalnaso");
                ch.ConfermaCreaCliente();
                
                ch.SelezionaClienteCorrente("1");
                ch.SelezionaClienteCorrente("0");
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
