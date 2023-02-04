namespace Moira.UI
{
    partial class TeamSprintForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonTeam = new System.Windows.Forms.Button();
            this.textBoxTeam = new System.Windows.Forms.TextBox();
            this.buttonNuovoSprint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleziona team";
            // 
            // buttonTeam
            // 
            this.buttonTeam.Location = new System.Drawing.Point(405, 100);
            this.buttonTeam.Name = "buttonTeam";
            this.buttonTeam.Size = new System.Drawing.Size(223, 37);
            this.buttonTeam.TabIndex = 2;
            this.buttonTeam.Text = "Seleziona";
            this.buttonTeam.UseVisualStyleBackColor = true;
            this.buttonTeam.Click += new System.EventHandler(this.buttonTeam_Click);
            // 
            // textBoxTeam
            // 
            this.textBoxTeam.Location = new System.Drawing.Point(405, 46);
            this.textBoxTeam.Name = "textBoxTeam";
            this.textBoxTeam.Size = new System.Drawing.Size(223, 31);
            this.textBoxTeam.TabIndex = 1;
            // 
            // buttonNuovoSprint
            // 
            this.buttonNuovoSprint.Enabled = false;
            this.buttonNuovoSprint.Location = new System.Drawing.Point(344, 610);
            this.buttonNuovoSprint.Name = "buttonNuovoSprint";
            this.buttonNuovoSprint.Size = new System.Drawing.Size(361, 60);
            this.buttonNuovoSprint.TabIndex = 3;
            this.buttonNuovoSprint.Text = "Avvia nuovo sprint";
            this.buttonNuovoSprint.UseVisualStyleBackColor = true;
            this.buttonNuovoSprint.Click += new System.EventHandler(this.buttonNuovoSprint_Click);
            // 
            // TeamSprintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 738);
            this.Controls.Add(this.buttonNuovoSprint);
            this.Controls.Add(this.buttonTeam);
            this.Controls.Add(this.textBoxTeam);
            this.Controls.Add(this.label1);
            this.Name = "TeamSprintForm";
            this.Text = "TeamSprintForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private BindingSource bindingSource1;
        private Button buttonTeam;
        private TextBox textBoxTeam;
        private Button buttonNuovoSprint;
    }
}