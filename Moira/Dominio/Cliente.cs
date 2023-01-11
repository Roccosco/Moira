namespace Moira.Dominio
{
    //aggiungo giusto due cose per non avere la classe vuota
    public class Cliente
    {
        private string nome;
        private string cognome;
        private string codiceUnivoco;
        private static int codiceProgressivo = 0;

        public Cliente(string nome,string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
            codiceUnivoco = (codiceProgressivo++).ToString();
        }

        public string CodiceUnivoco
        {
            get => codiceUnivoco;
        }
    }
}