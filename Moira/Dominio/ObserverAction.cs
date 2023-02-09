using Moira.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public class ObserverAction : Observer
    {
        private Action funzione;
        public ObserverAction(Action funzione)
        {
            this.funzione = funzione;
        }
        public void update()
        {
            funzione.Invoke();
        }
    }
}
