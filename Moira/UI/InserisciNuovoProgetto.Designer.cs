namespace Moira.UI
{
    partial class InserisciNuovoProgetto
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescrizione = new System.Windows.Forms.TextBox();
            this.panelNome = new System.Windows.Forms.Panel();
            this.buttonAvanti = new System.Windows.Forms.Button();
            this.panelAssociaTeam = new System.Windows.Forms.Panel();
            this.buttonFineTeam = new System.Windows.Forms.Button();
            this.buttonAggiungiTeam = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCodiceTeam = new System.Windows.Forms.TextBox();
            this.panelAssociaClienti = new System.Windows.Forms.Panel();
            this.buttonFineClienti = new System.Windows.Forms.Button();
            this.buttonAggiungiCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCodiceCliente = new System.Windows.Forms.TextBox();
            this.panelNome.SuspendLayout();
            this.panelAssociaTeam.SuspendLayout();
            this.panelAssociaClienti.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(324, 45);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(326, 27);
            this.textBoxNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(380, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inserisci nuovo progetto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrizione:";
            // 
            // textBoxDescrizione
            // 
            this.textBoxDescrizione.Location = new System.Drawing.Point(324, 122);
            this.textBoxDescrizione.Name = "textBoxDescrizione";
            this.textBoxDescrizione.Size = new System.Drawing.Size(326, 27);
            this.textBoxDescrizione.TabIndex = 3;
            // 
            // panelNome
            // 
            this.panelNome.Controls.Add(this.buttonAvanti);
            this.panelNome.Controls.Add(this.textBoxNome);
            this.panelNome.Controls.Add(this.label3);
            this.panelNome.Controls.Add(this.label1);
            this.panelNome.Controls.Add(this.textBoxDescrizione);
            this.panelNome.Location = new System.Drawing.Point(12, 67);
            this.panelNome.Name = "panelNome";
            this.panelNome.Size = new System.Drawing.Size(941, 551);
            this.panelNome.TabIndex = 5;
            // 
            // buttonAvanti
            // 
            this.buttonAvanti.Location = new System.Drawing.Point(324, 195);
            this.buttonAvanti.Name = "buttonAvanti";
            this.buttonAvanti.Size = new System.Drawing.Size(326, 32);
            this.buttonAvanti.TabIndex = 5;
            this.buttonAvanti.Text = "Avanti";
            this.buttonAvanti.UseVisualStyleBackColor = true;
            this.buttonAvanti.Click += new System.EventHandler(this.buttonAvanti_Click);
            // 
            // panelAssociaTeam
            // 
            this.panelAssociaTeam.Controls.Add(this.buttonFineTeam);
            this.panelAssociaTeam.Controls.Add(this.buttonAggiungiTeam);
            this.panelAssociaTeam.Controls.Add(this.label4);
            this.panelAssociaTeam.Controls.Add(this.textBoxCodiceTeam);
            this.panelAssociaTeam.Location = new System.Drawing.Point(12, 57);
            this.panelAssociaTeam.Name = "panelAssociaTeam";
            this.panelAssociaTeam.Size = new System.Drawing.Size(941, 551);
            this.panelAssociaTeam.TabIndex = 6;
            this.panelAssociaTeam.Visible = false;
            // 
            // buttonFineTeam
            // 
            this.buttonFineTeam.Enabled = false;
            this.buttonFineTeam.Location = new System.Drawing.Point(324, 282);
            this.buttonFineTeam.Name = "buttonFineTeam";
            this.buttonFineTeam.Size = new System.Drawing.Size(307, 68);
            this.buttonFineTeam.TabIndex = 3;
            this.buttonFineTeam.Text = "Avanti";
            this.buttonFineTeam.UseVisualStyleBackColor = true;
            this.buttonFineTeam.Click += new System.EventHandler(this.buttonFineTeam_Click);
            // 
            // buttonAggiungiTeam
            // 
            this.buttonAggiungiTeam.Location = new System.Drawing.Point(324, 120);
            this.buttonAggiungiTeam.Name = "buttonAggiungiTeam";
            this.buttonAggiungiTeam.Size = new System.Drawing.Size(307, 29);
            this.buttonAggiungiTeam.TabIndex = 2;
            this.buttonAggiungiTeam.Text = "Aggiungi";
            this.buttonAggiungiTeam.UseVisualStyleBackColor = true;
            this.buttonAggiungiTeam.Click += new System.EventHandler(this.buttonAggiungiTeam_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Codice team:";
            // 
            // textBoxCodiceTeam
            // 
            this.textBoxCodiceTeam.Location = new System.Drawing.Point(324, 78);
            this.textBoxCodiceTeam.Name = "textBoxCodiceTeam";
            this.textBoxCodiceTeam.Size = new System.Drawing.Size(307, 27);
            this.textBoxCodiceTeam.TabIndex = 0;
            // 
            // panelAssociaClienti
            // 
            this.panelAssociaClienti.Controls.Add(this.buttonFineClienti);
            this.panelAssociaClienti.Controls.Add(this.buttonAggiungiCliente);
            this.panelAssociaClienti.Controls.Add(this.label5);
            this.panelAssociaClienti.Controls.Add(this.textBoxCodiceCliente);
            this.panelAssociaClienti.Location = new System.Drawing.Point(15, 67);
            this.panelAssociaClienti.Name = "panelAssociaClienti";
            this.panelAssociaClienti.Size = new System.Drawing.Size(941, 551);
            this.panelAssociaClienti.TabIndex = 7;
            this.panelAssociaClienti.Visible = false;
            // 
            // buttonFineClienti
            // 
            this.buttonFineClienti.Location = new System.Drawing.Point(324, 282);
            this.buttonFineClienti.Name = "buttonFineClienti";
            this.buttonFineClienti.Size = new System.Drawing.Size(307, 68);
            this.buttonFineClienti.TabIndex = 3;
            this.buttonFineClienti.Text = "Inserisci";
            this.buttonFineClienti.UseVisualStyleBackColor = true;
            this.buttonFineClienti.Click += new System.EventHandler(this.buttonFineClienti_Click);
            // 
            // buttonAggiungiCliente
            // 
            this.buttonAggiungiCliente.Location = new System.Drawing.Point(324, 120);
            this.buttonAggiungiCliente.Name = "buttonAggiungiCliente";
            this.buttonAggiungiCliente.Size = new System.Drawing.Size(307, 29);
            this.buttonAggiungiCliente.TabIndex = 2;
            this.buttonAggiungiCliente.Text = "Aggiungi";
            this.buttonAggiungiCliente.UseVisualStyleBackColor = true;
            this.buttonAggiungiCliente.Click += new System.EventHandler(this.buttonAggiungiCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Codice cliente:";
            // 
            // textBoxCodiceCliente
            // 
            this.textBoxCodiceCliente.Location = new System.Drawing.Point(324, 78);
            this.textBoxCodiceCliente.Name = "textBoxCodiceCliente";
            this.textBoxCodiceCliente.Size = new System.Drawing.Size(307, 27);
            this.textBoxCodiceCliente.TabIndex = 0;
            // 
            // InserisciNuovoProgetto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 630);
            this.Controls.Add(this.panelNome);
            this.Controls.Add(this.panelAssociaTeam);
            this.Controls.Add(this.panelAssociaClienti);
            this.Controls.Add(this.label2);
            this.Name = "InserisciNuovoProgetto";
            this.Text = "Nuovo Progetto";
            this.panelNome.ResumeLayout(false);
            this.panelNome.PerformLayout();
            this.panelAssociaTeam.ResumeLayout(false);
            this.panelAssociaTeam.PerformLayout();
            this.panelAssociaClienti.ResumeLayout(false);
            this.panelAssociaClienti.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNome;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxDescrizione;
        private Panel panelNome;
        private Button buttonAvanti;
        private Panel panelAssociaTeam;
        private Button buttonFineTeam;
        private Button buttonAggiungiTeam;
        private Label label4;
        private TextBox textBoxCodiceTeam;
        private Panel panelAssociaClienti;
        private Button buttonFineClienti;
        private Button buttonAggiungiCliente;
        private Label label5;
        private TextBox textBoxCodiceCliente;
    }
}