using Moira.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.UI
{
    public class TaskUI
    {
        MoiraTask task;

        public TaskUI(MoiraTask task)
        {
            this.task = task;
        }

        public void Draw(Panel panelColonna, int y)
        {
            Panel panelTask = new Panel()
            {
                Location = new Point(10, y),
                Width = 180,
                Height = 100,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = task
            };
            panelColonna.Controls.Add(panelTask);

            Label labelNome = new Label()
            {
                Text = task.Nome,
                Location = new Point(10, 10),
                Width = 160,
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelTask.Controls.Add(labelNome);
            Label labelDescrizione = new Label()
            {
                Text = task.Descrizione,
                Location = new Point(10, 50),
                Width = 160,
                TextAlign = ContentAlignment.TopLeft
            };
            panelTask.Controls.Add(labelDescrizione);
        }
    }
}
