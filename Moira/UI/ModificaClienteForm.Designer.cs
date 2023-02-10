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
            this.buttonAssocia.Location = new System.Drawing.Point(420, 376);
            this.buttonAssocia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAssocia.Name = "buttonAssocia";
            this.buttonAssocia.Size = new System.Drawing.Size(118, 36);
            this.buttonAssocia.TabIndex = 0;
            this.buttonAssocia.Text = "Associa";
            this.buttonAssocia.UseVisualStyleBackColor = true;
            this.buttonAssocia.Click += new System.EventHandler(this.buttonAssocia_Click);
            // 
            // buttonDissocia
            // 
            this.buttonDissocia.Location = new System.Drawing.Point(708, 376);
            this.buttonDissocia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDissocia.Name = "buttonDissocia";
            this.buttonDissocia.Size = new System.Drawing.Size(118, 36);
            this.buttonDissocia.TabIndex = 1;
            this.buttonDissocia.Text = "Dissocia";
            this.buttonDissocia.UseVisualStyleBackColor = true;
            this.buttonDissocia.Click += new System.EventHandler(this.buttonDissocia_Click);
            // 
            // textBoxProgetto
            // 
            this.textBoxProgetto.Location = new System.Drawing.Point(420, 335);
            this.textBoxProgetto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxProgetto.Name = "textBoxProgetto";
            this.textBoxProgetto.Size = new System.Drawing.Size(404, 31);
            this.textBoxProgetto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 306);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inserisci nome progetto";
            // 
            // buttonTermina
            // 
            this.buttonTermina.Location = new System.Drawing.Point(420, 499);
            this.buttonTermina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTermina.Name = "buttonTermina";
            this.buttonTermina.Size = new System.Drawing.Size(405, 55);
            this.buttonTermina.TabIndex = 4;
            this.buttonTermina.Text = "Termina";
            this.buttonTermina.UseVisualStyleBackColor = true;
            this.buttonTermina.Click += new System.EventHandler(this.buttonTermina_Click);
            // 
            // ModificaClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 788);
            this.Controls.Add(this.buttonTermina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProgetto);
            this.Controls.Add(this.buttonDissocia);
            this.Controls.Add(this.buttonAssocia);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModificaClienteForm";
            this.Text = "Associa Progetto";
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