using Moira.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.UI
{
    public class BacklogUI
    {
        private List<UserStory> backlog;

        public BacklogUI(List<UserStory> backlog)
        {
            this.backlog = backlog;
        }

        public void Draw(Panel panelBacklog)
        {
            panelBacklog.Controls.Clear();

            int y = 10;
            int pos = 0;
            foreach (UserStory uS in backlog)
            {
                y += uS.Draw(panelBacklog, y, pos);
                pos++;
            }
        }

    }
}
