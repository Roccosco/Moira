using Moira.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public class ObserverBoard : Observer
    {
        private BoardForm boardForm;
        public ObserverBoard(BoardForm boardForm)
        {
            this.boardForm = boardForm;
        }
        public void update()
        {
            boardForm.DrawBoard();
        }
    }
}
