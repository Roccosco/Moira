using Moira.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moira.UI
{
    public class UserStoryUI
    {
        private UserStory userStory;

        public UserStoryUI(UserStory userStory)
        {
            this.userStory = userStory;
        }

        public int Draw(Panel panelBacklog, int y, int pos)
        {
            Panel panelUS = new Panel()
            {
                Location = new Point(25, y),
                Width = 200,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = new Tuple<UserStory, int>(userStory, pos)
            };
            panelBacklog.Controls.Add(panelUS);

            int height = 0;
            Label labelNome = new Label()
            {
                Text = userStory.NomeUserStory,
                Location = new Point(10, 10),
                Width = 180,
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelUS.Controls.Add(labelNome);
            Label labelDescrizione = new Label()
            {
                Text = userStory.Descrizione,
                Location = new Point(10, 40),
                Width = 180,
                Height = 50,
                TextAlign = ContentAlignment.TopLeft
            };
            panelUS.Controls.Add(labelDescrizione);

            height += 110;

            foreach (MoiraTask task in userStory.getAllTasks())
            {
                task.Draw(panelUS, height);
                height += 100;
            }
            height += 10;

            panelUS.Height = height;

            return height + 5;
        }
    }
}
