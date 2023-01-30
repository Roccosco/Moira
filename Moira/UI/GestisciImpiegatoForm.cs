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
            controller.ConfermaCreaImpiegato();
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
    }
}
