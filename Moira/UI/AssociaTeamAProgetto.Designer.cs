namespace Moira.UI
{
    partial class AssociaTeamAProgetto
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
            this.panelAssociaTeam = new System.Windows.Forms.Panel();
            this.dataGridViewTeam = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFineTeam = new System.Windows.Forms.Button();
            this.buttonAggiungiTeam = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCodiceTeam = new System.Windows.Forms.TextBox();
            this.panelAssociaTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAssociaTeam
            // 
            this.panelAssociaTeam.Controls.Add(this.dataGridViewTeam);
            this.panelAssociaTeam.Controls.Add(this.label2);
            this.panelAssociaTeam.Controls.Add(this.buttonFineTeam);
            this.panelAssociaTeam.Controls.Add(this.buttonAggiungiTeam);
            this.panelAssociaTeam.Controls.Add(this.label4);
            this.panelAssociaTeam.Controls.Add(this.textBoxCodiceTeam);
            this.panelAssociaTeam.Location = new System.Drawing.Point(44, 30);
            this.panelAssociaTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAssociaTeam.Name = "panelAssociaTeam";
            this.panelAssociaTeam.Size = new System.Drawing.Size(1176, 689);
            this.panelAssociaTeam.TabIndex = 7;
            // 
            // dataGridViewTeam
            // 
            this.dataGridViewTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeam.Location = new System.Drawing.Point(214, 59);
            this.dataGridViewTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewTeam.Name = "dataGridViewTeam";
            this.dataGridViewTeam.RowHeadersWidth = 51;
            this.dataGridViewTeam.RowTemplate.Height = 29;
            this.dataGridViewTeam.Size = new System.Drawing.Size(741, 375);
            this.dataGridViewTeam.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(468, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Associa team a progetto";
            // 
            // buttonFineTeam
            // 
            this.buttonFineTeam.Enabled = false;
            this.buttonFineTeam.Location = new System.Drawing.Point(404, 569);
            this.buttonFineTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFineTeam.Name = "buttonFineTeam";
            this.buttonFineTeam.Size = new System.Drawing.Size(384, 85);
            this.buttonFineTeam.TabIndex = 3;
            this.buttonFineTeam.Text = "Avanti";
            this.buttonFineTeam.UseVisualStyleBackColor = true;
            this.buttonFineTeam.Click += new System.EventHandler(this.buttonFineTeam_Click);
            // 
            // buttonAggiungiTeam
            // 
            this.buttonAggiungiTeam.Location = new System.Drawing.Point(404, 519);
            this.buttonAggiungiTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAggiungiTeam.Name = "buttonAggiungiTeam";
            this.buttonAggiungiTeam.Size = new System.Drawing.Size(384, 36);
            this.buttonAggiungiTeam.TabIndex = 2;
            this.buttonAggiungiTeam.Text = "Aggiungi";
            this.buttonAggiungiTeam.UseVisualStyleBackColor = true;
            this.buttonAggiungiTeam.Click += new System.EventHandler(this.buttonAggiungiTeam_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 438);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Codice team:";
            // 
            // textBoxCodiceTeam
            // 
            this.textBoxCodiceTeam.Location = new System.Drawing.Point(404, 466);
            this.textBoxCodiceTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCodiceTeam.Name = "textBoxCodiceTeam";
            this.textBoxCodiceTeam.Size = new System.Drawing.Size(383, 31);
            this.textBoxCodiceTeam.TabIndex = 0;
            // 
            // AssociaTeamAProgetto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 734);
            this.Controls.Add(this.panelAssociaTeam);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AssociaTeamAProgetto";
            this.Text = "Associa Team A Progetto";
            this.panelAssociaTeam.ResumeLayout(false);
            this.panelAssociaTeam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelAssociaTeam;
        private Button buttonFineTeam;
        private Button buttonAggiungiTeam;
        private Label label4;
        private TextBox textBoxCodiceTeam;
        private Label label2;
        private DataGridView dataGridViewTeam;
    }
}