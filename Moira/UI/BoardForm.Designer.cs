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
            this.panelBoard.Location = new System.Drawing.Point(96, 78);
            this.panelBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(1516, 895);
            this.panelBoard.TabIndex = 0;
            // 
            // panelCancella
            // 
            this.panelCancella.AllowDrop = true;
            this.panelCancella.Controls.Add(this.label1);
            this.panelCancella.Location = new System.Drawing.Point(692, 981);
            this.panelCancella.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCancella.Name = "panelCancella";
            this.panelCancella.Size = new System.Drawing.Size(440, 50);
            this.panelCancella.TabIndex = 1;
            this.panelCancella.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCancella_DragDrop);
            this.panelCancella.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCancella_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sposta il task qui per indicarlo come completato";
            // 
            // BoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1729, 1049);
            this.Controls.Add(this.panelCancella);
            this.Controls.Add(this.panelBoard);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BoardForm";
            this.Text = "Visualizza Board";
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