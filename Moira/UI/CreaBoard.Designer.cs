namespace Moira.UI
{
    partial class CreaBoard
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
            this.buttonNomeBoard = new System.Windows.Forms.Button();
            this.textBoxNomeBoard = new System.Windows.Forms.TextBox();
            this.labelNomeBoard = new System.Windows.Forms.Label();
            this.textBoxTeamBoard = new System.Windows.Forms.TextBox();
            this.labelTeamBoard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNomeBoard
            // 
            this.buttonNomeBoard.Location = new System.Drawing.Point(238, 264);
            this.buttonNomeBoard.Name = "buttonNomeBoard";
            this.buttonNomeBoard.Size = new System.Drawing.Size(291, 29);
            this.buttonNomeBoard.TabIndex = 1;
            this.buttonNomeBoard.Text = "inserisci";
            this.buttonNomeBoard.UseVisualStyleBackColor = true;
            this.buttonNomeBoard.Click += new System.EventHandler(this.buttonNomeBoard_Click);
            // 
            // textBoxNomeBoard
            // 
            this.textBoxNomeBoard.Location = new System.Drawing.Point(238, 110);
            this.textBoxNomeBoard.Name = "textBoxNomeBoard";
            this.textBoxNomeBoard.Size = new System.Drawing.Size(291, 27);
            this.textBoxNomeBoard.TabIndex = 2;
            // 
            // labelNomeBoard
            // 
            this.labelNomeBoard.AutoSize = true;
            this.labelNomeBoard.Location = new System.Drawing.Point(315, 87);
            this.labelNomeBoard.Name = "labelNomeBoard";
            this.labelNomeBoard.Size = new System.Drawing.Size(147, 20);
            this.labelNomeBoard.TabIndex = 3;
            this.labelNomeBoard.Text = "Inserisci nome board";
            // 
            // textBoxTeamBoard
            // 
            this.textBoxTeamBoard.Location = new System.Drawing.Point(238, 175);
            this.textBoxTeamBoard.Name = "textBoxTeamBoard";
            this.textBoxTeamBoard.Size = new System.Drawing.Size(291, 27);
            this.textBoxTeamBoard.TabIndex = 4;
            // 
            // labelTeamBoard
            // 
            this.labelTeamBoard.AutoSize = true;
            this.labelTeamBoard.Location = new System.Drawing.Point(238, 152);
            this.labelTeamBoard.Name = "labelTeamBoard";
            this.labelTeamBoard.Size = new System.Drawing.Size(291, 20);
            this.labelTeamBoard.TabIndex = 5;
            this.labelTeamBoard.Text = "inserisci codice team a cui associare board";
            // 
            // CreasBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTeamBoard);
            this.Controls.Add(this.textBoxTeamBoard);
            this.Controls.Add(this.labelNomeBoard);
            this.Controls.Add(this.textBoxNomeBoard);
            this.Controls.Add(this.buttonNomeBoard);
            this.Name = "CreasBoard";
            this.Text = "CreasBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonNomeBoard;
        private TextBox textBoxNomeBoard;
        private Label labelNomeBoard;
        private TextBox textBoxTeamBoard;
        private Label labelTeamBoard;
    }
}