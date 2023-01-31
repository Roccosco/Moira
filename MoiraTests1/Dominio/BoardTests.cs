using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moira.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace MoiraTests1.Dominio
{
    [TestClass()]
    public class BoardTests{
        static MoiraClass m;
        [ClassInitialize]
        public static void AssemblyInit(TestContext context)
        {
            m = MoiraClass.Instance;
        }

        [TestMethod()]
        public void creaColonnaTest()
        {

        }
    }
}
