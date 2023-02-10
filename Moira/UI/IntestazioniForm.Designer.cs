namespace Moira.UI
{
    partial class IntestazioniForm
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
            this.textBoxNomeColonna = new System.Windows.Forms.TextBox();
            this.labelNomeBoard = new System.Windows.Forms.Label();
            this.checkBoxDaRivedere = new System.Windows.Forms.CheckBox();
            this.buttonInserisci = new System.Windows.Forms.Button();
            this.buttonTermina = new System.Windows.Forms.Button();
            this.checkBoxLimitata = new System.Windows.Forms.CheckBox();
            this.textBoxLimiteTask = new System.Windows.Forms.TextBox();
            this.labelLimite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNomeColonna
            // 
            this.textBoxNomeColonna.Location = new System.Drawing.Point(349, 156);
            this.textBoxNomeColonna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNomeColonna.Name = "textBoxNomeColonna";
            this.textBoxNomeColonna.Size = new System.Drawing.Size(363, 31);
            this.textBoxNomeColonna.TabIndex = 4;
            // 
            // labelNomeBoard
            // 
            this.labelNomeBoard.AutoSize = true;
            this.labelNomeBoard.Location = new System.Drawing.Point(428, 128);
            this.labelNomeBoard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeBoard.Name = "labelNomeBoard";
            this.labelNomeBoard.Size = new System.Drawing.Size(196, 25);
            this.labelNomeBoard.TabIndex = 5;
            this.labelNomeBoard.Text = "Inserisci nuova colonna";
            // 
            // checkBoxDaRivedere
            // 
            this.checkBoxDaRivedere.AutoSize = true;
            this.checkBoxDaRivedere.Location = new System.Drawing.Point(455, 242);
            this.checkBoxDaRivedere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxDaRivedere.Name = "checkBoxDaRivedere";
            this.checkBoxDaRivedere.Size = new System.Drawing.Size(225, 29);
            this.checkBoxDaRivedere.TabIndex = 6;
            this.checkBoxDaRivedere.Text = "Ha sezione da rivedere?";
            this.checkBoxDaRivedere.UseVisualStyleBackColor = true;
            // 
            // buttonInserisci
            // 
            this.buttonInserisci.Location = new System.Drawing.Point(349, 432);
            this.buttonInserisci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonInserisci.Name = "buttonInserisci";
            this.buttonInserisci.Size = new System.Drawing.Size(364, 36);
            this.buttonInserisci.TabIndex = 7;
            this.buttonInserisci.Text = "Inserisci";
            this.buttonInserisci.UseVisualStyleBackColor = true;
            this.buttonInserisci.Click += new System.EventHandler(this.buttonInserisci_Click);
            // 
            // buttonTermina
            // 
            this.buttonTermina.Enabled = false;
            this.buttonTermina.Location = new System.Drawing.Point(349, 495);
            this.buttonTermina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTermina.Name = "buttonTermina";
            this.buttonTermina.Size = new System.Drawing.Size(364, 59);
            this.buttonTermina.TabIndex = 8;
            this.buttonTermina.Text = "Termina";
            this.buttonTermina.UseVisualStyleBackColor = true;
            this.buttonTermina.Click += new System.EventHandler(this.buttonTermina_Click);
            // 
            // checkBoxLimitata
            // 
            this.checkBoxLimitata.AutoSize = true;
            this.checkBoxLimitata.Location = new System.Drawing.Point(455, 292);
            this.checkBoxLimitata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxLimitata.Name = "checkBoxLimitata";
            this.checkBoxLimitata.Size = new System.Drawing.Size(390, 29);
            this.checkBoxLimitata.TabIndex = 9;
            this.checkBoxLimitata.Text = "Ha un limite sul numero di task aggiungibili?";
            this.checkBoxLimitata.UseVisualStyleBackColor = true;
            this.checkBoxLimitata.CheckedChanged += new System.EventHandler(this.checkBoxLimitata_CheckedChanged);
            // 
            // textBoxLimiteTask
            // 
            this.textBoxLimiteTask.Location = new System.Drawing.Point(349, 371);
            this.textBoxLimiteTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLimiteTask.Name = "textBoxLimiteTask";
            this.textBoxLimiteTask.Size = new System.Drawing.Size(363, 31);
            this.textBoxLimiteTask.TabIndex = 10;
            this.textBoxLimiteTask.Visible = false;
            // 
            // labelLimite
            // 
            this.labelLimite.AutoSize = true;
            this.labelLimite.Location = new System.Drawing.Point(455, 342);
            this.labelLimite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLimite.Name = "labelLimite";
            this.labelLimite.Size = new System.Drawing.Size(116, 25);
            this.labelLimite.TabIndex = 11;
            this.labelLimite.Text = "Limite di task";
            this.labelLimite.Visible = false;
            // 
            // IntestazioniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 652);
            this.Controls.Add(this.labelLimite);
            this.Controls.Add(this.textBoxLimiteTask);
            this.Controls.Add(this.checkBoxLimitata);
            this.Controls.Add(this.buttonTermina);
            this.Controls.Add(this.buttonInserisci);
            this.Controls.Add(this.checkBoxDaRivedere);
            this.Controls.Add(this.labelNomeBoard);
            this.Controls.Add(this.textBoxNomeColonna);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IntestazioniForm";
            this.Text = "Inserisci nuova colonna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxNomeColonna;
        private Label labelNomeBoard;
        private CheckBox checkBoxDaRivedere;
        private Button buttonInserisci;
        private Button buttonTermina;
        private CheckBox checkBoxLimitata;
        private TextBox textBoxLimiteTask;
        private Label labelLimite;
    }
}