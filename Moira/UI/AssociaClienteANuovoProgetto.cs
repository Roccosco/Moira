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
    public partial class AssociaClienteANuovoProgetto : Form
    {
        private ProgettoHandler controller;

        public AssociaClienteANuovoProgetto(ProgettoHandler controller)
        {
            InitializeComponent();
            this.controller = controller;
            dataGridViewCliente.DataSource = controller.GetClienti();
        }



        private void buttonFineClienti_Click(object sender, EventArgs e)
        {
            controller.ConfermaInserimentoProgetto();

            MessageBox.Show("Progetto inserito con successo!", "Successo");

            Dispose();
        }

        private void buttonAggiungiCliente_Click(object sender, EventArgs e)
        {
            string codiceUnivoco = textBoxCodiceCliente.Text;

            if (string.IsNullOrEmpty(codiceUnivoco))
            {
                MessageBox.Show("Inserire un codice univoco valido", "Attenzione");
                return;
            }

            try
            {
                controller.AssociaClienteAProgetto(codiceUnivoco);
                textBoxCodiceCliente.Text = "";
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Il cliente con codice univoco " + codiceUnivoco + " non è presente nel sistema", "Attenzione");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
