using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public abstract class ColonnaDecoratore : Colonna
    {
        private Colonna decorato;
        
        public ColonnaDecoratore(Colonna decorato)
        {
            this.decorato = decorato;
        }

        public override bool ContieneCodiceIdentificativo(string codiceIdentificativo)
        {
            if (CodiceIdentificativo == codiceIdentificativo)
                return true;

            return decorato.ContieneCodiceIdentificativo(codiceIdentificativo);
        }

        public override string getNome() => decorato.getNome();

        public override Tuple<List<MoiraTask>, List<MoiraTask>> getTask() => decorato.getTask();

        public override int getNumTasks() => decorato.getNumTasks();

        public override void addTask(MoiraTask task) => decorato.addTask(task);

        public override void Draw(Panel panel, int x) => decorato.Draw(panel, x);

    }
}
