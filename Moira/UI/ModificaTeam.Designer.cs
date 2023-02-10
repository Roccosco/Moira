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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewImpiegatiTeam = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImpiegati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImpiegatiTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Location = new System.Drawing.Point(459, 574);
            this.buttonAggiungi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(156, 36);
            this.buttonAggiungi.TabIndex = 0;
            this.buttonAggiungi.Text = "Aggiungi";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click);
            // 
            // buttonElimina
            // 
            this.buttonElimina.Location = new System.Drawing.Point(459, 448);
            this.buttonElimina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(156, 36);
            this.buttonElimina.TabIndex = 1;
            this.buttonElimina.Text = "Elimina";
            this.buttonElimina.UseVisualStyleBackColor = true;
            this.buttonElimina.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // textBoxAggiungi
            // 
            this.textBoxAggiungi.Location = new System.Drawing.Point(379, 532);
            this.textBoxAggiungi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAggiungi.Name = "textBoxAggiungi";
            this.textBoxAggiungi.Size = new System.Drawing.Size(318, 31);
            this.textBoxAggiungi.TabIndex = 2;
            // 
            // textBoxElimina
            // 
            this.textBoxElimina.Location = new System.Drawing.Point(379, 406);
            this.textBoxElimina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxElimina.Name = "textBoxElimina";
            this.textBoxElimina.Size = new System.Drawing.Size(318, 31);
            this.textBoxElimina.TabIndex = 3;
            // 
            // labelElimina
            // 
            this.labelElimina.AutoSize = true;
            this.labelElimina.Location = new System.Drawing.Point(462, 378);
            this.labelElimina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelElimina.Name = "labelElimina";
            this.labelElimina.Size = new System.Drawing.Size(154, 25);
            this.labelElimina.TabIndex = 4;
            this.labelElimina.Text = "Elimina impiegato";
            // 
            // labelAggiungi
            // 
            this.labelAggiungi.AutoSize = true;
            this.labelAggiungi.Location = new System.Drawing.Point(448, 504);
            this.labelAggiungi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAggiungi.Name = "labelAggiungi";
            this.labelAggiungi.Size = new System.Drawing.Size(171, 25);
            this.labelAggiungi.TabIndex = 5;
            this.labelAggiungi.Text = "Aggiungi impiegato";
            // 
            // buttonTermina
            // 
            this.buttonTermina.Location = new System.Drawing.Point(379, 634);
            this.buttonTermina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTermina.Name = "buttonTermina";
            this.buttonTermina.Size = new System.Drawing.Size(319, 46);
            this.buttonTermina.TabIndex = 6;
            this.buttonTermina.Text = "Termina";
            this.buttonTermina.UseVisualStyleBackColor = true;
            this.buttonTermina.Click += new System.EventHandler(this.buttonTermina_Click);
            // 
            // dataGridViewImpiegati
            // 
            this.dataGridViewImpiegati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImpiegati.Location = new System.Drawing.Point(554, 92);
            this.dataGridViewImpiegati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewImpiegati.Name = "dataGridViewImpiegati";
            this.dataGridViewImpiegati.RowHeadersWidth = 51;
            this.dataGridViewImpiegati.RowTemplate.Height = 29;
            this.dataGridViewImpiegati.Size = new System.Drawing.Size(511, 259);
            this.dataGridViewImpiegati.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(764, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "IMPIEGATI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "IMPIEGATI NEL TEAM:";
            // 
            // dataGridViewImpiegatiTeam
            // 
            this.dataGridViewImpiegatiTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImpiegatiTeam.Location = new System.Drawing.Point(15, 92);
            this.dataGridViewImpiegatiTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewImpiegatiTeam.Name = "dataGridViewImpiegatiTeam";
            this.dataGridViewImpiegatiTeam.RowHeadersWidth = 51;
            this.dataGridViewImpiegatiTeam.RowTemplate.Height = 29;
            this.dataGridViewImpiegatiTeam.Size = new System.Drawing.Size(531, 259);
            this.dataGridViewImpiegatiTeam.TabIndex = 9;
            // 
            // ModificaTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 721);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewImpiegatiTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewImpiegati);
            this.Controls.Add(this.buttonTermina);
            this.Controls.Add(this.labelAggiungi);
            this.Controls.Add(this.labelElimina);
            this.Controls.Add(this.textBoxElimina);
            this.Controls.Add(this.textBoxAggiungi);
            this.Controls.Add(this.buttonElimina);
            this.Controls.Add(this.buttonAggiungi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModificaTeam";
            this.Text = "Modifica Team";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImpiegati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImpiegatiTeam)).EndInit();
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
        private Label label1;
        private Label label2;
        private DataGridView dataGridViewImpiegatiTeam;
    }
}