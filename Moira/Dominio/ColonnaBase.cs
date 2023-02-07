using Moira.UI;
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

        public override Tuple<List<MoiraTask>, List<MoiraTask>> getTasks() => new Tuple<List<MoiraTask>, List<MoiraTask>>(tasks.ToList(), new List<MoiraTask>());

        public override MoiraTask getTask(string codiceTask)
        {
            MoiraTask task = tasks.Where(x => x.CodiceIdentificativo == codiceTask).FirstOrDefault();

            if (task == null)
                throw new Exception("Impossibile trovare il task nella colonna");

            return task;
        }

        public override void addTask(MoiraTask task) => tasks.Add(task);

        public override void Draw(Panel panel, int x)
        {
            new ColonnaBaseUI(this).Draw(panel, x);
        }

        public override void removeTask(MoiraTask task)
        {
            tasks.Remove(task);
        }
    }
}
