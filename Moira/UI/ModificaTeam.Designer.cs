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
            this.buttonTermina = new System.Windows.Forms.Button();
            this.dataGridViewImpiegati = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImpiegati)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Location = new System.Drawing.Point(367, 459);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(125, 29);
            this.buttonAggiungi.TabIndex = 0;
            this.buttonAggiungi.Text = "Aggiungi";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click);
            // 
            // buttonElimina
            // 
            this.buttonElimina.Location = new System.Drawing.Point(367, 358);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(125, 29);
            this.buttonElimina.TabIndex = 1;
            this.buttonElimina.Text = "Elimina";
            this.buttonElimina.UseVisualStyleBackColor = true;
            this.buttonElimina.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // textBoxAggiungi
            // 
            this.textBoxAggiungi.Location = new System.Drawing.Point(303, 426);
            this.textBoxAggiungi.Name = "textBoxAggiungi";
            this.textBoxAggiungi.Size = new System.Drawing.Size(255, 27);
            this.textBoxAggiungi.TabIndex = 2;
            // 
            // textBoxElimina
            // 
            this.textBoxElimina.Location = new System.Drawing.Point(303, 325);
            this.textBoxElimina.Name = "textBoxElimina";
            this.textBoxElimina.Size = new System.Drawing.Size(255, 27);
            this.textBoxElimina.TabIndex = 3;
            // 
            // labelElimina
            // 
            this.labelElimina.AutoSize = true;
            this.labelElimina.Location = new System.Drawing.Point(370, 302);
            this.labelElimina.Name = "labelElimina";
            this.labelElimina.Size = new System.Drawing.Size(131, 20);
            this.labelElimina.TabIndex = 4;
            this.labelElimina.Text = "Elimina impiegato";
            // 
            // labelAggiungi
            // 
            this.labelAggiungi.AutoSize = true;
            this.labelAggiungi.Location = new System.Drawing.Point(358, 403);
            this.labelAggiungi.Name = "labelAggiungi";
            this.labelAggiungi.Size = new System.Drawing.Size(143, 20);
            this.labelAggiungi.TabIndex = 5;
            this.labelAggiungi.Text = "Aggiungi impiegato";
            // 
            // buttonTermina
            // 
            this.buttonTermina.Location = new System.Drawing.Point(303, 507);
            this.buttonTermina.Name = "buttonTermina";
            this.buttonTermina.Size = new System.Drawing.Size(255, 37);
            this.buttonTermina.TabIndex = 6;
            this.buttonTermina.Text = "Termina";
            this.buttonTermina.UseVisualStyleBackColor = true;
            this.buttonTermina.Click += new System.EventHandler(this.buttonTermina_Click);
            // 
            // dataGridViewImpiegati
            // 
            this.dataGridViewImpiegati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImpiegati.Location = new System.Drawing.Point(105, 72);
            this.dataGridViewImpiegati.Name = "dataGridViewImpiegati";
            this.dataGridViewImpiegati.RowHeadersWidth = 51;
            this.dataGridViewImpiegati.RowTemplate.Height = 29;
            this.dataGridViewImpiegati.Size = new System.Drawing.Size(671, 188);
            this.dataGridViewImpiegati.TabIndex = 7;
            // 
            // ModificaTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 577);
            this.Controls.Add(this.dataGridViewImpiegati);
            this.Controls.Add(this.buttonTermina);
            this.Controls.Add(this.labelAggiungi);
            this.Controls.Add(this.labelElimina);
            this.Controls.Add(this.textBoxElimina);
            this.Controls.Add(this.textBoxAggiungi);
            this.Controls.Add(this.buttonElimina);
            this.Controls.Add(this.buttonAggiungi);
            this.Name = "ModificaTeam";
            this.Text = "ModificaTeam";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImpiegati)).EndInit();
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
        private Button buttonTermina;
        private DataGridView dataGridViewImpiegati;
    }
}