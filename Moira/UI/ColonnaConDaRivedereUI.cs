using Moira.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.UI
{
    public class ColonnaConDaRivedereUI
    {
        ColonnaConDaRivedere colonnaConDaRivedere;

        public ColonnaConDaRivedereUI(ColonnaConDaRivedere colonnaConDaRivedere)
        {
            this.colonnaConDaRivedere = colonnaConDaRivedere;
        }

        public void Draw(Panel panel, int x)
        {
            Panel panelColonna = null;

            //ottengo l'ultimo task
            int posY = 0;
            foreach (Control control in panel.Controls)
            {
                Colonna colonna = (Colonna)control.Tag;
                if (colonnaConDaRivedere.ContieneCodiceIdentificativo(colonna.CodiceIdentificativo))
                {
                    posY = control.Controls[control.Controls.Count - 1].Location.Y + 110;
                    panelColonna = (Panel)control;
                }
            }
            if (panelColonna == null)
                return;

            panelColonna.Height = posY;

            Panel panelDaRivedere = new Panel()
            {
                Location = new Point(panelColonna.Location.X, posY),
                Width = 200,
                Height = panel.Height - posY - 10,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = colonnaConDaRivedere
            };
            panel.Controls.Add(panelDaRivedere);

            Label label = new Label()
            {
                Text = "Sezione da rivedere",
                Location = new Point(10, 10),
                Width = 180,
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelDaRivedere.Controls.Add(label);

            int y = 50;
            foreach (MoiraTask task in colonnaConDaRivedere.getTasks().Item2)
            {
                task.Draw(panelDaRivedere, y);
                y += 100;
            }
        }
    }
}
