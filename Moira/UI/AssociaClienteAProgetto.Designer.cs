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
            this.buttonAssocia.Location = new System.Drawing.Point(476, 438);
            this.buttonAssocia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAssocia.Name = "buttonAssocia";
            this.buttonAssocia.Size = new System.Drawing.Size(118, 36);
            this.buttonAssocia.TabIndex = 0;
            this.buttonAssocia.Text = "Associa";
            this.buttonAssocia.UseVisualStyleBackColor = true;
            this.buttonAssocia.Click += new System.EventHandler(this.buttonAssocia_Click);
            // 
            // textBoxAssocia
            // 
            this.textBoxAssocia.Location = new System.Drawing.Point(339, 384);
            this.textBoxAssocia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAssocia.Name = "textBoxAssocia";
            this.textBoxAssocia.Size = new System.Drawing.Size(406, 31);
            this.textBoxAssocia.TabIndex = 1;
            // 
            // labelAssocia
            // 
            this.labelAssocia.AutoSize = true;
            this.labelAssocia.Location = new System.Drawing.Point(339, 344);
            this.labelAssocia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAssocia.Name = "labelAssocia";
            this.labelAssocia.Size = new System.Drawing.Size(387, 25);
            this.labelAssocia.TabIndex = 2;
            this.labelAssocia.Text = "Inserisci nome progetto a cui associare il cliente";
            // 
            // buttonTermina
            // 
            this.buttonTermina.Location = new System.Drawing.Point(339, 492);
            this.buttonTermina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTermina.Name = "buttonTermina";
            this.buttonTermina.Size = new System.Drawing.Size(408, 65);
            this.buttonTermina.TabIndex = 3;
            this.buttonTermina.Text = "Termina";
            this.buttonTermina.UseVisualStyleBackColor = true;
            this.buttonTermina.Click += new System.EventHandler(this.buttonTermina_Click);
            // 
            // dataGridViewProgetti
            // 
            this.dataGridViewProgetti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProgetti.Location = new System.Drawing.Point(134, 62);
            this.dataGridViewProgetti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewProgetti.Name = "dataGridViewProgetti";
            this.dataGridViewProgetti.RowHeadersWidth = 51;
            this.dataGridViewProgetti.RowTemplate.Height = 29;
            this.dataGridViewProgetti.Size = new System.Drawing.Size(834, 244);
            this.dataGridViewProgetti.TabIndex = 4;
            // 
            // AssociaClienteAProgetto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 590);
            this.Controls.Add(this.dataGridViewProgetti);
            this.Controls.Add(this.buttonTermina);
            this.Controls.Add(this.labelAssocia);
            this.Controls.Add(this.textBoxAssocia);
            this.Controls.Add(this.buttonAssocia);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AssociaClienteAProgetto";
            this.Text = "Associa Cliente A Progetto";
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