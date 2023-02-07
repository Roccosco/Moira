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
    public partial class CreaBoard : Form
    {
        private TeamHandler controller;
        public CreaBoard()
        {
            InitializeComponent();
            controller = new TeamHandler();
            dataGridViewTeams.DataSource = controller.GetTeams();   
        }

        private void buttonInserisci_Click(object sender, EventArgs e)
        {
            string nome = textBoxNomeBoard.Text;
            string codice = textBoxTeamBoard.Text;

            if(string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(codice))
            {
                MessageBox.Show("Nessun campo deve essere vuoto!");
                return;
            }

            try
            {
                controller.CreaBoard(nome, codice);
                new IntestazioniForm(controller).Show();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("Il team con il codice: " + codice + " non esiste nel Sistema!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
