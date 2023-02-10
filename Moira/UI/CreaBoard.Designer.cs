namespace Moira.UI
{
    partial class CreaBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonInserisci = new System.Windows.Forms.Button();
            this.textBoxNomeBoard = new System.Windows.Forms.TextBox();
            this.labelNomeBoard = new System.Windows.Forms.Label();
            this.textBoxTeamBoard = new System.Windows.Forms.TextBox();
            this.labelTeamBoard = new System.Windows.Forms.Label();
            this.dataGridViewTeams = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInserisci
            // 
            this.buttonInserisci.Location = new System.Drawing.Point(306, 565);
            this.buttonInserisci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonInserisci.Name = "buttonInserisci";
            this.buttonInserisci.Size = new System.Drawing.Size(364, 36);
            this.buttonInserisci.TabIndex = 1;
            this.buttonInserisci.Text = "Inserisci";
            this.buttonInserisci.UseVisualStyleBackColor = true;
            this.buttonInserisci.Click += new System.EventHandler(this.buttonInserisci_Click);
            // 
            // textBoxNomeBoard
            // 
            this.textBoxNomeBoard.Location = new System.Drawing.Point(306, 422);
            this.textBoxNomeBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNomeBoard.Name = "textBoxNomeBoard";
            this.textBoxNomeBoard.Size = new System.Drawing.Size(363, 31);
            this.textBoxNomeBoard.TabIndex = 2;
            // 
            // labelNomeBoard
            // 
            this.labelNomeBoard.AutoSize = true;
            this.labelNomeBoard.Location = new System.Drawing.Point(402, 394);
            this.labelNomeBoard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeBoard.Name = "labelNomeBoard";
            this.labelNomeBoard.Size = new System.Drawing.Size(178, 25);
            this.labelNomeBoard.TabIndex = 3;
            this.labelNomeBoard.Text = "Inserisci nome board";
            // 
            // textBoxTeamBoard
            // 
            this.textBoxTeamBoard.Location = new System.Drawing.Point(306, 504);
            this.textBoxTeamBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTeamBoard.Name = "textBoxTeamBoard";
            this.textBoxTeamBoard.Size = new System.Drawing.Size(363, 31);
            this.textBoxTeamBoard.TabIndex = 4;
            // 
            // labelTeamBoard
            // 
            this.labelTeamBoard.AutoSize = true;
            this.labelTeamBoard.Location = new System.Drawing.Point(306, 475);
            this.labelTeamBoard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTeamBoard.Name = "labelTeamBoard";
            this.labelTeamBoard.Size = new System.Drawing.Size(346, 25);
            this.labelTeamBoard.TabIndex = 5;
            this.labelTeamBoard.Text = "Inserisci codice team a cui associare board";
            // 
            // dataGridViewTeams
            // 
            this.dataGridViewTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeams.Location = new System.Drawing.Point(154, 50);
            this.dataGridViewTeams.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewTeams.Name = "dataGridViewTeams";
            this.dataGridViewTeams.RowHeadersWidth = 51;
            this.dataGridViewTeams.RowTemplate.Height = 29;
            this.dataGridViewTeams.Size = new System.Drawing.Size(680, 265);
            this.dataGridViewTeams.TabIndex = 6;
            // 
            // CreaBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 655);
            this.Controls.Add(this.dataGridViewTeams);
            this.Controls.Add(this.labelTeamBoard);
            this.Controls.Add(this.textBoxTeamBoard);
            this.Controls.Add(this.labelNomeBoard);
            this.Controls.Add(this.textBoxNomeBoard);
            this.Controls.Add(this.buttonInserisci);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreaBoard";
            this.Text = "Crea Board";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonInserisci;
        private TextBox textBoxNomeBoard;
        private Label labelNomeBoard;
        private TextBox textBoxTeamBoard;
        private Label labelTeamBoard;
        private DataGridView dataGridViewTeams;
    }
}