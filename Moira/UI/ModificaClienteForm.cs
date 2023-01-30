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
    public partial class ModificaClienteForm : Form
    {
        private ClienteHandler controller;
        public ModificaClienteForm(ClienteHandler controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void buttonAssocia_Click(object sender, EventArgs e)
        {
            string progetto = textBoxProgetto.Text;

            try
            {
                controller.AssociaClienteAProgetto(progetto);

                MessageBox.Show("Il cliente è stato associato al progetto");
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("Il cliente non è stato associato al progetto");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDissocia_Click(object sender, EventArgs e)
        {
            string progetto = textBoxProgetto.Text;
            try
            {
                controller.DisassociaClienteAProgetto(progetto);

                MessageBox.Show("Il cliente è stato dissociato al progetto");
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("Il cliente non è stato dissociato al progetto");
            }
        }

        private void buttonTermina_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
