using Moira.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.UI
{
    public class BoardUI
    {
        Board board;

        public BoardUI(Board board)
        {
            this.board = board;
        }

        public void Draw(Panel panel)
        {
            panel.Controls.Clear();

            int x = 0;
            foreach (Colonna colonna in board.Colonne)
            {
                colonna.Draw(panel, x);
                x += 200;
            }
        }
    }
}
