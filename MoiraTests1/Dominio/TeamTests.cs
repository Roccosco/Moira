﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moira.Dominio;
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
                
            }
            catch
            {
                Assert.Fail();
            }

        }

        [TestMethod()]
        public void TerminaSprintTest()
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
        public void getTaskPerBoardTest()
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
        public void EliminaTaskDaBoardTest()
        {
            try
            {

            }
            catch
            {
                Assert.Fail();
            }

        }
    }
}