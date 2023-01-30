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
    public partial class CreaBoard : Form
    {
        private TeamHandler controller;
        public CreaBoard()
        {
            InitializeComponent();
            controller= new TeamHandler();  
        }

        private void buttonNomeBoard_Click(object sender, EventArgs e)
        {
            string nome = textBoxNomeBoard.Text;
            string codice = textBoxTeamBoard.Text;  
            controller.CreaBoard(nome, codice);

        }
    }
}
