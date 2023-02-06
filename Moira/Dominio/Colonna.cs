using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public abstract class Colonna
    {
        private string codiceIdentificativo;
        private static int codiceProgressivo = 0;

        public Colonna()
        {
            codiceIdentificativo = (codiceProgressivo++).ToString();
        }

        public string CodiceIdentificativo
        {
            get => codiceIdentificativo;
        }

        public abstract bool ContieneCodiceIdentificativo(string codiceIdentificativo);

        public abstract Tuple<List<MoiraTask>, List<MoiraTask>> getTasks();

        public abstract MoiraTask getTask(string codiceTask);

        public abstract string getNome();
        public abstract int getNumTasks();
        public abstract void addTask(MoiraTask task);

        public abstract void Draw(Panel panel, int x);

        public abstract void removeTask(MoiraTask task);

    }
}
