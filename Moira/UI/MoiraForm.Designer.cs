﻿namespace Moira.UI
{
    partial class MoiraForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInserisciProgetti = new System.Windows.Forms.Button();
            this.buttonGestisciBacklog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(400, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moira";
            // 
            // buttonInserisciProgetti
            // 
            this.buttonInserisciProgetti.Location = new System.Drawing.Point(336, 139);
            this.buttonInserisciProgetti.Name = "buttonInserisciProgetti";
            this.buttonInserisciProgetti.Size = new System.Drawing.Size(212, 44);
            this.buttonInserisciProgetti.TabIndex = 1;
            this.buttonInserisciProgetti.Text = "Inserisci nuovo progetto";
            this.buttonInserisciProgetti.UseVisualStyleBackColor = true;
            this.buttonInserisciProgetti.Click += new System.EventHandler(this.buttonInserisciProgetti_Click);
            // 
            // buttonGestisciBacklog
            // 
            this.buttonGestisciBacklog.Location = new System.Drawing.Point(336, 224);
            this.buttonGestisciBacklog.Name = "buttonGestisciBacklog";
            this.buttonGestisciBacklog.Size = new System.Drawing.Size(212, 44);
            this.buttonGestisciBacklog.TabIndex = 2;
            this.buttonGestisciBacklog.Text = "Gestisci backlog";
            this.buttonGestisciBacklog.UseVisualStyleBackColor = true;
            this.buttonGestisciBacklog.Click += new System.EventHandler(this.buttonGestisciBacklog_Click);
            // 
            // MoiraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 638);
            this.Controls.Add(this.buttonGestisciBacklog);
            this.Controls.Add(this.buttonInserisciProgetti);
            this.Controls.Add(this.label1);
            this.Name = "MoiraForm";
            this.Text = "Moira";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button buttonInserisciProgetti;
        private Button buttonGestisciBacklog;
    }
}