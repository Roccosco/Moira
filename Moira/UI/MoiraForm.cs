using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moira.UI
{
    public partial class MoiraForm : Form
    {
        public MoiraForm()
        {
            InitializeComponent();
        }

        private void buttonInserisciProgetti_Click(object sender, EventArgs e)
        {
            new InserisciNuovoProgetto().Show();
        }

        private void buttonGestisciBacklog_Click(object sender, EventArgs e)
        {
            new SelezionaProgetto(new InserisciNuovaUserStory()).Show();
        }

        private void buttonGestisciClienti_Click(object sender, EventArgs e)
        {
            new GestisciClienteForm().Show();
        }
    }
}
