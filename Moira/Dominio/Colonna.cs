using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public interface Colonna
    {
        public Tuple<List<Task>, List<Task>> getTask();
        public string getNome();
    }
}
