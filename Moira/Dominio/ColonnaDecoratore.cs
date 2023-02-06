using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

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

        public override Tuple<List<MoiraTask>, List<MoiraTask>> getTasks() => decorato.getTasks();

        public override MoiraTask getTask(string codiceTask) => decorato.getTask(codiceTask);

        public override int getNumTasks() => decorato.getNumTasks();

        public override void addTask(MoiraTask task) => decorato.addTask(task);

        public override void Draw(Panel panel, int x) => decorato.Draw(panel, x);

        public override void removeTask(MoiraTask task) => decorato.removeTask(task);

    }
}
