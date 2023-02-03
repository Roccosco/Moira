using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public class ColonnaConLimite : ColonnaDecoratore
    {

        private int limiteTask;

        public int LimiteTask
        {
            get => limiteTask;
            set => limiteTask = value;
        }

        public ColonnaConLimite(Colonna decorato, int limiteTask) : base(decorato)
        {
            this.limiteTask = limiteTask;
        }

        public override void addTask(MoiraTask task)
        {
            if (getNumTasks() < limiteTask)
                base.addTask(task);
            else
                throw new Exception("La colonna ha raggiunto il numero massimo di task: " + limiteTask);
        }

    }
}
