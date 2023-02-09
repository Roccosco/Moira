using Moira.UI;

namespace Moira.Dominio
{
    public class UserStory
    {
        private string nome;
        private string descrizione;
        private string codiceIdentificativo;
        private Dictionary<string, MoiraTask> tasks;
        private static int codiceProgressivo = 0;




        public UserStory(string nome, string descrizione)
        {
            this.nome = nome;
            this.descrizione = descrizione;
            codiceIdentificativo = (codiceProgressivo++).ToString();
            tasks = new Dictionary<string, MoiraTask>();

        }

        public string CodiceIdentificativo
        {
            get
            {
                return codiceIdentificativo;
            }
        }

        public string InserisciNuovoTask(string nome, string descrizione)
        {
            MoiraTask tsk = new MoiraTask(nome, descrizione);

            string id = tsk.CodiceIdentificativo;

            tasks.Add(id, tsk);

            return id;
        }

        public MoiraTask getTask(string codiceTask)
        {
            if (tasks.TryGetValue(codiceTask, out MoiraTask task))
                return task;
            else
                return null;
        }

        public List<MoiraTask> getAllTasks() => tasks.Values.ToList();

        public int Draw(Panel panelBacklog, int y, int pos) => new UserStoryUI(this).Draw(panelBacklog, y, pos);

        public string NomeUserStory { get => nome; }

        public string Descrizione { get => descrizione; }
    }
}