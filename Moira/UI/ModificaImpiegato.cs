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
    public partial class ModificaImpiegato : Form
    {
        private TeamHandler controller;

        public ModificaImpiegato()
        {
            InitializeComponent();
            controller = new TeamHandler();
        }

        
    }
}
