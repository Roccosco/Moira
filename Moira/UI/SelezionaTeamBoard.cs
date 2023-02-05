using Moira.Dominio.Controllers;
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
    public partial class SelezionaTeamBoard : Form
    {
        private TeamHandler controller;
        public SelezionaTeamBoard()
        {
            InitializeComponent();
            controller = new TeamHandler();
        }

        private void buttonAvanti_Click(object sender, EventArgs e)
        {
            string codiceTeam = textBoxCodice.Text;

            if (string.IsNullOrEmpty(codiceTeam))
            {
                MessageBox.Show("codice non valido");
                return;
            }

            try
            {
                controller.SelezionaTeamBoard(codiceTeam);

                new BoardForm(controller).Show();
            }
            catch(KeyNotFoundException)
            {
                MessageBox.Show("Non è stato trovato alcun team con il codice corrispondente");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
