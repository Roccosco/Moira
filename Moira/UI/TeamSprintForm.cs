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
    public partial class TeamSprintForm : Form
    {

        private TeamHandler controller;

        public TeamSprintForm()
        {
            InitializeComponent();
            controller = new TeamHandler();
            dataGridViewTeams.DataSource = controller.GetTeams();   
        }

        private void buttonNuovoSprint_Click(object sender, EventArgs e)
        {
            string codiceTeam = textBoxTeam.Text;

            if (string.IsNullOrEmpty(codiceTeam))
            {
                MessageBox.Show("Inserire un codice di un team!");
                return;
            }

            try
            {
                controller.AvviaNuovoSprint(codiceTeam);

                new AggiungiTaskASprint(controller).Show();
            }
            catch(KeyNotFoundException ex)
            {
                MessageBox.Show("Non è presente alcun team con il codice: " + codiceTeam + " nel Sistema!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTerminaSprint_Click(object sender, EventArgs e)
        {
            string codiceTeam = textBoxTeam.Text;

            if (string.IsNullOrEmpty(codiceTeam))
            {
                MessageBox.Show("Inserire un codice di un team!");
                return;
            }

            try
            {
                controller.SelezionaSprintAttivo(codiceTeam);

                DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler terminare il task attualmente attivo? ", "Attenzione", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    controller.ConfermaTerminaSprint();
                    MessageBox.Show("Sprint arrestato!");
                }
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("Non è presente alcun team con il codice: " + codiceTeam + " nel Sistema!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
