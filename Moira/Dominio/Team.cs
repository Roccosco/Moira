namespace Moira.Dominio
{
    public class Team
    {
        private Progetto progetto;

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