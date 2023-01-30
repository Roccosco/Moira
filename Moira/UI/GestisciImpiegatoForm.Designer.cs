namespace Moira.UI
{
    partial class GestisciImpiegatoForm
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
            this.LabelIndirizzo = new System.Windows.Forms.Label();
            this.textBoxIndirizzo = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCognome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonElimina = new System.Windows.Forms.Button();
            this.buttonTrova = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCodiceUnivoco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonInserisci
            // 
            this.buttonInserisci.Location = new System.Drawing.Point(122, 398);
            this.buttonInserisci.Name = "buttonInserisci";
            this.buttonInserisci.Size = new System.Drawing.Size(264, 45);
            this.buttonInserisci.TabIndex = 25;
            this.buttonInserisci.Text = "Inserisci";
            this.buttonInserisci.UseVisualStyleBackColor = true;
            this.buttonInserisci.Click += new System.EventHandler(this.buttonInserisci_Click);
            // 
            // LabelIndirizzo
            // 
            this.LabelIndirizzo.AutoSize = true;
            this.LabelIndirizzo.Location = new System.Drawing.Point(122, 314);
            this.LabelIndirizzo.Name = "LabelIndirizzo";
            this.LabelIndirizzo.Size = new System.Drawing.Size(66, 20);
            this.LabelIndirizzo.TabIndex = 24;
            this.LabelIndirizzo.Text = "Indirizzo";
            // 
            // textBoxIndirizzo
            // 
            this.textBoxIndirizzo.Location = new System.Drawing.Point(122, 337);
            this.textBoxIndirizzo.Name = "textBoxIndirizzo";
            this.textBoxIndirizzo.Size = new System.Drawing.Size(264, 27);
            this.textBoxIndirizzo.TabIndex = 23;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(122, 254);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(67, 20);
            this.labelTelefono.TabIndex = 22;
            this.labelTelefono.Text = "Telefono";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(122, 277);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(264, 27);
            this.textBoxTelefono.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(122, 211);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(264, 27);
            this.textBoxEmail.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cognome";
            // 
            // textBoxCognome
            // 
            this.textBoxCognome.Location = new System.Drawing.Point(122, 158);
            this.textBoxCognome.Name = "textBoxCognome";
            this.textBoxCognome.Size = new System.Drawing.Size(264, 27);
            this.textBoxCognome.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(122, 97);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(264, 27);
            this.textBoxNome.TabIndex = 13;
            // 
            // buttonElimina
            // 
            this.buttonElimina.Enabled = false;
            this.buttonElimina.Location = new System.Drawing.Point(583, 151);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(364, 34);
            this.buttonElimina.TabIndex = 30;
            this.buttonElimina.Text = "Elimina";
            this.buttonElimina.UseVisualStyleBackColor = true;
            this.buttonElimina.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // buttonTrova
            // 
            this.buttonTrova.Location = new System.Drawing.Point(853, 95);
            this.buttonTrova.Name = "buttonTrova";
            this.buttonTrova.Size = new System.Drawing.Size(94, 29);
            this.buttonTrova.TabIndex = 28;
            this.buttonTrova.Text = "Trova";
            this.buttonTrova.UseVisualStyleBackColor = true;
            this.buttonTrova.Click += new System.EventHandler(this.buttonTrova_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(583, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Codice univoco";
            // 
            // textBoxCodiceUnivoco
            // 
            this.textBoxCodiceUnivoco.Location = new System.Drawing.Point(583, 97);
            this.textBoxCodiceUnivoco.Name = "textBoxCodiceUnivoco";
            this.textBoxCodiceUnivoco.Size = new System.Drawing.Size(264, 27);
            this.textBoxCodiceUnivoco.TabIndex = 26;
            // 
            // GestisciImpiegatoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 645);
            this.Controls.Add(this.buttonElimina);
            this.Controls.Add(this.buttonTrova);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCodiceUnivoco);
            this.Controls.Add(this.buttonInserisci);
            this.Controls.Add(this.LabelIndirizzo);
            this.Controls.Add(this.textBoxIndirizzo);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCognome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNome);
            this.Name = "GestisciImpiegatoForm";
            this.Text = "GestisciImpiegatoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonInserisci;
        private Label LabelIndirizzo;
        private TextBox textBoxIndirizzo;
        private Label labelTelefono;
        private TextBox textBoxTelefono;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label2;
        private TextBox textBoxCognome;
        private Label label1;
        private TextBox textBoxNome;
        private Button buttonElimina;
        private Button buttonTrova;
        private Label label7;
        private TextBox textBoxCodiceUnivoco;
    }
}