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
    public partial class InserisciNuovaUserStory : Form
    {
        private ProgettoHandler controller;

        public InserisciNuovaUserStory(ProgettoHandler controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void buttonInserisciUserStory_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string descrizione = textBoxDescrizione.Text;

            //controlli
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(descrizione))
            {
                MessageBox.Show("Il nome o la descrizione non possono essere vuoti!", "Attenzione");
                return;
            }

            string codiceUserStory;

            try
            {
                codiceUserStory = controller.InserisciNuovaUserStory(nome, descrizione);

                richTextBoxMessaggi.Text += Environment.NewLine + "User story con nome: " + nome + " inserita con successo;";

                buttonInserisciUserStory.Enabled = false;
                buttonInserisciNuovoTask.Enabled = true;
                buttonInserisciPosizioneUserStory.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Attenzione");
            }


        }

        private void buttonInserisciNuovoTask_Click(object sender, EventArgs e)
        {
            new InserisciNuovoTask(controller).Show();
        }

        private void buttonInserisciPosizioneUserStory_Click(object sender, EventArgs e)
        {
            int posizione;
            if(!int.TryParse(textBoxPosizione.Text, out posizione))
            {
                MessageBox.Show("La posizione deve essere un valore intero!", "Attenzione");
                return;
            }

            try
            {
                controller.InserisciPosizioneUserStory(posizione);

                richTextBoxMessaggi.Text += Environment.NewLine + "Posizione della user story settata correttamente;";

                buttonInserisciNuovoTask.Enabled = false;
                buttonInserisciPosizioneUserStory.Enabled = false;
                buttonConferma.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Attenzione");
            }
        }

        private void buttonConferma_Click(object sender, EventArgs e)
        {
            controller.ConfermaInserimentoUserStory();

            MessageBox.Show("Userstory inserita con successo!", "Successo");

            Dispose();
        }
    }
}
