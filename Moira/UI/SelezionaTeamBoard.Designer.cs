namespace Moira.UI
{
    partial class SelezionaTeamBoard
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
            this.buttonAvanti = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodice = new System.Windows.Forms.TextBox();
            this.dataGridViewTeams = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAvanti
            // 
            this.buttonAvanti.Location = new System.Drawing.Point(449, 528);
            this.buttonAvanti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAvanti.Name = "buttonAvanti";
            this.buttonAvanti.Size = new System.Drawing.Size(118, 36);
            this.buttonAvanti.TabIndex = 11;
            this.buttonAvanti.Text = "Avanti";
            this.buttonAvanti.UseVisualStyleBackColor = true;
            this.buttonAvanti.Click += new System.EventHandler(this.buttonAvanti_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 458);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Codice team:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(418, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seleziona Team";
            // 
            // textBoxCodice
            // 
            this.textBoxCodice.Location = new System.Drawing.Point(348, 486);
            this.textBoxCodice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCodice.Name = "textBoxCodice";
            this.textBoxCodice.Size = new System.Drawing.Size(325, 31);
            this.textBoxCodice.TabIndex = 8;
            // 
            // dataGridViewTeams
            // 
            this.dataGridViewTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeams.Location = new System.Drawing.Point(170, 136);
            this.dataGridViewTeams.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewTeams.Name = "dataGridViewTeams";
            this.dataGridViewTeams.RowHeadersWidth = 51;
            this.dataGridViewTeams.RowTemplate.Height = 29;
            this.dataGridViewTeams.Size = new System.Drawing.Size(692, 235);
            this.dataGridViewTeams.TabIndex = 12;
            // 
            // SelezionaTeamBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 621);
            this.Controls.Add(this.dataGridViewTeams);
            this.Controls.Add(this.buttonAvanti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodice);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SelezionaTeamBoard";
            this.Text = "Seleziona Board Team";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAvanti;
        private Label label2;
        private Label label1;
        private TextBox textBoxCodice;
        private DataGridView dataGridViewTeams;
    }
}