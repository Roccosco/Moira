﻿using Moira.Dominio.Controllers;
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
    public partial class InserisciClienteCerimonia : Form
    {
        private TeamHandler controller;
        public InserisciClienteCerimonia()
        {
            InitializeComponent();
            controller = new TeamHandler();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            string codiceUnivoco = textBoxCliente.Text;

            try
            {
                controller.InvitoCerimonia(codiceUnivoco); 

                MessageBox.Show("l'impiegato è stato aggiunto correttamente");

            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("l'impiegato con il codice univoco: " + codiceUnivoco + " non è presente nel Sistema!");
            }
        }
    }
}