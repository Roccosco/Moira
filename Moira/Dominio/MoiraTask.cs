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

        public void Draw(Panel panelColonna, int y)
        {
            Panel panelTask = new Panel()
            {
                Location = new Point(10, y),
                Width = 180,
                Height = 100,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = this
            };
            panelColonna.Controls.Add(panelTask);

            Label labelNome = new Label()
            {
                Text = nome,
                Location = new Point(10, 10)
            };
            panelTask.Controls.Add(labelNome);
            Label labelDescrizione = new Label()
            {
                Text = descrizione,
                Location = new Point(10, 50)
            };
            panelTask.Controls.Add(labelDescrizione);
        }
    }
}