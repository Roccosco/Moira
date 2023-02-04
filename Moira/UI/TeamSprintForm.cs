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
    public partial class TeamSprintForm : Form
    {

        private TeamHandler controller;

        public TeamSprintForm()
        {
            InitializeComponent();
            controller  = new TeamHandler();
        }

        private void buttonTeam_Click(object sender, EventArgs e)
        {

        }

        private void buttonNuovoSprint_Click(object sender, EventArgs e)
        {
            string codiceTeam = textBoxTeam.Text;

            if(string.IsNullOrEmpty(codiceTeam))
            {
                MessageBox.Show("Inserire un codice di un team!");
                return;
            }

            controller.AvviaNuovoSprint(codiceTeam);

        }
    }
}
