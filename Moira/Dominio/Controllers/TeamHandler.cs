using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio.Controllers
{
    public class TeamHandler
    {
        private MoiraClass moira;
        private Team teamCorrente;

        public TeamHandler()
        {
            moira = MoiraClass.Instance;
        }

        public void CreaBoard(string nome, string codiceTeam)
        {
            try
            {
                teamCorrente = moira.getTeam(codiceTeam);
                teamCorrente.creaBoard(nome);
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }

        public void CreaColonna(string nome, bool daRivedere) => teamCorrente.creaColonna(nome, daRivedere);

        public void ConfermaCreaBoard()
        {
            try
            {
                teamCorrente.confermaCreaBoard();
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }
    }
}
