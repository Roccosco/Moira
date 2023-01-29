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

        public string getNome() => decorato.getNome();

        public virtual Tuple<List<Task>, List<Task>> getTask() => decorato.getTask();

    }
}
