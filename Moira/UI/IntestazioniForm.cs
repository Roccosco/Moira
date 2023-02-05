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
            int limiteTask = 0;
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Nessun campo deve essere vuoto!");
                return;
            }

            if (checkBoxLimitata.Checked)
            {
                if (!int.TryParse(textBoxLimiteTask.Text, out limiteTask) || limiteTask <= 0)
                {
                    MessageBox.Show("Il limite deve essere un numero valido");
                    return;
                }

                controller.CreaColonna(nome, daRivedere, limiteTask);
            }
            else
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxLimitata_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLimitata.Checked)
            {
                textBoxLimiteTask.Visible = true;
                labelLimite.Visible = true;
            }
            else
            {
                textBoxLimiteTask.Visible = false;
                labelLimite.Visible = false;
            }
        }
    }
}
