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
    public class BoardTests
    {
        static MoiraClass m;
        [ClassInitialize]
        public static void AssemblyInit(TestContext context)
        {
            m = MoiraClass.Instance;
        }

        [TestMethod()]
        public void creaColonnaTest()
        {
            try
            {
                Board board = new Board("kilimangiaro");
                board.creaColonna("Produzione", false);
                Assert.AreEqual((int)board.Colonne.Count(), (int)2);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void CreaColonnaDaRivedereTest()
        {
            try
            {
                //non deve essere generata eccezzione
                //per avere successo nel test
                Board board = new Board("maracaibo");
                board.creaColonna("dsa", true);
                MoiraTask task = new MoiraTask("das", "da");
                board.setTaskCorrente(task);
                board.addTaskColonna(board.Colonne[0].CodiceIdentificativo); //colonna cestinato
                board.SelezionaTask(task.CodiceIdentificativo, board.Colonne[0].CodiceIdentificativo);
                board.SpostaTaskTraColonne(board.Colonne[1].CodiceIdentificativo, false, true);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void setTaskCorrenteTest()
        {
            Board board = new Board("maracaibo");
            MoiraTask task = new MoiraTask("das", "da");
            board.setTaskCorrente(task);
        }

        [TestMethod()]
        public void addTaskColonnaTest()
        {
            try
            {
                Board board = new Board("maracaibo");
                MoiraTask task = new MoiraTask("das", "da");
                board.setTaskCorrente(task);
                board.addTaskColonna(board.Colonne.First().CodiceIdentificativo); //colonna cestinato
                Assert.AreEqual(task, board.Colonne.First().getTask(task.CodiceIdentificativo));
            }
            catch
            {
                Assert.Fail();
            }
        }

        //unico modo che mi viene in mente per testarlo
        [TestMethod()]
        public void SelezionaTaskTest()
        {
            try
            {
                Board board = new Board("maracaibo");
                board.creaColonna("dsa", false);
                MoiraTask task = new MoiraTask("das", "da");
                board.setTaskCorrente(task);
                board.addTaskColonna(board.Colonne[0].CodiceIdentificativo); //colonna cestinato
                board.SelezionaTask(task.CodiceIdentificativo, board.Colonne[0].CodiceIdentificativo);
                board.SpostaTaskTraColonne(board.Colonne[1].CodiceIdentificativo, false, false);
                Assert.AreEqual(task, board.Colonne[1].getTask(task.CodiceIdentificativo));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void SpostaTaskTraColonneTest()
        {
            try
            {
                Board board = new Board("maracaibo");
                board.creaColonna("dsa", false);
                MoiraTask task = new MoiraTask("das", "da");
                board.setTaskCorrente(task);
                board.addTaskColonna(board.Colonne[0].CodiceIdentificativo); //colonna cestinato
                board.SelezionaTask(task.CodiceIdentificativo, board.Colonne[0].CodiceIdentificativo);
                board.SpostaTaskTraColonne(board.Colonne[1].CodiceIdentificativo, false, false);
                Assert.AreEqual(task, board.Colonne[1].getTask(task.CodiceIdentificativo));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void SpostaTaskInDaRivedereTest()
        {
            try
            {
                Board board = new Board("maracaibo");
                board.creaColonna("dsa", true);
                MoiraTask task = new MoiraTask("das", "da");
                board.setTaskCorrente(task);
                board.addTaskColonna(board.Colonne[1].CodiceIdentificativo);
                board.SelezionaTask(task.CodiceIdentificativo, board.Colonne[1].CodiceIdentificativo);
                board.SpostaTaskInDaRivedere(board.Colonne[1].CodiceIdentificativo);
                Assert.IsTrue(board.Colonne[1].getTasks().Item2.Count() == 1);
            }
            catch
            {
                Assert.Fail();
            }
            
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void EliminaTaskTest()
        {
            Board board = new Board("maracaibo");
            MoiraTask task = new MoiraTask("das", "da");
            board.setTaskCorrente(task);
            board.addTaskColonna("0"); //colonna cestinato
            board.EliminaTask(task);
            board.Colonne[0].getTask(task.CodiceIdentificativo);
        }
    }
}
