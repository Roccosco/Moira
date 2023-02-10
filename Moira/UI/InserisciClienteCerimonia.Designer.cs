namespace Moira.UI
{
    partial class InserisciClienteCerimonia
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
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonTermina = new System.Windows.Forms.Button();
            this.dataGridViewClienti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(450, 412);
            this.textBoxCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(154, 31);
            this.textBoxCliente.TabIndex = 0;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(324, 384);
            this.labelCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(400, 25);
            this.labelCliente.TabIndex = 1;
            this.labelCliente.Text = "Inserisci codice cliente da associare alla cerimonia";
            // 
            // buttonCliente
            // 
            this.buttonCliente.Location = new System.Drawing.Point(450, 470);
            this.buttonCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(155, 36);
            this.buttonCliente.TabIndex = 2;
            this.buttonCliente.Text = "Inserisci";
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // buttonTermina
            // 
            this.buttonTermina.Location = new System.Drawing.Point(428, 539);
            this.buttonTermina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTermina.Name = "buttonTermina";
            this.buttonTermina.Size = new System.Drawing.Size(201, 56);
            this.buttonTermina.TabIndex = 3;
            this.buttonTermina.Text = "Termina";
            this.buttonTermina.UseVisualStyleBackColor = true;
            this.buttonTermina.Click += new System.EventHandler(this.buttonTermina_Click);
            // 
            // dataGridViewClienti
            // 
            this.dataGridViewClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClienti.Location = new System.Drawing.Point(191, 65);
            this.dataGridViewClienti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewClienti.Name = "dataGridViewClienti";
            this.dataGridViewClienti.RowHeadersWidth = 51;
            this.dataGridViewClienti.RowTemplate.Height = 29;
            this.dataGridViewClienti.Size = new System.Drawing.Size(755, 250);
            this.dataGridViewClienti.TabIndex = 4;
            // 
            // InserisciClienteCerimonia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 624);
            this.Controls.Add(this.dataGridViewClienti);
            this.Controls.Add(this.buttonTermina);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.textBoxCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InserisciClienteCerimonia";
            this.Text = "Inserisci Cliente Cerimonia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxCliente;
        private Label labelCliente;
        private Button buttonCliente;
        private Button buttonTermina;
        private DataGridView dataGridViewClienti;
    }
}