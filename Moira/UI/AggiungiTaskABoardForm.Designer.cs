﻿namespace Moira.UI
{
    partial class AggiungiTaskABoardForm
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
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonContinua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(296, 107);
            this.textBoxTask.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(179, 27);
            this.textBoxTask.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codice identificativo task da aggiungere";
            // 
            // buttonContinua
            // 
            this.buttonContinua.Location = new System.Drawing.Point(296, 189);
            this.buttonContinua.Name = "buttonContinua";
            this.buttonContinua.Size = new System.Drawing.Size(179, 31);
            this.buttonContinua.TabIndex = 6;
            this.buttonContinua.Text = "Continua";
            this.buttonContinua.UseVisualStyleBackColor = true;
            this.buttonContinua.Click += new System.EventHandler(this.buttonContinua_Click);
            // 
            // AggiungiTaskABoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonContinua);
            this.Controls.Add(this.textBoxTask);
            this.Controls.Add(this.label1);
            this.Name = "AggiungiTaskABoardForm";
            this.Text = "AggiungiTaskABoardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxTask;
        private Label label1;
        private Button buttonContinua;
    }
}