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
            dataGridViewClienti.DataSource = controller.GetClienti();
        }

        private void buttonInserisci_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string cognome = textBoxCognome.Text;
            string email = textBoxEmail.Text;
            string partitaIVA = textBoxPartitaIva.Text;
            string numeroTelefono = textBoxTelefono.Text;
            string indirizzo = textBoxIndirizzo.Text;

            //check campi vuoti
            if(string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cognome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(numeroTelefono) || string.IsNullOrEmpty(indirizzo))
            {
                MessageBox.Show("Alcuni campi obbligatori sono vuoti!");
                return;
            }

            controller.CreaCliente(nome, cognome, email, partitaIVA, numeroTelefono, indirizzo);
            
            //aprire form per associare il cliente a un progetto
            new AssociaClienteAProgetto(controller).Show();   
        }

        private void buttonTrova_Click(object sender, EventArgs e)
        {
            string codiceUnivoco = textBoxCodiceUnivoco.Text;
            try
            {
                controller.SelezionaClienteCorrente(codiceUnivoco);
                textBoxNome.Enabled = false;
                textBoxCognome.Enabled = false;
                textBoxNome.Text = controller.ClienteCorrente.Nome;
                textBoxCognome.Text = controller.ClienteCorrente.Cognome;
                textBoxEmail.Text = controller.ClienteCorrente.Email;
                textBoxPartitaIva.Text = controller.ClienteCorrente.PartitaIVA;
                textBoxTelefono.Text = controller.ClienteCorrente.Telefono;
                textBoxIndirizzo.Text = controller.ClienteCorrente.Indirizzo;

                buttonModifica.Enabled = true;
                buttonElimina.Enabled = true;
                buttonInserisci.Enabled = false;
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
            new ModificaClienteForm(controller).Show();

        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            string codiceUnivoco = textBoxCodiceUnivoco.Text;
            controller.EliminaCliente(codiceUnivoco);
        }

        
    }
}
