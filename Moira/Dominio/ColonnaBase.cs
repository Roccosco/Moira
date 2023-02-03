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

        public override int getNumTasks() => tasks.Count;

        public override string getNome() => nome;

        public override Tuple<List<MoiraTask>, List<MoiraTask>> getTask() => new Tuple<List<MoiraTask>, List<MoiraTask>>(tasks.ToList(), new List<MoiraTask>());

        public override void addTask(MoiraTask task) => tasks.Add(task);

    }
}
