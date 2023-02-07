using Moira.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Moira.UI
{
    public class ColonnaBaseUI
    {
        ColonnaBase colonnaBase;

        public ColonnaBaseUI(ColonnaBase colonnaBase)
        {
            this.colonnaBase = colonnaBase;
        }

        public void Draw(Panel panel, int x)
        {
            Panel panelColonna = new Panel()
            {
                Location = new Point(x, 0),
                Width = 200,
                Height = panel.Height - 10,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = colonnaBase
            };
            panel.Controls.Add(panelColonna);

            Label labelNome = new Label()
            {
                Text = colonnaBase.getNome(),
                Location = new Point(10, 10),
                Width = 180,
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelColonna.Controls.Add(labelNome);

            Label labelCodiceIdentificativo = new Label()
            {
                Text = "Codice identificativo: " + colonnaBase.CodiceIdentificativo,
                Location = new Point(10, 30),
                Width = 180,
            };
            panelColonna.Controls.Add(labelCodiceIdentificativo);

            int y = 60;
            foreach (MoiraTask task in colonnaBase.getTasks().Item1)
            {
                task.Draw(panelColonna, y);
                y += 100;
            }
        }
    }
}
