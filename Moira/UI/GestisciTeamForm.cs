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
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {            
            string codiceUnivoco = textBoxCodiceUnivoco.Text;
            

            try
            {
                controller.AggiungiImpiegatoATeam(codiceUnivoco);

                MessageBox.Show("l'impiegato è stato aggiunto correttamente");

                buttonConferma.Enabled = true;
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("l'impiegato con il codice univoco: " + codiceUnivoco + " non è presente nel Sistema!");
            }
        }


        private void buttonModifica_Click(object sender, EventArgs e)
        {
            new ModificaTeam().Show();
        }

        private void buttonEliminaTeam_Click(object sender, EventArgs e)
        {
            string codiceUnivoco = textBoxEliminaTeam.Text;
            

            try
            {
                controller.EliminaTeam(codiceUnivoco);

                MessageBox.Show("il team è stato eliminato correttamente");
                Dispose();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("il team con il codice univoco: " + codiceUnivoco + " non è presente nel Sistema!");
            }
        }

        private void buttonConferma_Click(object sender, EventArgs e)
        {
            

            try
            {
                controller.ConfermaCreaTeam();

                MessageBox.Show(" team creato correttamente");
                Dispose();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("il team è già presente nel Sistema!");
            }
        }
    }
}