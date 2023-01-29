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
        private HashSet<Task> tasks;

        public ColonnaBase(string nome)
        {
            this.nome = nome;
            tasks = new HashSet<Task>();
        }

        public string getNome() => nome;

        public Tuple<List<Task>, List<Task>> getTask() => new Tuple<List<Task>, List<Task>>(tasks.ToList(), new List<Task>());

    }
}
