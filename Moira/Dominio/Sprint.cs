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
        private Dictionary<MoiraTask, int> taskStoryPoints;

        private DateTime dataAvvio;
        private DateTime dataFine;

        public Sprint()
        {
            taskImpiegati = new Dictionary<MoiraTask, Impiegato>();
            taskStoryPoints = new Dictionary<MoiraTask, int>();
            dataAvvio = DateTime.Now;
        }

        public void aggiungiTask(MoiraTask task, int storyPoints)
        {
            taskStoryPoints.Add(task, storyPoints);
            lastTask = task;
        }

        public void AssociaTaskAImpiegato(Impiegato impiegato)
        {
            taskImpiegati.Add(lastTask, impiegato);
        }

        public MoiraTask getTask(string codiceTask)
        {
            foreach (MoiraTask task in taskStoryPoints.Keys)
                if (task.CodiceIdentificativo == codiceTask)
                    return task;

            throw new Exception("Task non presente nello sprint backlog!");
        }
    }
}
