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


    }
}