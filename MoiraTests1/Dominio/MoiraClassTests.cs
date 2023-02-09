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
        public void addProgettoTest()
        {
            try
            {
                Progetto p = new Progetto("progetto", "descrizione");
                m.addProgetto(p);
                Assert.IsNotNull(m.GetProgettoSpecifico("progetto"));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void IsProgettoSpecificoTest()
        {
            try
            {
                m.addProgetto(new Progetto("one", "descrizione"));
                m.addProgetto(new Progetto("two", "descrizione"));
                m.addProgetto(new Progetto("three", "descrizione"));
                m.addProgetto(new Progetto("four", "descrizione"));
                m.addProgetto(new Progetto("canihavealittlemore", "descrizione"));
                Assert.IsTrue(m.IsProgettoSpecifico("three"));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void GetProgettoSpecifico()
        {
            try
            {
                m.addProgetto(new Progetto("one", "descrizione"));
                m.addProgetto(new Progetto("two", "descrizione"));
                m.addProgetto(new Progetto("three", "descrizione"));
                m.addProgetto(new Progetto("four", "descrizione"));
                m.addProgetto(new Progetto("canihavealittlemore", "descrizione"));
                Assert.IsNotNull(m.GetProgettoSpecifico("three"));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void addTeamTest()
        {
            try
            {
                Team t = new Team("oceanman");
                m.addTeam(t);
                Assert.IsNotNull(m.GetTeamSpecifico(t.CodiceUnivoco));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void GetTeamSpecificoTest()
        {
            try
            {
                Team t = new Team("oceanman");
                m.addTeam(t);
                Assert.IsNotNull(m.GetTeamSpecifico(t.CodiceUnivoco));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void deleteTeamTest()
        {
            Team t = new Team("oceanman");
            m.addTeam(t);
            m.deleteTeam(t.CodiceUnivoco);
            m.deleteTeam(t.CodiceUnivoco);
        }

        //soprattutto la gestione dei CodiciUnivoci
        [TestMethod()]
        public void addImpiegatoTest()
        {
            try
            {
                Impiegato impiegato = new Impiegato("lello", "bello", "ciello@mello.com", "1240", "vialemanidalnaso");
                m.addImpiegato(impiegato);
                Assert.IsNotNull(m.GetImpiegatoSpecifico(impiegato.CodiceUnivoco));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void GetImpiegatoSpecifico()
        {
            try
            {
                Impiegato impiegato = new Impiegato("lello", "bello", "ciello@mello.com", "1240", "vialemanidalnaso");
                m.addImpiegato(impiegato);
                Assert.IsNotNull(m.GetImpiegatoSpecifico(impiegato.CodiceUnivoco));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void deleteImpiegatoTest()
        {
            Impiegato impiegato = new Impiegato("lello", "bello", "ciello@mello.com", "1240", "vialemanidalnaso");
            m.addImpiegato(impiegato);
            m.deleteImpiegato(impiegato.CodiceUnivoco);
            m.GetImpiegatoSpecifico(impiegato.CodiceUnivoco);
        }

        [TestMethod()]
        public void addClienteTest()
        {
            try
            {
                Cliente cliente = new Cliente("pane", "cunzato");
                m.addCliente(cliente);
                Assert.IsNotNull(m.GetClienteSpecifico(cliente.CodiceUnivoco));

            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void GetClienteSpecificoTest()
        {
            try
            {
                Cliente cliente = new Cliente("pane", "cunzato");
                m.addCliente(cliente);
                Assert.IsNotNull(m.GetClienteSpecifico(cliente.CodiceUnivoco));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void deleteClienteTest()
        {
            Cliente cliente = new Cliente("pane", "cunzato");
            m.addCliente(cliente);
            m.deleteCliente(cliente.CodiceUnivoco);
            m.GetClienteSpecifico(cliente.CodiceUnivoco);
        }
    }
}