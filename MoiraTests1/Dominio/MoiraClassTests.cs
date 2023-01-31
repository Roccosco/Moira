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
                Assert.IsNotNull(m.GetTeamSpecifico("0"));
            }
            catch
            {
                Assert.Fail();
            }
        }

        //di base esiste il "MoiraTeam" nella classe Moira, con codice "0"
        [TestMethod()]
        public void GetTeamSpecificoTest()
        {
            try
            {
                Assert.IsNotNull(m.GetTeamSpecifico("0"));
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
            m.deleteTeam("0");
            m.GetTeamSpecifico("0");
        }

        //????? non ho capito bene come funziona l'inserimento degli impiegati
        [TestMethod()]
        public void addImpiegatoTest()
        {
            try
            {
                m.addImpiegato(new Impiegato("lello", "bello", "ciello@mello.com", "1240", "vialemanidalnaso"));
                Assert.IsNotNull(m.GetImpiegatoSpecifico("0"));
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
                m.addImpiegato(new Impiegato("lello", "bello", "ciello@mello.com", "1240", "vialemanidalnaso"));
                Assert.IsNotNull(m.GetImpiegatoSpecifico("0"));
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
            m.addImpiegato(new Impiegato("lello", "bello", "ciello@mello.com", "1240", "vialemanidalnaso"));
            m.deleteImpiegato("0");
            m.GetImpiegatoSpecifico("0");
        }

        [TestMethod()]
        public void addClienteTest()
        {
            try
            {
                m.addCliente(new Cliente("pane", "cunzato"));
                Assert.IsNotNull(m.GetClienteSpecifico("1"));

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
                Assert.IsNotNull(m.GetClienteSpecifico("0"));
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
            m.deleteCliente("0");
            m.GetClienteSpecifico("0");
        }
    }
}