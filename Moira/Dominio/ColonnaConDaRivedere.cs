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

            Panel panelColonna = null;

            //ottengo l'ultimo task
            int posY = 0;
            foreach (Control control in panel.Controls)
            {
                Colonna colonna = (Colonna)control.Tag;
                if (ContieneCodiceIdentificativo(colonna.CodiceIdentificativo))
                {
                    posY = control.Controls[control.Controls.Count - 1].Location.Y + 100;
                    panelColonna = (Panel)control;
                }
            }
            if (panelColonna == null)
                return;

            Label label = new Label()
            {
                Text = "Sezione da rivedere",
                Location = new Point(10, posY),
                Width = 180,
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelColonna.Controls.Add(label);

            foreach (MoiraTask task in tasksDaRivedere)
            {
                task.Draw(panelColonna, posY);
                posY += 100;
            }
        }

        public void removeTaskDaRivedere(MoiraTask task) => tasksDaRivedere.Remove(task);

        public void addTaskDaRivedere(MoiraTask task) => tasksDaRivedere.Add(task);

    }
}
