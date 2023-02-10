namespace Moira.UI
{
    partial class AssociaClienteANuovoProgetto
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
            this.panelAssociaClienti = new System.Windows.Forms.Panel();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.buttonFineClienti = new System.Windows.Forms.Button();
            this.buttonAggiungiCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCodiceCliente = new System.Windows.Forms.TextBox();
            this.panelAssociaClienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAssociaClienti
            // 
            this.panelAssociaClienti.Controls.Add(this.dataGridViewCliente);
            this.panelAssociaClienti.Controls.Add(this.buttonFineClienti);
            this.panelAssociaClienti.Controls.Add(this.buttonAggiungiCliente);
            this.panelAssociaClienti.Controls.Add(this.label5);
            this.panelAssociaClienti.Controls.Add(this.textBoxCodiceCliente);
            this.panelAssociaClienti.Location = new System.Drawing.Point(4, 15);
            this.panelAssociaClienti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAssociaClienti.Name = "panelAssociaClienti";
            this.panelAssociaClienti.Size = new System.Drawing.Size(1176, 689);
            this.panelAssociaClienti.TabIndex = 8;
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Location = new System.Drawing.Point(251, 136);
            this.dataGridViewCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.RowHeadersWidth = 51;
            this.dataGridViewCliente.RowTemplate.Height = 29;
            this.dataGridViewCliente.Size = new System.Drawing.Size(674, 255);
            this.dataGridViewCliente.TabIndex = 4;
            // 
            // buttonFineClienti
            // 
            this.buttonFineClienti.Location = new System.Drawing.Point(405, 585);
            this.buttonFineClienti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFineClienti.Name = "buttonFineClienti";
            this.buttonFineClienti.Size = new System.Drawing.Size(384, 85);
            this.buttonFineClienti.TabIndex = 3;
            this.buttonFineClienti.Text = "Inserisci";
            this.buttonFineClienti.UseVisualStyleBackColor = true;
            this.buttonFineClienti.Click += new System.EventHandler(this.buttonFineClienti_Click);
            // 
            // buttonAggiungiCliente
            // 
            this.buttonAggiungiCliente.Location = new System.Drawing.Point(405, 542);
            this.buttonAggiungiCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAggiungiCliente.Name = "buttonAggiungiCliente";
            this.buttonAggiungiCliente.Size = new System.Drawing.Size(384, 36);
            this.buttonAggiungiCliente.TabIndex = 2;
            this.buttonAggiungiCliente.Text = "Aggiungi";
            this.buttonAggiungiCliente.UseVisualStyleBackColor = true;
            this.buttonAggiungiCliente.Click += new System.EventHandler(this.buttonAggiungiCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 461);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Codice cliente:";
            // 
            // textBoxCodiceCliente
            // 
            this.textBoxCodiceCliente.Location = new System.Drawing.Point(405, 490);
            this.textBoxCodiceCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCodiceCliente.Name = "textBoxCodiceCliente";
            this.textBoxCodiceCliente.Size = new System.Drawing.Size(383, 31);
            this.textBoxCodiceCliente.TabIndex = 0;
            // 
            // AssociaClienteANuovoProgetto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 729);
            this.Controls.Add(this.panelAssociaClienti);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AssociaClienteANuovoProgetto";
            this.Text = "Associa Cliente A Nuovo Progetto";
            this.panelAssociaClienti.ResumeLayout(false);
            this.panelAssociaClienti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelAssociaClienti;
        private Button buttonFineClienti;
        private Button buttonAggiungiCliente;
        private Label label5;
        private TextBox textBoxCodiceCliente;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dataGridViewCliente;
    }
}