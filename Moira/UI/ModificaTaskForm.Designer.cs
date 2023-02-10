namespace Moira.UI
{
    partial class ModificaTaskForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescrizione = new System.Windows.Forms.TextBox();
            this.buttonModifica = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Descrizione:";
            // 
            // textBoxDescrizione
            // 
            this.textBoxDescrizione.Location = new System.Drawing.Point(338, 315);
            this.textBoxDescrizione.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDescrizione.Name = "textBoxDescrizione";
            this.textBoxDescrizione.Size = new System.Drawing.Size(325, 31);
            this.textBoxDescrizione.TabIndex = 14;
            // 
            // buttonModifica
            // 
            this.buttonModifica.Location = new System.Drawing.Point(456, 411);
            this.buttonModifica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(118, 36);
            this.buttonModifica.TabIndex = 13;
            this.buttonModifica.Text = "Modifica";
            this.buttonModifica.UseVisualStyleBackColor = true;
            this.buttonModifica.Click += new System.EventHandler(this.buttonModifica_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(438, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Modifica task";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(338, 224);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(325, 31);
            this.textBoxNome.TabIndex = 10;
            // 
            // ModificaTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDescrizione);
            this.Controls.Add(this.buttonModifica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNome);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModificaTaskForm";
            this.Text = "Modifica Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private TextBox textBoxDescrizione;
        private Button buttonModifica;
        private Label label2;
        private Label label1;
        private TextBox textBoxNome;
    }
}