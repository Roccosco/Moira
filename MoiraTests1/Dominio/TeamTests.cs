using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moira.Dominio;
using Moira.Dominio.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio.Tests
{
    [TestClass()]
    public class TeamTests
    {
        static MoiraClass m;
        [TestInitialize]
        public void TestInitialize()
        {
            m = MoiraClass.Instance;
        }

        [TestMethod()]
        public void TeamTest()
        {
            try
            {
               //verifichiamo che l'istanza creata non è nulla
               Team tm = new Team("MoiraTestTeam");
               Assert.IsNotNull(tm);
            }
            catch
            {
                Assert.Fail();
            }

        }

        [TestMethod()]
        public void HaGiaCerimonieTest()
        {
            try
            {
                Team team = new Team("filippoargenti");
                m.addTeam(team);
                string codice_team = m.GetTeamSpecifico(team.CodiceUnivoco).CodiceUnivoco;
                m.GetTeamSpecifico(codice_team).Progetto= new Progetto("undos", "tres");
                DateTime dateTime = DateTime.Now;
                TimeSpan timeSpan = TimeSpan.FromSeconds(6);
                
                team.CreaCerimonia("Nepeta", "Buono", TipoCerimonia.sporadica, dateTime,timeSpan );
                team.confermaCreaCerimonia();
                Assert.IsTrue(team.HaGiaCerimonie(dateTime, timeSpan));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

        }

        [TestMethod()]
        public void getTaskPerBoardTest()
        {
            try
            {
                Team team = new Team("RezzaCapa");
                m.addTeam(team);
                team.Progetto = new Progetto("prisoner", "709");
                team.creaBoard("abiuradime");
                team.confermaCreaBoard();
                team.Progetto.InserisciNuovaUserStory("filippo", "argenti");
                team.Progetto.InserisciNuovoTask("tu", "sei");
                team.Progetto.InserisciNuovoTask("pazzo", "mica");
                team.Progetto.InserisciNuovoTask("Van", "Gogh");
                team.Progetto.ConfermaInserimentoUserStory();
                int conta = team.getTaskPerBoard().Count();
                Assert.AreEqual(3, conta);
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }

        }
    }
}