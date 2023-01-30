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
    public partial class ModificaTeam : Form
    {
        private TeamHandler controller;

        public ModificaTeam()
        {
            InitializeComponent();
            controller = new TeamHandler();
        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            string codiceUnivoco = textBoxElimina.Text;
            
            try
            {
                controller.RimuoviImpiegatoDaTeam(codiceUnivoco);

                MessageBox.Show("l'impiegato è stato eliminato correttamente");
                Dispose();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("l'impiegato con il codice univoco: " + codiceUnivoco + " non è presente nel Sistema!");
            }
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            string codiceUnivoco = textBoxAggiungi.Text;
           
            try
            {
                controller.AggiungiImpiegatoATeam(codiceUnivoco);

                MessageBox.Show("l'impiegato è stato aggiunto correttamente");
                Dispose();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("l'impiegato con il codice univoco: " + codiceUnivoco + " non è presente nel Sistema!");
            }
        }
    }
}
