namespace Moira.UI
{
    partial class ModificaTeam
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
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.buttonElimina = new System.Windows.Forms.Button();
            this.textBoxAggiungi = new System.Windows.Forms.TextBox();
            this.textBoxElimina = new System.Windows.Forms.TextBox();
            this.labelElimina = new System.Windows.Forms.Label();
            this.labelAggiungi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Location = new System.Drawing.Point(365, 247);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(125, 29);
            this.buttonAggiungi.TabIndex = 0;
            this.buttonAggiungi.Text = "Aggiungi";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click);
            // 
            // buttonElimina
            // 
            this.buttonElimina.Location = new System.Drawing.Point(365, 123);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(125, 29);
            this.buttonElimina.TabIndex = 1;
            this.buttonElimina.Text = "Elimina";
            this.buttonElimina.UseVisualStyleBackColor = true;
            this.buttonElimina.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // textBoxAggiungi
            // 
            this.textBoxAggiungi.Location = new System.Drawing.Point(301, 214);
            this.textBoxAggiungi.Name = "textBoxAggiungi";
            this.textBoxAggiungi.Size = new System.Drawing.Size(255, 27);
            this.textBoxAggiungi.TabIndex = 2;
            // 
            // textBoxElimina
            // 
            this.textBoxElimina.Location = new System.Drawing.Point(301, 90);
            this.textBoxElimina.Name = "textBoxElimina";
            this.textBoxElimina.Size = new System.Drawing.Size(255, 27);
            this.textBoxElimina.TabIndex = 3;
            // 
            // labelElimina
            // 
            this.labelElimina.AutoSize = true;
            this.labelElimina.Location = new System.Drawing.Point(368, 67);
            this.labelElimina.Name = "labelElimina";
            this.labelElimina.Size = new System.Drawing.Size(131, 20);
            this.labelElimina.TabIndex = 4;
            this.labelElimina.Text = "Elimina impiegato";
            // 
            // labelAggiungi
            // 
            this.labelAggiungi.AutoSize = true;
            this.labelAggiungi.Location = new System.Drawing.Point(356, 191);
            this.labelAggiungi.Name = "labelAggiungi";
            this.labelAggiungi.Size = new System.Drawing.Size(143, 20);
            this.labelAggiungi.TabIndex = 5;
            this.labelAggiungi.Text = "Aggiungi impiegato";
            // 
            // ModificaTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 406);
            this.Controls.Add(this.labelAggiungi);
            this.Controls.Add(this.labelElimina);
            this.Controls.Add(this.textBoxElimina);
            this.Controls.Add(this.textBoxAggiungi);
            this.Controls.Add(this.buttonElimina);
            this.Controls.Add(this.buttonAggiungi);
            this.Name = "ModificaTeam";
            this.Text = "ModificaTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAggiungi;
        private Button buttonElimina;
        private TextBox textBoxAggiungi;
        private TextBox textBoxElimina;
        private Label labelElimina;
        private Label labelAggiungi;
    }
}