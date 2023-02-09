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

            dataGridViewTask.DataSource = controller.GetTaskPerSprint();
            dataGridViewTeamImpiegati.DataSource = controller.GetImpiegatiTeam();
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

            try
            {
                controller.AggiungiTaskASprint(codiceTask, storyPoints);
                MessageBox.Show("Task aggiunto");

                buttonAddTask.Enabled = false;
                textBoxTask.Enabled = false;
                buttonTermina.Enabled = false;
                buttonImpiegato.Enabled = true;
                textBoxImpiegato.Enabled = true;
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Codice task non valido");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Il task con codice: " + codiceTask + " è stato già inserito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonImpiegato_Click(object sender, EventArgs e)
        {
            string codiceImpiegato = textBoxImpiegato.Text;
            if (string.IsNullOrEmpty(codiceImpiegato))
            {
                MessageBox.Show("Controlla i dati inseriti");
                return;
            }

            try
            {
                controller.AssociaTaskSprintAImpiegato(codiceImpiegato);
                MessageBox.Show("Impiegato associato");

                buttonTermina.Enabled = true;
                buttonAddTask.Enabled = true;
                textBoxTask.Enabled = true;
                buttonImpiegato.Enabled = false;
                textBoxImpiegato.Enabled = false;
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Codice impiegato non valido");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTermina_Click(object sender, EventArgs e)
        {
            controller.ConfermaAvvioSprint();
            Dispose();
        }
    }
}
