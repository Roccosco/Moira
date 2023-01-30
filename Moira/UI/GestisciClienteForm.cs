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
            controller.ConfermaCreaCliente();
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
                textBoxPartitaIva.Text = controller.ClienteCorrente.PartitaIVA;
                textBoxTelefono.Text = controller.ClienteCorrente.Telefono;
                textBoxIndirizzo.Text = controller.ClienteCorrente.Indirizzo;
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
            string partitaIVA = textBoxPartitaIva.Text;
            string telefono = textBoxTelefono.Text;
            string indirizzo = textBoxIndirizzo.Text;

            controller.ResetInfoCliente(email, partitaIVA, telefono, indirizzo);

            //apro la form con Disassocia/Associa a progetto
            new ModificaClienteForm().Show();

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

        private void GestisciClienteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
