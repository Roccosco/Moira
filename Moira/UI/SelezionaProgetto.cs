using Moira.Dominio;
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
        private MoiraClass moira;

        private Form form;

        public SelezionaProgetto(Form form)
        {
            this.form = form;
            moira = MoiraClass.Instance;
            InitializeComponent();
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
                moira.SelezionaProgetto(nome);
                form.Show();
                Dispose();
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Non esiste alcun progetto con questo nome: " + nome, "Attenzione");
            }


        }
    }
}
