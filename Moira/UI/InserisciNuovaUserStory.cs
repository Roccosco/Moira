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
        private Progetto progetto;
        private Observer observer;

        public InserisciNuovaUserStory(ProgettoHandler controller)
        {
            this.controller = controller;
            InitializeComponent();

            progetto = controller.ProgettoCorrente;
            observer = new ObserverAction(DrawBacklog);
            progetto.Register(observer);
            DrawBacklog();
        }

        public void DrawBacklog()
        {
            progetto.DrawBacklog(panelBacklog);

            foreach (Control panelUS in panelBacklog.Controls)
            {
                if (panelUS is not Panel)
                    continue;

                panelUS.AllowDrop = true;
                panelUS.DragEnter += (s, e) =>
                {
                    e.Effect = DragDropEffects.Move;
                };
                panelUS.DragDrop += (s, e) =>
                {
                    Panel panelUserStory = (Panel)e.Data.GetData(typeof(Panel));
                    Panel panelSpostamento = s as Panel;
                    UserStory userStory = ((Tuple<UserStory, int>)panelUserStory.Tag).Item1;
                    int posizione = ((Tuple<UserStory, int>)panelSpostamento.Tag).Item2;

                    controller.SpostaUserStory(userStory.CodiceIdentificativo, posizione);
                };

                panelUS.MouseDown += (s, e) =>
                {
                    panelUS.DoDragDrop(s, DragDropEffects.Move);
                };

                foreach (Control panelTask in panelUS.Controls)
                {
                    if (panelTask is not Panel)
                        continue;

                    ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                    contextMenuStrip.Items.Add(new ToolStripMenuItem("ModificaTask", null, ModificaTask));
                    panelTask.ContextMenuStrip = contextMenuStrip;
                }
            }
        }

        private void ModificaTask(object? sender, EventArgs e)
        {
            MoiraTask task = (((ToolStripMenuItem)sender).Owner as ContextMenuStrip).SourceControl.Tag as MoiraTask;
            try
            {
                controller.SelezionaTaskModifica(task.CodiceIdentificativo);
                new ModificaTaskForm(controller).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                textBoxNome.Enabled = false;
                textBoxDescrizione.Enabled = false;
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
            if (!int.TryParse(textBoxPosizione.Text, out posizione))
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Attenzione");
            }
        }

        private void buttonConferma_Click(object sender, EventArgs e)
        {
            controller.ConfermaInserimentoUserStory();

            MessageBox.Show("Userstory inserita con successo!", "Successo");

            textBoxNome.Enabled = true;
            textBoxNome.Text = "";
            textBoxDescrizione.Enabled = true;
            textBoxDescrizione.Text = "";
            buttonInserisciUserStory.Enabled = true;
            buttonInserisciNuovoTask.Enabled = false;
            buttonInserisciPosizioneUserStory.Enabled = false;
            buttonConferma.Visible = false;
        }
    }
}
