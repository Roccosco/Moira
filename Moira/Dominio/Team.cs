namespace Moira.Dominio
{
    public class Team
    {
        private static int codiceProgressivo = 0;

        private string codiceUnivoco;
        private string nome;
        private HashSet<Impiegato> impiegati;
        private Progetto progetto;

        private Board boardCorrente;
        private Board board;

        public Team(string nome)
        {
            codiceUnivoco = (codiceProgressivo++).ToString();
            this.nome = nome;
            impiegati = new HashSet<Impiegato>();
        }

        public string CodiceUnivoco
        {
            get => codiceUnivoco;
        }

        public string Nome
        {
            get => nome;
        }


        public Progetto Progetto
        {
            get => progetto;
            set
            {
                if (isLibero())
                    progetto = value;
                else
                    throw new Exception("Il team lavora già a un progetto");
            }
        }

        public void creaBoard(string nome)
        {
            if (board != null)
                throw new Exception("Il team ha già una board!");

            boardCorrente = new Board(nome);
        }

        public void creaColonna(string nome, bool daRivedere) => boardCorrente.creaColonna(nome, daRivedere);

        public void confermaCreaBoard()
        {
            if (board != null)
                throw new Exception("Il team ha già una board!");

            board = boardCorrente;
        }

        private bool isLibero() => progetto == null;

        public bool addImpiegato(Impiegato impiegato) => impiegati.Add(impiegato);

        public bool removeImpiegato(Impiegato impiegato) => impiegati.Remove(impiegato);

    }
}