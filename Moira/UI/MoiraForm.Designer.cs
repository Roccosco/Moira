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
            this.buttonVisualizzaBoard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(414, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moira";
            // 
            // buttonInserisciProgetti
            // 
            this.buttonInserisciProgetti.Location = new System.Drawing.Point(82, 139);
            this.buttonInserisciProgetti.Name = "buttonInserisciProgetti";
            this.buttonInserisciProgetti.Size = new System.Drawing.Size(212, 44);
            this.buttonInserisciProgetti.TabIndex = 1;
            this.buttonInserisciProgetti.Text = "Inserisci nuovo progetto";
            this.buttonInserisciProgetti.UseVisualStyleBackColor = true;
            this.buttonInserisciProgetti.Click += new System.EventHandler(this.buttonInserisciProgetti_Click);
            // 
            // buttonGestisciBacklog
            // 
            this.buttonGestisciBacklog.Location = new System.Drawing.Point(82, 215);
            this.buttonGestisciBacklog.Name = "buttonGestisciBacklog";
            this.buttonGestisciBacklog.Size = new System.Drawing.Size(212, 44);
            this.buttonGestisciBacklog.TabIndex = 2;
            this.buttonGestisciBacklog.Text = "Gestisci backlog";
            this.buttonGestisciBacklog.UseVisualStyleBackColor = true;
            this.buttonGestisciBacklog.Click += new System.EventHandler(this.buttonGestisciBacklog_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gestisci clienti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonGestisciClienti_Click);
            // 
            // buttonGestisciImpiegato
            // 
            this.buttonGestisciImpiegato.Location = new System.Drawing.Point(350, 215);
            this.buttonGestisciImpiegato.Name = "buttonGestisciImpiegato";
            this.buttonGestisciImpiegato.Size = new System.Drawing.Size(212, 44);
            this.buttonGestisciImpiegato.TabIndex = 4;
            this.buttonGestisciImpiegato.Text = "Gestisci impiegato";
            this.buttonGestisciImpiegato.UseVisualStyleBackColor = true;
            this.buttonGestisciImpiegato.Click += new System.EventHandler(this.buttonGestisciImpiegato_Click);
            // 
            // buttonGestisciTeam
            // 
            this.buttonGestisciTeam.Location = new System.Drawing.Point(607, 139);
            this.buttonGestisciTeam.Name = "buttonGestisciTeam";
            this.buttonGestisciTeam.Size = new System.Drawing.Size(212, 44);
            this.buttonGestisciTeam.TabIndex = 5;
            this.buttonGestisciTeam.Text = "Gestisci team";
            this.buttonGestisciTeam.UseVisualStyleBackColor = true;
            this.buttonGestisciTeam.Click += new System.EventHandler(this.buttonGestisciTeam_Click);
            // 
            // buttonCreaBoard
            // 
            this.buttonCreaBoard.Location = new System.Drawing.Point(350, 394);
            this.buttonCreaBoard.Name = "buttonCreaBoard";
            this.buttonCreaBoard.Size = new System.Drawing.Size(218, 44);
            this.buttonCreaBoard.TabIndex = 6;
            this.buttonCreaBoard.Text = "Crea Board";
            this.buttonCreaBoard.UseVisualStyleBackColor = true;
            this.buttonCreaBoard.Click += new System.EventHandler(this.buttonCreaBoard_Click);
            // 
            // buttonCerimonia
            // 
            this.buttonCerimonia.Location = new System.Drawing.Point(607, 295);
            this.buttonCerimonia.Name = "buttonCerimonia";
            this.buttonCerimonia.Size = new System.Drawing.Size(218, 44);
            this.buttonCerimonia.TabIndex = 7;
            this.buttonCerimonia.Text = "Gestisci Cerimonia";
            this.buttonCerimonia.UseVisualStyleBackColor = true;
            this.buttonCerimonia.Click += new System.EventHandler(this.buttonCerimonia_Click);
            // 
            // buttonSprint
            // 
            this.buttonSprint.Location = new System.Drawing.Point(607, 215);
            this.buttonSprint.Name = "buttonSprint";
            this.buttonSprint.Size = new System.Drawing.Size(218, 44);
            this.buttonSprint.TabIndex = 8;
            this.buttonSprint.Text = "Gestisci sprint";
            this.buttonSprint.UseVisualStyleBackColor = true;
            this.buttonSprint.Click += new System.EventHandler(this.buttonSprint_Click);
            // 
            // buttonVisualizzaBoard
            // 
            this.buttonVisualizzaBoard.Location = new System.Drawing.Point(350, 471);
            this.buttonVisualizzaBoard.Name = "buttonVisualizzaBoard";
            this.buttonVisualizzaBoard.Size = new System.Drawing.Size(218, 44);
            this.buttonVisualizzaBoard.TabIndex = 9;
            this.buttonVisualizzaBoard.Text = "Visualizza Board";
            this.buttonVisualizzaBoard.UseVisualStyleBackColor = true;
            this.buttonVisualizzaBoard.Click += new System.EventHandler(this.buttonVisualizzaBoard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gestione progetti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gestione team";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Board";
            // 
            // MoiraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 628);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonVisualizzaBoard);
            this.Controls.Add(this.buttonSprint);
            this.Controls.Add(this.buttonCerimonia);
            this.Controls.Add(this.buttonCreaBoard);
            this.Controls.Add(this.buttonGestisciTeam);
            this.Controls.Add(this.buttonGestisciImpiegato);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGestisciBacklog);
            this.Controls.Add(this.buttonInserisciProgetti);
            this.Controls.Add(this.label1);
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
        private Button buttonVisualizzaBoard;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}