using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Moira.Dominio
{
    public class Persona
    {
        private string nome;
        private string cognome;
        private string email;
        private string telefono;
        private string indirizzo;

        private string codiceUnivoco;

        private static int codiceProgressivo = 0;

        public Persona(string nome, string cognome, string email, string telefono, string indirizzo)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.email = email;
            this.telefono = telefono;
            this.indirizzo = indirizzo;

            codiceUnivoco = (codiceProgressivo++).ToString();
        }

        public string CodiceUnivoco
        {
            get => codiceUnivoco;
        }
        public string Nome
        {
            get => nome;
        }
        public string Cognome
        {
            get => cognome;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Telefono
        {
            get => telefono;
            set => telefono = value;
        }
        public string Indirizzo
        {
            get => indirizzo;
            set => indirizzo = value;
        }
    }
}
