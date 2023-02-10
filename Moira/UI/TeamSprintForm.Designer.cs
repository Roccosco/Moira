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
            this.textBoxTeam = new System.Windows.Forms.TextBox();
            this.buttonNuovoSprint = new System.Windows.Forms.Button();
            this.buttonTerminaSprint = new System.Windows.Forms.Button();
            this.dataGridViewTeams = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 520);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleziona team";
            // 
            // textBoxTeam
            // 
            this.textBoxTeam.Location = new System.Drawing.Point(424, 558);
            this.textBoxTeam.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTeam.Name = "textBoxTeam";
            this.textBoxTeam.Size = new System.Drawing.Size(223, 31);
            this.textBoxTeam.TabIndex = 1;
            // 
            // buttonNuovoSprint
            // 
            this.buttonNuovoSprint.Location = new System.Drawing.Point(149, 610);
            this.buttonNuovoSprint.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNuovoSprint.Name = "buttonNuovoSprint";
            this.buttonNuovoSprint.Size = new System.Drawing.Size(361, 60);
            this.buttonNuovoSprint.TabIndex = 3;
            this.buttonNuovoSprint.Text = "Avvia nuovo sprint";
            this.buttonNuovoSprint.UseVisualStyleBackColor = true;
            this.buttonNuovoSprint.Click += new System.EventHandler(this.buttonNuovoSprint_Click);
            // 
            // buttonTerminaSprint
            // 
            this.buttonTerminaSprint.Location = new System.Drawing.Point(584, 610);
            this.buttonTerminaSprint.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTerminaSprint.Name = "buttonTerminaSprint";
            this.buttonTerminaSprint.Size = new System.Drawing.Size(361, 60);
            this.buttonTerminaSprint.TabIndex = 4;
            this.buttonTerminaSprint.Text = "Termina sprint attivo";
            this.buttonTerminaSprint.UseVisualStyleBackColor = true;
            this.buttonTerminaSprint.Click += new System.EventHandler(this.buttonTerminaSprint_Click);
            // 
            // dataGridViewTeams
            // 
            this.dataGridViewTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeams.Location = new System.Drawing.Point(149, 91);
            this.dataGridViewTeams.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewTeams.Name = "dataGridViewTeams";
            this.dataGridViewTeams.RowHeadersWidth = 51;
            this.dataGridViewTeams.RowTemplate.Height = 29;
            this.dataGridViewTeams.Size = new System.Drawing.Size(796, 291);
            this.dataGridViewTeams.TabIndex = 5;
            // 
            // TeamSprintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 738);
            this.Controls.Add(this.dataGridViewTeams);
            this.Controls.Add(this.buttonTerminaSprint);
            this.Controls.Add(this.buttonNuovoSprint);
            this.Controls.Add(this.textBoxTeam);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TeamSprintForm";
            this.Text = "Gestione Sprint dei Team";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private BindingSource bindingSource1;
        private TextBox textBoxTeam;
        private Button buttonNuovoSprint;
        private Button buttonTerminaSprint;
        private DataGridView dataGridViewTeams;
    }
}