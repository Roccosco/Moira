namespace Moira.UI
{
    partial class AssociaClienteAProgetto
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
            this.textBoxAssocia = new System.Windows.Forms.TextBox();
            this.labelAssocia = new System.Windows.Forms.Label();
            this.buttonTermina = new System.Windows.Forms.Button();
            this.dataGridViewProgetti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgetti)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAssocia
            // 
            this.buttonAssocia.Location = new System.Drawing.Point(381, 350);
            this.buttonAssocia.Name = "buttonAssocia";
            this.buttonAssocia.Size = new System.Drawing.Size(94, 29);
            this.buttonAssocia.TabIndex = 0;
            this.buttonAssocia.Text = "Associa";
            this.buttonAssocia.UseVisualStyleBackColor = true;
            this.buttonAssocia.Click += new System.EventHandler(this.buttonAssocia_Click);
            // 
            // textBoxAssocia
            // 
            this.textBoxAssocia.Location = new System.Drawing.Point(271, 307);
            this.textBoxAssocia.Name = "textBoxAssocia";
            this.textBoxAssocia.Size = new System.Drawing.Size(326, 27);
            this.textBoxAssocia.TabIndex = 1;
            // 
            // labelAssocia
            // 
            this.labelAssocia.AutoSize = true;
            this.labelAssocia.Location = new System.Drawing.Point(271, 275);
            this.labelAssocia.Name = "labelAssocia";
            this.labelAssocia.Size = new System.Drawing.Size(326, 20);
            this.labelAssocia.TabIndex = 2;
            this.labelAssocia.Text = "Inserisci nome progetto a cui associare il cliente";
            // 
            // buttonTermina
            // 
            this.buttonTermina.Location = new System.Drawing.Point(271, 394);
            this.buttonTermina.Name = "buttonTermina";
            this.buttonTermina.Size = new System.Drawing.Size(326, 52);
            this.buttonTermina.TabIndex = 3;
            this.buttonTermina.Text = "Termina";
            this.buttonTermina.UseVisualStyleBackColor = true;
            this.buttonTermina.Click += new System.EventHandler(this.buttonTermina_Click);
            // 
            // dataGridViewProgetti
            // 
            this.dataGridViewProgetti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProgetti.Location = new System.Drawing.Point(107, 50);
            this.dataGridViewProgetti.Name = "dataGridViewProgetti";
            this.dataGridViewProgetti.RowHeadersWidth = 51;
            this.dataGridViewProgetti.RowTemplate.Height = 29;
            this.dataGridViewProgetti.Size = new System.Drawing.Size(667, 195);
            this.dataGridViewProgetti.TabIndex = 4;
            // 
            // AssociaClienteAProgetto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 472);
            this.Controls.Add(this.dataGridViewProgetti);
            this.Controls.Add(this.buttonTermina);
            this.Controls.Add(this.labelAssocia);
            this.Controls.Add(this.textBoxAssocia);
            this.Controls.Add(this.buttonAssocia);
            this.Name = "AssociaClienteAProgetto";
            this.Text = "AssociaClienteAProgetto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgetti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAssocia;
        private TextBox textBoxAssocia;
        private Label labelAssocia;
        private Button buttonTermina;
        private DataGridView dataGridViewProgetti;
    }
}