using Moira.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moira.UI
{
    public partial class InserisciNuovoProgetto : Form
    {
        private MoiraClass moira;

        public InserisciNuovoProgetto()
        {
            moira = MoiraClass.Instance;

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

            try
            {
                moira.InserisciNuovoProgetto(nome, descrizione);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Attenzione");
            }

            panelAssociaTeam.Visible = true;
            panelNome.Visible = false;
        }

        private void buttonFineTeam_Click(object sender, EventArgs e)
        {
            panelAssociaClienti.Visible = true;
            panelAssociaTeam.Visible = false;
        }

        private void buttonAggiungiTeam_Click(object sender, EventArgs e)
        {
            string codiceUnivoco = textBoxCodiceTeam.Text;

            if (string.IsNullOrEmpty(codiceUnivoco))
            {
                MessageBox.Show("Inserire un codice univoco valido", "Attenzione");
                return;
            }

            try
            {
                moira.AssociaTeamAProgetto(codiceUnivoco);
                textBoxCodiceTeam.Text = "";
                buttonFineTeam.Enabled = true;
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Il team con codice univoco " + codiceUnivoco + " non è presente nel sistema", "Attenzione");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Attenzione");
            }
        }

        private void buttonFineClienti_Click(object sender, EventArgs e)
        {
            moira.ConfermaInserimentoProgetto();

            MessageBox.Show("Progetto inserito con successo!", "Successo");

            Dispose();
        }

        private void buttonAggiungiCliente_Click(object sender, EventArgs e)
        {
            string codiceUnivoco = textBoxCodiceCliente.Text;

            if (string.IsNullOrEmpty(codiceUnivoco))
            {
                MessageBox.Show("Inserire un codice univoco valido", "Attenzione");
                return;
            }

            try
            {
                moira.AssociaClienteAProgetto(codiceUnivoco);
                textBoxCodiceCliente.Text = "";
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Il cliente con codice univoco " + codiceUnivoco + " non è presente nel sistema", "Attenzione");
            }
        }
    }
}
