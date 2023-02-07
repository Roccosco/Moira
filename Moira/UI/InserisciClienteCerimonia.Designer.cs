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
            this.SuspendLayout();
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(358, 183);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(124, 27);
            this.textBoxCliente.TabIndex = 0;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(256, 149);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(341, 20);
            this.labelCliente.TabIndex = 1;
            this.labelCliente.Text = "Inserisci codice cliente da associare alla cerimonia";
            // 
            // buttonCliente
            // 
            this.buttonCliente.Location = new System.Drawing.Point(358, 249);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(124, 29);
            this.buttonCliente.TabIndex = 2;
            this.buttonCliente.Text = "Inserisci";
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // buttonTermina
            // 
            this.buttonTermina.Location = new System.Drawing.Point(340, 304);
            this.buttonTermina.Name = "buttonTermina";
            this.buttonTermina.Size = new System.Drawing.Size(161, 45);
            this.buttonTermina.TabIndex = 3;
            this.buttonTermina.Text = "Termina";
            this.buttonTermina.UseVisualStyleBackColor = true;
            this.buttonTermina.Click += new System.EventHandler(this.buttonTermina_Click);
            // 
            // InserisciClienteCerimonia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 499);
            this.Controls.Add(this.buttonTermina);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.textBoxCliente);
            this.Name = "InserisciClienteCerimonia";
            this.Text = "InserisciClienteCerimonia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxCliente;
        private Label labelCliente;
        private Button buttonCliente;
        private Button buttonTermina;
    }
}