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
    public partial class GestisciTeamForm : Form
    {
        private TeamHandler controller;
        public GestisciTeamForm()
        {
            InitializeComponent();
            controller = new TeamHandler();
            dataGridViewTeams.DataSource = controller.GetTeams();   
            dataGridViewImpiegati.DataSource = controller.GetImpiegati();   
        }

        private void buttonInserisci_Click(object sender, EventArgs e)
        {
            string nome = textBoxTeam.Text;

            if(string.IsNullOrEmpty(nome) ) 
            {
                MessageBox.Show("Inserire il nome del team!");
                return;
            }

            controller.CreaTeam(nome);
            buttonAggiungi.Enabled = true;
            buttonInserisci.Enabled = false;
            buttonModifica.Enabled = false;
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {            
            string codiceUnivoco = textBoxCodiceUnivoco.Text;
            

            try
            {
                controller.AggiungiImpiegatoATeam(codiceUnivoco);

                MessageBox.Show("L'impiegato è stato aggiunto correttamente");

                buttonConferma.Enabled = true;
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("L'impiegato con il codice univoco: " + codiceUnivoco + " non è presente nel Sistema!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonModifica_Click(object sender, EventArgs e)
        {
            string codiceUnivoco = textBoxModifica.Text;
            try
            {
                controller.SelezionaTeamCorrente(codiceUnivoco);
                new ModificaTeam(controller).Show();
            }
            catch(KeyNotFoundException ex)
            {
                MessageBox.Show("Il team con il codice univoco: " + codiceUnivoco + " non è presente nel Sistema!");
            }
        }

        private void buttonEliminaTeam_Click(object sender, EventArgs e)
        {
            string codiceUnivoco = textBoxEliminaTeam.Text;
            

            try
            {
                controller.EliminaTeam(codiceUnivoco);

                MessageBox.Show("Il team è stato eliminato correttamente");
                Dispose();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("Il team con il codice univoco: " + codiceUnivoco + " non è presente nel Sistema!");
            }
        }

        private void buttonConferma_Click(object sender, EventArgs e)
        {
            try
            {
                controller.ConfermaCreaTeam();

                MessageBox.Show("Team creato correttamente");
                Dispose();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("Il team è già presente nel Sistema!");
            }
        }

    }
}