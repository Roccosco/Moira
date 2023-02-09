namespace Moira.UI
{
    partial class GestisciTeamForm
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
            this.LabelTeam = new System.Windows.Forms.Label();
            this.textBoxTeam = new System.Windows.Forms.TextBox();
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.buttonConferma = new System.Windows.Forms.Button();
            this.textBoxCodiceUnivoco = new System.Windows.Forms.TextBox();
            this.labelAggImpiegato = new System.Windows.Forms.Label();
            this.buttonModifica = new System.Windows.Forms.Button();
            this.textBoxModifica = new System.Windows.Forms.TextBox();
            this.labelModifica = new System.Windows.Forms.Label();
            this.buttonEliminaTeam = new System.Windows.Forms.Button();
            this.textBoxEliminaTeam = new System.Windows.Forms.TextBox();
            this.labelEliminaTeam = new System.Windows.Forms.Label();
            this.dataGridViewTeams = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewImpiegati = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImpiegati)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInserisci
            // 
            this.buttonInserisci.Location = new System.Drawing.Point(95, 108);
            this.buttonInserisci.Name = "buttonInserisci";
            this.buttonInserisci.Size = new System.Drawing.Size(264, 45);
            this.buttonInserisci.TabIndex = 28;
            this.buttonInserisci.Text = "Inserisci";
            this.buttonInserisci.UseVisualStyleBackColor = true;
            this.buttonInserisci.Click += new System.EventHandler(this.buttonInserisci_Click);
            // 
            // LabelTeam
            // 
            this.LabelTeam.AutoSize = true;
            this.LabelTeam.Location = new System.Drawing.Point(95, 24);
            this.LabelTeam.Name = "LabelTeam";
            this.LabelTeam.Size = new System.Drawing.Size(93, 20);
            this.LabelTeam.TabIndex = 27;
            this.LabelTeam.Text = "Nuovo Team";
            // 
            // textBoxTeam
            // 
            this.textBoxTeam.Location = new System.Drawing.Point(95, 47);
            this.textBoxTeam.Name = "textBoxTeam";
            this.textBoxTeam.Size = new System.Drawing.Size(264, 27);
            this.textBoxTeam.TabIndex = 26;
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Enabled = false;
            this.buttonAggiungi.Location = new System.Drawing.Point(95, 269);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(264, 45);
            this.buttonAggiungi.TabIndex = 29;
            this.buttonAggiungi.Text = "Aggiungi";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click);
            // 
            // buttonConferma
            // 
            this.buttonConferma.Enabled = false;
            this.buttonConferma.Location = new System.Drawing.Point(95, 332);
            this.buttonConferma.Name = "buttonConferma";
            this.buttonConferma.Size = new System.Drawing.Size(264, 47);
            this.buttonConferma.TabIndex = 33;
            this.buttonConferma.Text = "Conferma creazione";
            this.buttonConferma.Click += new System.EventHandler(this.buttonConferma_Click);
            // 
            // textBoxCodiceUnivoco
            // 
            this.textBoxCodiceUnivoco.Location = new System.Drawing.Point(95, 208);
            this.textBoxCodiceUnivoco.Name = "textBoxCodiceUnivoco";
            this.textBoxCodiceUnivoco.Size = new System.Drawing.Size(264, 27);
            this.textBoxCodiceUnivoco.TabIndex = 31;
            // 
            // labelAggImpiegato
            // 
            this.labelAggImpiegato.AutoSize = true;
            this.labelAggImpiegato.Location = new System.Drawing.Point(95, 185);
            this.labelAggImpiegato.Name = "labelAggImpiegato";
            this.labelAggImpiegato.Size = new System.Drawing.Size(238, 20);
            this.labelAggImpiegato.TabIndex = 32;
            this.labelAggImpiegato.Text = "Inserisci codice univoco impiegato";
            // 
            // buttonModifica
            // 
            this.buttonModifica.Location = new System.Drawing.Point(436, 413);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(264, 45);
            this.buttonModifica.TabIndex = 34;
            this.buttonModifica.Text = "modifica";
            this.buttonModifica.UseVisualStyleBackColor = true;
            this.buttonModifica.Click += new System.EventHandler(this.buttonModifica_Click);
            // 
            // textBoxModifica
            // 
            this.textBoxModifica.Location = new System.Drawing.Point(436, 352);
            this.textBoxModifica.Name = "textBoxModifica";
            this.textBoxModifica.Size = new System.Drawing.Size(264, 27);
            this.textBoxModifica.TabIndex = 35;
            // 
            // labelModifica
            // 
            this.labelModifica.AutoSize = true;
            this.labelModifica.Location = new System.Drawing.Point(436, 329);
            this.labelModifica.Name = "labelModifica";
            this.labelModifica.Size = new System.Drawing.Size(106, 20);
            this.labelModifica.TabIndex = 36;
            this.labelModifica.Text = "Modifica team";
            // 
            // buttonEliminaTeam
            // 
            this.buttonEliminaTeam.Location = new System.Drawing.Point(436, 574);
            this.buttonEliminaTeam.Name = "buttonEliminaTeam";
            this.buttonEliminaTeam.Size = new System.Drawing.Size(264, 45);
            this.buttonEliminaTeam.TabIndex = 37;
            this.buttonEliminaTeam.Text = "Elimina";
            this.buttonEliminaTeam.UseVisualStyleBackColor = true;
            this.buttonEliminaTeam.Click += new System.EventHandler(this.buttonEliminaTeam_Click);
            // 
            // textBoxEliminaTeam
            // 
            this.textBoxEliminaTeam.Location = new System.Drawing.Point(436, 513);
            this.textBoxEliminaTeam.Name = "textBoxEliminaTeam";
            this.textBoxEliminaTeam.Size = new System.Drawing.Size(264, 27);
            this.textBoxEliminaTeam.TabIndex = 38;
            // 
            // labelEliminaTeam
            // 
            this.labelEliminaTeam.AutoSize = true;
            this.labelEliminaTeam.Location = new System.Drawing.Point(436, 490);
            this.labelEliminaTeam.Name = "labelEliminaTeam";
            this.labelEliminaTeam.Size = new System.Drawing.Size(96, 20);
            this.labelEliminaTeam.TabIndex = 39;
            this.labelEliminaTeam.Text = "Elimina team";
            // 
            // dataGridViewTeams
            // 
            this.dataGridViewTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeams.Location = new System.Drawing.Point(402, 47);
            this.dataGridViewTeams.Name = "dataGridViewTeams";
            this.dataGridViewTeams.RowHeadersWidth = 51;
            this.dataGridViewTeams.RowTemplate.Height = 29;
            this.dataGridViewTeams.Size = new System.Drawing.Size(368, 252);
            this.dataGridViewTeams.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "TEAM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "IMPIEGATI:";
            // 
            // dataGridViewImpiegati
            // 
            this.dataGridViewImpiegati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImpiegati.Location = new System.Drawing.Point(36, 410);
            this.dataGridViewImpiegati.Name = "dataGridViewImpiegati";
            this.dataGridViewImpiegati.RowHeadersWidth = 51;
            this.dataGridViewImpiegati.RowTemplate.Height = 29;
            this.dataGridViewImpiegati.Size = new System.Drawing.Size(355, 227);
            this.dataGridViewImpiegati.TabIndex = 42;
            // 
            // GestisciTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 674);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewImpiegati);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTeams);
            this.Controls.Add(this.labelEliminaTeam);
            this.Controls.Add(this.textBoxEliminaTeam);
            this.Controls.Add(this.buttonEliminaTeam);
            this.Controls.Add(this.labelModifica);
            this.Controls.Add(this.textBoxModifica);
            this.Controls.Add(this.buttonModifica);
            this.Controls.Add(this.labelAggImpiegato);
            this.Controls.Add(this.textBoxCodiceUnivoco);
            this.Controls.Add(this.buttonConferma);
            this.Controls.Add(this.buttonAggiungi);
            this.Controls.Add(this.buttonInserisci);
            this.Controls.Add(this.LabelTeam);
            this.Controls.Add(this.textBoxTeam);
            this.Name = "GestisciTeamForm";
            this.Text = "GestisciTeamForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImpiegati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonInserisci;
        private Label LabelTeam;
        private TextBox textBoxTeam;
        private Button buttonAggiungi;
        private Button buttonConferma;
        private TextBox textBoxCodiceUnivoco;
        private Label labelAggImpiegato;
        private Button buttonModifica;
        private TextBox textBoxModifica;
        private Label labelModifica;
        private Button buttonEliminaTeam;
        private TextBox textBoxEliminaTeam;
        private Label labelEliminaTeam;
        private DataGridView dataGridViewTeams;
        private Label label1;
        private Label label2;
        private DataGridView dataGridViewImpiegati;
    }
}