using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public class Board
    {
        private string codiceUnivoco;
        private string nome;
        private static int codiceProgressivo = 0;
        private List<Colonna> colonne;

        public Board(string nome)
        {
            codiceUnivoco = (codiceProgressivo++).ToString();
            this.nome = nome;

            colonne = new List<Colonna>();
            colonne.Add(new ColonnaBase("Cestinato"));
        }

        public void creaColonna(string nome, bool daRivedere)
        {
            ColonnaBase colonnaBase = new ColonnaBase(nome);

            if (daRivedere)
            {
                ColonnaConDaRivedere colonnaConDaRivedere = new ColonnaConDaRivedere(colonnaBase);
                colonne.Add(colonnaConDaRivedere);
            }
            else
                colonne.Add(colonnaBase);
        }
    }
}
