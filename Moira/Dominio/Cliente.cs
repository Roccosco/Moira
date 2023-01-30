namespace Moira.Dominio
{
    //aggiungo giusto due cose per non avere la classe vuota
    public class Cliente : Persona
    {
        private string partitaIVA;

        public Cliente(string nome, string cognome) : base(nome, cognome, "", "", "")
        {
        }

        public Cliente(string nome, string cognome, string email, string partitaIVA, string numeroTelefono, string indirizzo) : base(nome, cognome, email, numeroTelefono, indirizzo)
        {
            this.partitaIVA = partitaIVA;
        }

        public string PartitaIVA
        {
            get => partitaIVA;
            set => partitaIVA = value;
        }
    }
}