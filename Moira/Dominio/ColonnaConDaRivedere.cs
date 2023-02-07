using Moira.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Moira.Dominio
{
    public class ColonnaConDaRivedere : ColonnaDecoratore
    {
        private HashSet<MoiraTask> tasksDaRivedere;

        public ColonnaConDaRivedere(Colonna decorato) : base(decorato)
        {
            tasksDaRivedere = new HashSet<MoiraTask>();
        }

        public override Tuple<List<MoiraTask>, List<MoiraTask>> getTasks()
        {
            Tuple<List<MoiraTask>, List<MoiraTask>> tupla = base.getTasks();
            tupla.Item2.AddRange(tasksDaRivedere);
            return tupla;
        }

        public override MoiraTask getTask(string codiceTask)
        {
            MoiraTask task = tasksDaRivedere.Where(x => x.CodiceIdentificativo == codiceTask).FirstOrDefault();
            if (task == null)
                return base.getTask(codiceTask);
            return task;
        }

        public override int getNumTasks() => tasksDaRivedere.Count + base.getNumTasks();

        public override void Draw(Panel panel, int x)
        {
            base.Draw(panel, x);

            new ColonnaConDaRivedereUI(this).Draw(panel, x);
        }

        public void removeTaskDaRivedere(MoiraTask task) => tasksDaRivedere.Remove(task);

        public void addTaskDaRivedere(MoiraTask task) => tasksDaRivedere.Add(task);

    }
}
