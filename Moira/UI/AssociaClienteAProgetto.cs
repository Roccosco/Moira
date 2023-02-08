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
    public partial class AssociaClienteAProgetto : Form
    {
        private ClienteHandler controller;

        public AssociaClienteAProgetto(ClienteHandler controller)
        {
            InitializeComponent();
            this.controller = controller;
            dataGridViewProgetti.DataSource = controller.GetProgetti();
        }

        private void buttonAssocia_Click(object sender, EventArgs e)
        {
            string nome = textBoxAssocia.Text; 
            
            try
            {
                controller.AssociaClienteAProgetto(nome);

                MessageBox.Show("Il cliente è stato stato associato al progetto");
                textBoxAssocia.Text = "";

            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("Il cliente non può essere associato al progetto: " + nome + " perchè non esiste un progetto con quel nome!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTermina_Click(object sender, EventArgs e)
        {
            controller.ConfermaCreaCliente();
            Dispose();
        }
    }
}
