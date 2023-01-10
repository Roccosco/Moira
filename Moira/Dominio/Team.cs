namespace Moira.Dominio
{
    public class Team
    {
        private static int codiceProgressivo = 0;

        private string codiceUnivoco;
        private Progetto progetto;

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

        private bool isLibero() => progetto == null;

    }
}