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
    public partial class GestisciClienteForm : Form
    {
        private ClienteHandler controller;

        public GestisciClienteForm()
        {
            InitializeComponent();
            controller = new ClienteHandler();
        }

        private void buttonInserisci_Click(object sender, EventArgs e)
        {

        }

        private void buttonTrova_Click(object sender, EventArgs e)
        {
            string codiceUnivoco = textBoxCodiceUnivoco.Text;
            try
            {
                controller.SelezionaClienteCorrente(codiceUnivoco);
                textBoxNome.Enabled = false;
                textBoxCognome.Enabled = false;
                textBoxEmail.Text = controller.ClienteCorrente.Email;
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("Il cliente con il codice univoco: " + codiceUnivoco + " non è presente nel Sistema!");
            }
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            //check campi
            string email = textBoxEmail.Text;

            //controller.ResetInfoCliente(email, );
            //apro la form con Disassocia/Associa a progetto

        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            string codiceUnivoco = textBoxCodiceUnivoco.Text;
            try
            {
                controller.EliminaCliente(codiceUnivoco);
                
                MessageBox.Show("Il cliente è stato eliminato");
                Dispose();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("Il cliente con il codice univoco: " + codiceUnivoco + " non è presente nel Sistema!");
            }
        }
    }
}
