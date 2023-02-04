using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public class AlgoTaskBoardSCRUM : AlgoritmoTaskBoard
    {
        public MoiraTask getTask(string codiceIdentificativo, Team team)
        {
            if (!team.haSprintAttivo())
                throw new Exception("Non si utilizza attualmente un framework SCRUM");

            return team.SprintAttivo.getTask(codiceIdentificativo);
        }
    }
}
