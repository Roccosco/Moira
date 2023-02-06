using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public interface Subject
    {
        public void Register(Observer observer);
        public void Remove(Observer observer);
        public void Notify();

    }
}
