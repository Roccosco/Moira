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
    public partial class AggiungiTaskASprint : Form
    {
        private TeamHandler controller; 

        public AggiungiTaskASprint(TeamHandler controller)
        {
            this.controller = controller;

            InitializeComponent();
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            string codiceTask = textBoxTask.Text;
            int storyPoints;
            if(!int.TryParse(textBoxStoryPoints.Text, out storyPoints) || string.IsNullOrEmpty(codiceTask))
            {
                MessageBox.Show("Controlla i dati inseriti");
                return;
            }

            MessageBox.Show("Task aggiunto");

            controller.AggiungiTaskASprint(codiceTask, storyPoints);

            buttonAddTask.Enabled = false;
            textBoxTask.Enabled = false;
            buttonImpiegato.Enabled = true;
            textBoxImpiegato.Enabled = true;
        }

        private void buttonImpiegato_Click(object sender, EventArgs e)
        {
            string codiceImpiegato = textBoxImpiegato.Text;
            if (string.IsNullOrEmpty(codiceImpiegato))
            {
                MessageBox.Show("Controlla i dati inseriti");
                return;
            }

            MessageBox.Show("Impiegato associato");

            controller.AssociaTaskSprintAImpiegato(codiceImpiegato);

            buttonTermina.Enabled = true;
            buttonAddTask.Enabled = true;
            textBoxTask.Enabled = true;
            buttonImpiegato.Enabled = false;
            textBoxImpiegato.Enabled = false;
        }

        private void buttonTermina_Click(object sender, EventArgs e)
        {
            controller.ConfermaAvvioSprint();
            Dispose();
        }
    }
}
