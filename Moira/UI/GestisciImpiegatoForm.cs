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
    public partial class GestisciImpiegatoForm : Form
    {
        private TeamHandler controller;

        public GestisciImpiegatoForm()
        {
            InitializeComponent();
            controller = new TeamHandler();
        }

        private void buttonInserisci_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string cognome = textBoxCognome.Text;
            string email = textBoxEmail.Text;
            string numeroTelefono = textBoxTelefono.Text;
            string indirizzo = textBoxIndirizzo.Text;

            //check campi vuoti
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cognome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(numeroTelefono) || string.IsNullOrEmpty(indirizzo))
            {
                MessageBox.Show("Alcuni campi obbligatori sono vuoti!");
                return;
            }

            controller.CreaImpiegato(nome, cognome, email, numeroTelefono, indirizzo);
            //controller.ConfermaCreaImpiegato();
        }



        private void buttonTrova_Click(object sender, EventArgs e)
        {
            string codiceUnivoco = textBoxCodiceUnivoco.Text;
            try
            {
                controller.SelezionaImpiegatoCorrente(codiceUnivoco);
                textBoxNome.Enabled = false;
                textBoxCognome.Enabled = false;
                textBoxEmail.Text = controller.ImpiegatoCorrente.Email;
                textBoxTelefono.Text = controller.ImpiegatoCorrente.Telefono;
                textBoxIndirizzo.Text = controller.ImpiegatoCorrente.Indirizzo;

                buttonModifica.Enabled = true;
                buttonElimina.Enabled = true;
                buttonInserisci.Enabled = false;
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("l'impiegato con il codice univoco: " + codiceUnivoco + " non è presente nel Sistema!");
            }
        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            string codiceUnivoco = textBoxCodiceUnivoco.Text;
            try
            {
                controller.EliminaImpiegato(codiceUnivoco);

                MessageBox.Show("l'impiegato è stato eliminato");
                Dispose();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("l'impiegato con il codice univoco: " + codiceUnivoco + " non è presente nel Sistema!");
            }
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string telefono = textBoxTelefono.Text;
            string indirizzo = textBoxIndirizzo.Text;

            controller.ResetInfoImpiegato(email, telefono, indirizzo);

            new ModificaImpiegato().Show();
        }
    }
}
