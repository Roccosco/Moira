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
    public partial class BoardForm : Form
    {

        private TeamHandler controller;
        private Board board;
        private Observer observer;

        public BoardForm(TeamHandler controller)
        {
            InitializeComponent();

            this.controller = controller;

            board = controller.TeamCorrente.Board;
            observer = new ObserverBoard(this);
            board.Register(observer);
            DrawBoard();
        }

        protected override void OnClosed(EventArgs e)
        {
            board.Remove(observer);
        }

        public void DrawBoard()
        {
            board.Draw(panelBoard);

            foreach (Control panelColonna in panelBoard.Controls)
            {
                if (panelColonna is not Panel)
                    continue;

                //Colonne
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                contextMenuStrip.Items.Add(new ToolStripMenuItem("Aggiungi task", null, AggiungiTaskAColonna));
                panelColonna.ContextMenuStrip = contextMenuStrip;

                panelColonna.AllowDrop = true;
                panelColonna.DragEnter += (s, e) =>
                {
                    e.Effect = DragDropEffects.Move;
                };
                panelColonna.DragDrop += (s, e) =>
                {
                    Panel panelTask = (Panel)e.Data.GetData(typeof(Panel));
                    Panel panelColonnaDa = panelTask.Parent as Panel;
                    Panel panelColonnaA = (Panel)s;
                    Colonna colonnaDa = (Colonna)panelColonnaDa.Tag;
                    Colonna colonnaA = (Colonna)panelColonnaA.Tag;
                    MoiraTask task = (MoiraTask)panelTask.Tag;

                    if (colonnaDa == colonnaA)
                        return;

                    bool daRivedereDa = false;
                    if (colonnaDa is ColonnaConDaRivedere)
                        daRivedereDa = true;

                    bool daRivedereA = false;
                    if (colonnaA is ColonnaConDaRivedere)
                        daRivedereA = true;

                    controller.SelezionaTaskBoard(task.CodiceIdentificativo, colonnaDa.CodiceIdentificativo);
                    controller.SpostaTaskTraColonne(colonnaA.CodiceIdentificativo, daRivedereDa, daRivedereA);
                };

                foreach (Control panelTask in panelColonna.Controls)
                {
                    if (panelTask is not Panel)
                        continue;

                    panelTask.MouseDown += (s, e) =>
                    {
                        panelTask.DoDragDrop(s, DragDropEffects.Move);
                    };
                }
            }
        }

        private void AggiungiTaskAColonna(object? sender, EventArgs e)
        {
            Colonna colonna = ((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl.Tag as Colonna;

            new AggiungiTaskABoardForm(colonna, controller).Show();
        }
    }
}
