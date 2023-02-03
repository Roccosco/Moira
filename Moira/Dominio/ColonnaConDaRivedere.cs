using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public class ColonnaConDaRivedere : ColonnaDecoratore
    {
        private HashSet<MoiraTask> tasksDaRivedere;

        public ColonnaConDaRivedere(Colonna decorato) : base(decorato)
        {
            tasksDaRivedere = new HashSet<MoiraTask>();
        }

        public override Tuple<List<MoiraTask>, List<MoiraTask>> getTask()
        {
            Tuple<List<MoiraTask>, List<MoiraTask>> tupla = base.getTask();
            tupla.Item2.AddRange(tasksDaRivedere);
            return tupla;
        }

        public override int getNumTasks() => tasksDaRivedere.Count + base.getNumTasks();
    }
}
