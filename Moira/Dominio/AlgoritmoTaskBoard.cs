using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public interface AlgoritmoTaskBoard
    {
        public MoiraTask getTask(string codiceIdentificativo, Team team);
    }
}
