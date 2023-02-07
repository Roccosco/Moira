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
    public partial class AggiungiTaskABoardForm : Form
    {
        private TeamHandler controller;
        private Colonna colonna;

        public AggiungiTaskABoardForm(Colonna colonna, TeamHandler controller)
        {
            this.colonna = colonna;
            this.controller = controller;
            InitializeComponent();
            dataGridViewTask.DataSource = controller.GetTaskPerBoard();
        }

        private void buttonContinua_Click(object sender, EventArgs e)
        {
            string codiceTask = textBoxTask.Text;
            if (string.IsNullOrEmpty(codiceTask))
            {
                MessageBox.Show("Inserire un codice valido");
                return;
            }

            try
            {
                controller.SelezionaTaskBacklogs(codiceTask);
                controller.AggiungiTaskAColonna(colonna.CodiceIdentificativo);

                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
