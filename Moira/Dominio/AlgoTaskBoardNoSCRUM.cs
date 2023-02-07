using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public class AlgoTaskBoardNoSCRUM : AlgoritmoTaskBoard
    {
        public MoiraTask getTask(string codiceIdentificativo, Team team) => team.getTaskProgetto(codiceIdentificativo);

        public List<MoiraTask> getTuttiTaskAggiungibili(Team team) => team.getTasksProgetto();
    }
}
