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
    public partial class InserisciClienteCerimonia : Form
    {
        private TeamHandler controller;
        public InserisciClienteCerimonia(TeamHandler controller)
        {
            InitializeComponent();
            this.controller = controller;
            dataGridViewClienti.DataSource = controller.GetClienti();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            string codiceUnivoco = textBoxCliente.Text;

            try
            {
                controller.InvitoCerimonia(codiceUnivoco); 

                MessageBox.Show("l'impiegato è stato aggiunto correttamente");

            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("l'impiegato con il codice univoco: " + codiceUnivoco + " non è presente nel Sistema!");
            }
        }

        private void buttonTermina_Click(object sender, EventArgs e)
        {
            controller.ConfermaCreaCerimonia();
            MessageBox.Show("Cerimonia schedulata!");
            Dispose();
        }
    }
}
