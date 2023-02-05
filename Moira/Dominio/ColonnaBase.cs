using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public class ColonnaBase : Colonna
    {
        private string nome;
        private HashSet<MoiraTask> tasks;

        public ColonnaBase(string nome)
        {
            this.nome = nome;
            tasks = new HashSet<MoiraTask>();
        }

        public override bool ContieneCodiceIdentificativo(string codiceIdentificativo) => CodiceIdentificativo == codiceIdentificativo;

        public override int getNumTasks() => tasks.Count;

        public override string getNome() => nome;

        public override Tuple<List<MoiraTask>, List<MoiraTask>> getTask() => new Tuple<List<MoiraTask>, List<MoiraTask>>(tasks.ToList(), new List<MoiraTask>());

        public override void addTask(MoiraTask task) => tasks.Add(task);

        public override void Draw(Panel panel, int x)
        {
            Panel panelColonna = new Panel()
            {
                Location = new Point(x, 0),
                Width = 200,
                Height = panel.Height - 10,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = this
            };
            panel.Controls.Add(panelColonna);

            Label labelNome = new Label()
            {
                Text = nome,
                Location = new Point(10, 10),
                Width = 180,
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelColonna.Controls.Add(labelNome);

            Label labelCodiceIdentificativo = new Label()
            {
                Text = "Codice identificativo: " + CodiceIdentificativo,
                Location = new Point(10, 30),
                Width = 180,
            };
            panelColonna.Controls.Add(labelCodiceIdentificativo);

            int y = 60;
            foreach (MoiraTask task in tasks)
            {
                task.Draw(panelColonna, y);
                y += 100;
            }
        }

    }
}
