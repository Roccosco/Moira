using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public class ColonnaConDaRivedere : ColonnaDecoratore
    {
        private HashSet<Task> tasksDaRivedere;

        public ColonnaConDaRivedere(Colonna decorato) : base(decorato)
        {
            tasksDaRivedere = new HashSet<Task>();
        }

        public override Tuple<List<Task>, List<Task>> getTask()
        {
            Tuple<List<Task>, List<Task>> tupla = base.getTask();
            tupla.Item2.AddRange(tasksDaRivedere);
            return tupla;
        }
    }
}
