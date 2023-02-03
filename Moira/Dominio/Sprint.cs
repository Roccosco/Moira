using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public class Sprint
    {
        private Dictionary<MoiraTask, Impiegato> taskImpiegati;
        private MoiraTask lastTask;
        //con storyPoints
        private Dictionary<MoiraTask, int> taskStoryPoint;

        private DateTime dataAvvio;
        private DateTime dataFine;

        public Sprint()
        {
            taskImpiegati = new Dictionary<MoiraTask, Impiegato>();
            taskStoryPoint = new Dictionary<MoiraTask, int>();
            dataAvvio = DateTime.Now;
        }

        public void aggiungiTask(MoiraTask task, int storyPoints)
        {
            taskStoryPoint.Add(task, storyPoints);
            lastTask = task;
        }

        public void AssociaTaskAImpiegato(Impiegato impiegato)
        {
            taskImpiegati.Add(lastTask, impiegato);
        }
    }
}
