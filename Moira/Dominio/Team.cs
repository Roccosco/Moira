namespace Moira.Dominio
{
    public class Team
    {
        private static int codiceProgressivo = 0;

        private string codiceUnivoco;
        private Progetto progetto;

        private Board boardCorrente;
        private Board board;

        public Team()
        {
            codiceUnivoco = (codiceProgressivo++).ToString();
        }

        public string CodiceUnivoco
        {
            get => codiceUnivoco;
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

    }
}