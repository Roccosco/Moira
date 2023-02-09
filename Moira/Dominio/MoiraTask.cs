using Moira.UI;

namespace Moira.Dominio
{
    public class MoiraTask
    {
        private string nome;
        private string descrizione;
        private bool completato;
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

        public string Nome { get => nome; set => nome = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }

        public bool Completato { get => completato; set => completato = value; }

        public void Draw(Panel panelColonna, int y)
        {
            new TaskUI(this).Draw(panelColonna, y);
        }
    }
}