using Moira.Dominio;
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
    public partial class AssociaTeamAProgetto : Form
    {
        private ProgettoHandler controller;

        public AssociaTeamAProgetto(ProgettoHandler controller)
        {
            InitializeComponent();
            this.controller = controller;

            dataGridViewTeam.DataSource = controller.GetTeams();
        }

        private void buttonAggiungiTeam_Click(object sender, EventArgs e)
        {
            string codiceUnivoco = textBoxCodiceTeam.Text;

            if (string.IsNullOrEmpty(codiceUnivoco))
            {
                MessageBox.Show("Inserire un codice univoco valido", "Attenzione");
                return;
            }

            try
            {
                controller.AssociaTeamAProgetto(codiceUnivoco);
                textBoxCodiceTeam.Text = "";
                buttonFineTeam.Enabled = true;
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Il team con codice univoco " + codiceUnivoco + " non è presente nel sistema", "Attenzione");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Attenzione");
            }
        }

        private void buttonFineTeam_Click(object sender, EventArgs e)
        {
            new AssociaClienteANuovoProgetto(controller).Show();
            Dispose();
        }
    }
}
