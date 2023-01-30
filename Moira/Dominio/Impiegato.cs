using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public class Impiegato : Persona
    {
        public Impiegato(string nome, string cognome, string email, string telefono, string indirizzo) : base(nome, cognome, email, telefono, indirizzo)
        {
        }
    }
}
