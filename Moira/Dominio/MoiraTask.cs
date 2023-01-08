namespace Moira.Dominio
{
    public class MoiraTask
    {
        private string nome;
        private string descrizione;
        private string codiceIdentificativo;

        private static int codiceProgressivo = 0;

        public MoiraTask(string nome, string descrizione) 
        {
            this.nome = nome;
            this.descrizione = descrizione;
            codiceIdentificativo = (codiceProgressivo++).ToString();

        }

        public string CodiceIdentificativo
        {
            get
            {
                return codiceIdentificativo;
            }
        }
    }
}