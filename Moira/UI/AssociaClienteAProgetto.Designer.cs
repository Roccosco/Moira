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
            this.SuspendLayout();
            // 
            // buttonAssocia
            // 
            this.buttonAssocia.Location = new System.Drawing.Point(377, 233);
            this.buttonAssocia.Name = "buttonAssocia";
            this.buttonAssocia.Size = new System.Drawing.Size(94, 29);
            this.buttonAssocia.TabIndex = 0;
            this.buttonAssocia.Text = "Associa";
            this.buttonAssocia.UseVisualStyleBackColor = true;
            this.buttonAssocia.Click += new System.EventHandler(this.buttonAssocia_Click);
            // 
            // textBoxAssocia
            // 
            this.textBoxAssocia.Location = new System.Drawing.Point(267, 190);
            this.textBoxAssocia.Name = "textBoxAssocia";
            this.textBoxAssocia.Size = new System.Drawing.Size(326, 27);
            this.textBoxAssocia.TabIndex = 1;
            // 
            // labelAssocia
            // 
            this.labelAssocia.AutoSize = true;
            this.labelAssocia.Location = new System.Drawing.Point(267, 158);
            this.labelAssocia.Name = "labelAssocia";
            this.labelAssocia.Size = new System.Drawing.Size(326, 20);
            this.labelAssocia.TabIndex = 2;
            this.labelAssocia.Text = "Inserisci nome progetto a cui associare il cliente";
            // 
            // AssociaClienteAProgetto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAssocia);
            this.Controls.Add(this.textBoxAssocia);
            this.Controls.Add(this.buttonAssocia);
            this.Name = "AssociaClienteAProgetto";
            this.Text = "AssociaClienteAProgetto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAssocia;
        private TextBox textBoxAssocia;
        private Label labelAssocia;
    }
}