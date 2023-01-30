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
    public partial class InserisciNuovoTask : Form
    {
        private ProgettoHandler controller;

        public InserisciNuovoTask()
        {
            controller = new ProgettoHandler();
            InitializeComponent();
        }

        private void buttonAvanti_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string descrizione = textBoxDescrizione.Text;

            //controlli
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(descrizione))
            {
                MessageBox.Show("Il nome o la descrizione non possono essere vuoti!", "Attenzione");
                return;
            }
            //controllare che non ci sia già un progetto con lo stesso nome

            controller.InserisciNuovoTask(nome, descrizione);

            MessageBox.Show("Task aggiunto con successo!", "Successo");
            Dispose();
        }
    }
}
