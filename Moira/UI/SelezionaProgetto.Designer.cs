﻿namespace Moira.UI
{
    partial class SelezionaProgetto
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAvanti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBoxNome.Location = new System.Drawing.Point(286, 193);
            this.textBoxNome.Name = "textBox1";
            this.textBoxNome.Size = new System.Drawing.Size(261, 27);
            this.textBoxNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(338, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleziona progetto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // buttonAvanti
            // 
            this.buttonAvanti.Location = new System.Drawing.Point(377, 292);
            this.buttonAvanti.Name = "buttonAvanti";
            this.buttonAvanti.Size = new System.Drawing.Size(94, 29);
            this.buttonAvanti.TabIndex = 3;
            this.buttonAvanti.Text = "Avanti";
            this.buttonAvanti.UseVisualStyleBackColor = true;
            this.buttonAvanti.Click += new System.EventHandler(this.buttonAvanti_Click);
            // 
            // SelezionaProgetto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 535);
            this.Controls.Add(this.buttonAvanti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNome);
            this.Name = "SelezionaProgetto";
            this.Text = "Seleziona progetto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNome;
        private Label label1;
        private Label label2;
        private Button buttonAvanti;
    }
}