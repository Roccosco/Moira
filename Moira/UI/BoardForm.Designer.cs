namespace Moira.UI
{
    partial class BoardForm
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
            this.panelBoard = new System.Windows.Forms.Panel();
            this.panelCancella = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCancella.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBoard
            // 
            this.panelBoard.AutoScroll = true;
            this.panelBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBoard.Location = new System.Drawing.Point(77, 62);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(1214, 717);
            this.panelBoard.TabIndex = 0;
            // 
            // panelCancella
            // 
            this.panelCancella.AllowDrop = true;
            this.panelCancella.Controls.Add(this.label1);
            this.panelCancella.Location = new System.Drawing.Point(554, 785);
            this.panelCancella.Name = "panelCancella";
            this.panelCancella.Size = new System.Drawing.Size(352, 40);
            this.panelCancella.TabIndex = 1;
            this.panelCancella.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCancella_DragDrop);
            this.panelCancella.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCancella_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sposta il task qui per indicarlo come completato";
            // 
            // BoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 839);
            this.Controls.Add(this.panelCancella);
            this.Controls.Add(this.panelBoard);
            this.Name = "BoardForm";
            this.Text = "BoardForm";
            this.panelCancella.ResumeLayout(false);
            this.panelCancella.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelBoard;
        private Panel panelCancella;
        private Label label1;
    }
}