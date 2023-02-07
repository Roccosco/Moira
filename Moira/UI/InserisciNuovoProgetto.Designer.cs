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
            this.label2 = new System.Windows.Forms.Label();
            this.panelNome = new System.Windows.Forms.Panel();
            this.buttonAvanti = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescrizione = new System.Windows.Forms.TextBox();
            this.panelNome.SuspendLayout();
            this.SuspendLayout();
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
            // panelNome
            // 
            this.panelNome.Controls.Add(this.buttonAvanti);
            this.panelNome.Controls.Add(this.textBoxNome);
            this.panelNome.Controls.Add(this.label3);
            this.panelNome.Controls.Add(this.label1);
            this.panelNome.Controls.Add(this.textBoxDescrizione);
            this.panelNome.Location = new System.Drawing.Point(12, 57);
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
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(324, 45);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(326, 27);
            this.textBoxNome.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // textBoxDescrizione
            // 
            this.textBoxDescrizione.Location = new System.Drawing.Point(324, 122);
            this.textBoxDescrizione.Name = "textBoxDescrizione";
            this.textBoxDescrizione.Size = new System.Drawing.Size(326, 27);
            this.textBoxDescrizione.TabIndex = 3;
            // 
            // InserisciNuovoProgetto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 630);
            this.Controls.Add(this.panelNome);
            this.Controls.Add(this.label2);
            this.Name = "InserisciNuovoProgetto";
            this.Text = "Nuovo Progetto";
            this.panelNome.ResumeLayout(false);
            this.panelNome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Panel panelNome;
        private Button buttonAvanti;
        private TextBox textBoxNome;
        private Label label3;
        private Label label1;
        private TextBox textBoxDescrizione;
    }
}