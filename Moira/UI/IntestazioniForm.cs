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
    public partial class IntestazioniForm : Form
    {
        private TeamHandler controller;

        public IntestazioniForm(TeamHandler controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void buttonInserisci_Click(object sender, EventArgs e)
        {
            string nome = textBoxNomeColonna.Text;
            bool daRivedere = checkBoxDaRivedere.Checked;

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Nessun campo deve essere vuoto!");
                return;
            }

            controller.CreaColonna(nome, daRivedere);
            MessageBox.Show("Colonna creata correttamente!");

            buttonTermina.Enabled = true;
        }

        private void buttonTermina_Click(object sender, EventArgs e)
        {
            try
            {
                controller.ConfermaCreaBoard();
                Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
