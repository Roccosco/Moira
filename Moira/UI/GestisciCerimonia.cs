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
    public partial class GestisciCerimonia : Form
    {
        private TeamHandler controller;

        public GestisciCerimonia()
        {
            InitializeComponent();
            controller = new TeamHandler();
        }

        private void buttonCreaCerimonia_Click(object sender, EventArgs e)
        {
            string team = textBoxCodiceTeam.Text;
            string nome = textBoxNomeCerimonia.Text;
            string descrizione = textBoxDescCerimonia.Text;
            TipoCerimonia tipo = (TipoCerimonia)comboBoxTipo.SelectedIndex;
            DateTime data = new DateTime(dateTimePickerCerimonia.Value.Year, dateTimePickerCerimonia.Value.Month, dateTimePickerCerimonia.Value.Day, dateTimePickerOra.Value.Hour, dateTimePickerOra.Value.Minute, 0);
            int minutiDurata;

            if (string.IsNullOrEmpty(team) || string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(descrizione) || !int.TryParse(textBoxDurata.Text, out minutiDurata))
            {
                MessageBox.Show("Inserire tutti i campi");
                return;
            }

            TimeSpan durata = new TimeSpan(0, minutiDurata, 0);

            try
            {
                controller.CreaCerimonia(nome, descrizione, data, durata, tipo, team);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            new InserisciClienteCerimonia(controller).Show();
        }
    }
}
