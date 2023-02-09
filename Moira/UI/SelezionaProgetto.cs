using Moira.Dominio;
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
    public partial class SelezionaProgetto : Form
    {
        private ProgettoHandler controller;

        public SelezionaProgetto(ProgettoHandler controller)
        {
            this.controller = controller;
            InitializeComponent();
            dataGridViewProgetti.DataSource = controller.GetProgetti();
        }

        private void buttonAvanti_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Il nome non può essere vuoto", "Attenzione");
                return;
            }

            try
            {
                controller.SelezionaProgetto(nome);
                new InserisciNuovaUserStory(controller).Show();
                Dispose();
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Non esiste alcun progetto con questo nome: " + nome, "Attenzione");
            }


        }
    }
}
