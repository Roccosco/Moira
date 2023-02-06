using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public class ObserverBoard : Observer
    {
        private Board board;
        private Panel panelBoard;

        public ObserverBoard(Panel panelBoard)
        {
            this.panelBoard = panelBoard;
        }

        public void update()
        {
            board.Draw(panelBoard);
        }
    }
}
