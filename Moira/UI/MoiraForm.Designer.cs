namespace Moira.UI
{
    partial class MoiraForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInserisciProgetti = new System.Windows.Forms.Button();
            this.buttonGestisciBacklog = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGestisciImpiegato = new System.Windows.Forms.Button();
            this.buttonGestisciTeam = new System.Windows.Forms.Button();
            this.buttonCreaBoard = new System.Windows.Forms.Button();
            this.buttonCerimonia = new System.Windows.Forms.Button();
            this.buttonSprint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(500, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moira";
            // 
            // buttonInserisciProgetti
            // 
            this.buttonInserisciProgetti.Location = new System.Drawing.Point(420, 174);
            this.buttonInserisciProgetti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonInserisciProgetti.Name = "buttonInserisciProgetti";
            this.buttonInserisciProgetti.Size = new System.Drawing.Size(265, 55);
            this.buttonInserisciProgetti.TabIndex = 1;
            this.buttonInserisciProgetti.Text = "Inserisci nuovo progetto";
            this.buttonInserisciProgetti.UseVisualStyleBackColor = true;
            this.buttonInserisciProgetti.Click += new System.EventHandler(this.buttonInserisciProgetti_Click);
            // 
            // buttonGestisciBacklog
            // 
            this.buttonGestisciBacklog.Location = new System.Drawing.Point(420, 280);
            this.buttonGestisciBacklog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGestisciBacklog.Name = "buttonGestisciBacklog";
            this.buttonGestisciBacklog.Size = new System.Drawing.Size(265, 55);
            this.buttonGestisciBacklog.TabIndex = 2;
            this.buttonGestisciBacklog.Text = "Gestisci backlog";
            this.buttonGestisciBacklog.UseVisualStyleBackColor = true;
            this.buttonGestisciBacklog.Click += new System.EventHandler(this.buttonGestisciBacklog_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 371);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gestisci clienti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonGestisciClienti_Click);
            // 
            // buttonGestisciImpiegato
            // 
            this.buttonGestisciImpiegato.Location = new System.Drawing.Point(416, 460);
            this.buttonGestisciImpiegato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGestisciImpiegato.Name = "buttonGestisciImpiegato";
            this.buttonGestisciImpiegato.Size = new System.Drawing.Size(265, 55);
            this.buttonGestisciImpiegato.TabIndex = 4;
            this.buttonGestisciImpiegato.Text = "Gestisci impiegato";
            this.buttonGestisciImpiegato.UseVisualStyleBackColor = true;
            this.buttonGestisciImpiegato.Click += new System.EventHandler(this.buttonGestisciImpiegato_Click);
            // 
            // buttonGestisciTeam
            // 
            this.buttonGestisciTeam.Location = new System.Drawing.Point(416, 548);
            this.buttonGestisciTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGestisciTeam.Name = "buttonGestisciTeam";
            this.buttonGestisciTeam.Size = new System.Drawing.Size(265, 55);
            this.buttonGestisciTeam.TabIndex = 5;
            this.buttonGestisciTeam.Text = "Gestisci team";
            this.buttonGestisciTeam.UseVisualStyleBackColor = true;
            this.buttonGestisciTeam.Click += new System.EventHandler(this.buttonGestisciTeam_Click);
            // 
            // buttonCreaBoard
            // 
            this.buttonCreaBoard.Location = new System.Drawing.Point(412, 639);
            this.buttonCreaBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreaBoard.Name = "buttonCreaBoard";
            this.buttonCreaBoard.Size = new System.Drawing.Size(269, 55);
            this.buttonCreaBoard.TabIndex = 6;
            this.buttonCreaBoard.Text = "Crea Board";
            this.buttonCreaBoard.UseVisualStyleBackColor = true;
            this.buttonCreaBoard.Click += new System.EventHandler(this.buttonCreaBoard_Click);
            // 
            // buttonCerimonia
            // 
            this.buttonCerimonia.Location = new System.Drawing.Point(409, 738);
            this.buttonCerimonia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCerimonia.Name = "buttonCerimonia";
            this.buttonCerimonia.Size = new System.Drawing.Size(272, 55);
            this.buttonCerimonia.TabIndex = 7;
            this.buttonCerimonia.Text = "Gestisci Cerimonia";
            this.buttonCerimonia.UseVisualStyleBackColor = true;
            this.buttonCerimonia.Click += new System.EventHandler(this.buttonCerimonia_Click);
            // 
            // buttonSprint
            // 
            this.buttonSprint.Location = new System.Drawing.Point(759, 174);
            this.buttonSprint.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSprint.Name = "buttonSprint";
            this.buttonSprint.Size = new System.Drawing.Size(272, 55);
            this.buttonSprint.TabIndex = 8;
            this.buttonSprint.Text = "Gestisci sprint";
            this.buttonSprint.UseVisualStyleBackColor = true;
            this.buttonSprint.Click += new System.EventHandler(this.buttonSprint_Click);
            // 
            // MoiraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 868);
            this.Controls.Add(this.buttonSprint);
            this.Controls.Add(this.buttonCerimonia);
            this.Controls.Add(this.buttonCreaBoard);
            this.Controls.Add(this.buttonGestisciTeam);
            this.Controls.Add(this.buttonGestisciImpiegato);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGestisciBacklog);
            this.Controls.Add(this.buttonInserisciProgetti);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MoiraForm";
            this.Text = "Moira";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button buttonInserisciProgetti;
        private Button buttonGestisciBacklog;
        private Button button1;
        private Button buttonGestisciImpiegato;
        private Button buttonGestisciTeam;
        private Button buttonCreaBoard;
        private Button buttonCerimonia;
        private Button buttonSprint;
    }
}