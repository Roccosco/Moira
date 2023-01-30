namespace Moira.UI
{
    partial class ModificaClienteForm
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
            this.buttonAssocia = new System.Windows.Forms.Button();
            this.buttonDissocia = new System.Windows.Forms.Button();
            this.textBoxProgetto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTermina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAssocia
            // 
            this.buttonAssocia.Location = new System.Drawing.Point(336, 301);
            this.buttonAssocia.Name = "buttonAssocia";
            this.buttonAssocia.Size = new System.Drawing.Size(94, 29);
            this.buttonAssocia.TabIndex = 0;
            this.buttonAssocia.Text = "Associa";
            this.buttonAssocia.UseVisualStyleBackColor = true;
            this.buttonAssocia.Click += new System.EventHandler(this.buttonAssocia_Click);
            // 
            // buttonDissocia
            // 
            this.buttonDissocia.Location = new System.Drawing.Point(566, 301);
            this.buttonDissocia.Name = "buttonDissocia";
            this.buttonDissocia.Size = new System.Drawing.Size(94, 29);
            this.buttonDissocia.TabIndex = 1;
            this.buttonDissocia.Text = "Dissocia";
            this.buttonDissocia.UseVisualStyleBackColor = true;
            this.buttonDissocia.Click += new System.EventHandler(this.buttonDissocia_Click);
            // 
            // textBoxProgetto
            // 
            this.textBoxProgetto.Location = new System.Drawing.Point(336, 268);
            this.textBoxProgetto.Name = "textBoxProgetto";
            this.textBoxProgetto.Size = new System.Drawing.Size(324, 27);
            this.textBoxProgetto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inserisci nome progetto";
            // 
            // buttonTermina
            // 
            this.buttonTermina.Location = new System.Drawing.Point(336, 399);
            this.buttonTermina.Name = "buttonTermina";
            this.buttonTermina.Size = new System.Drawing.Size(324, 44);
            this.buttonTermina.TabIndex = 4;
            this.buttonTermina.Text = "Termina";
            this.buttonTermina.UseVisualStyleBackColor = true;
            this.buttonTermina.Click += new System.EventHandler(this.buttonTermina_Click);
            // 
            // ModificaClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 630);
            this.Controls.Add(this.buttonTermina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProgetto);
            this.Controls.Add(this.buttonDissocia);
            this.Controls.Add(this.buttonAssocia);
            this.Name = "ModificaClienteForm";
            this.Text = "AssociaProgettoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAssocia;
        private Button buttonDissocia;
        private TextBox textBoxProgetto;
        private Label label1;
        private Button buttonTermina;
    }
}