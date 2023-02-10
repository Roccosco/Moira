namespace Moira.UI
{
    partial class AggiungiTaskASprint
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
            this.textBoxImpiegato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStoryPoints = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.buttonImpiegato = new System.Windows.Forms.Button();
            this.buttonTermina = new System.Windows.Forms.Button();
            this.dataGridViewTask = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewTeamImpiegati = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamImpiegati)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(195, 66);
            this.textBoxTask.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(223, 31);
            this.textBoxTask.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codice identificativo task da aggiungere";
            // 
            // textBoxImpiegato
            // 
            this.textBoxImpiegato.Enabled = false;
            this.textBoxImpiegato.Location = new System.Drawing.Point(195, 614);
            this.textBoxImpiegato.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxImpiegato.Name = "textBoxImpiegato";
            this.textBoxImpiegato.Size = new System.Drawing.Size(223, 31);
            this.textBoxImpiegato.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 586);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codice univoco Impiegato che prende in carico il task";
            // 
            // textBoxStoryPoints
            // 
            this.textBoxStoryPoints.Location = new System.Drawing.Point(195, 150);
            this.textBoxStoryPoints.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStoryPoints.Name = "textBoxStoryPoints";
            this.textBoxStoryPoints.Size = new System.Drawing.Size(223, 31);
            this.textBoxStoryPoints.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Story points del task";
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(191, 186);
            this.buttonAddTask.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(228, 39);
            this.buttonAddTask.TabIndex = 8;
            this.buttonAddTask.Text = "Aggiungi task";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // buttonImpiegato
            // 
            this.buttonImpiegato.Enabled = false;
            this.buttonImpiegato.Location = new System.Drawing.Point(195, 650);
            this.buttonImpiegato.Margin = new System.Windows.Forms.Padding(2);
            this.buttonImpiegato.Name = "buttonImpiegato";
            this.buttonImpiegato.Size = new System.Drawing.Size(228, 39);
            this.buttonImpiegato.TabIndex = 9;
            this.buttonImpiegato.Text = "Associa impiegato";
            this.buttonImpiegato.UseVisualStyleBackColor = true;
            this.buttonImpiegato.Click += new System.EventHandler(this.buttonImpiegato_Click);
            // 
            // buttonTermina
            // 
            this.buttonTermina.Enabled = false;
            this.buttonTermina.Location = new System.Drawing.Point(195, 700);
            this.buttonTermina.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTermina.Name = "buttonTermina";
            this.buttonTermina.Size = new System.Drawing.Size(228, 39);
            this.buttonTermina.TabIndex = 10;
            this.buttonTermina.Text = "Termina";
            this.buttonTermina.UseVisualStyleBackColor = true;
            this.buttonTermina.Click += new System.EventHandler(this.buttonTermina_Click);
            // 
            // dataGridViewTask
            // 
            this.dataGridViewTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTask.Location = new System.Drawing.Point(610, 138);
            this.dataGridViewTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewTask.Name = "dataGridViewTask";
            this.dataGridViewTask.RowHeadersWidth = 51;
            this.dataGridViewTask.RowTemplate.Height = 29;
            this.dataGridViewTask.Size = new System.Drawing.Size(519, 615);
            this.dataGridViewTask.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(865, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "TASKS";
            // 
            // dataGridViewTeamImpiegati
            // 
            this.dataGridViewTeamImpiegati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeamImpiegati.Location = new System.Drawing.Point(15, 255);
            this.dataGridViewTeamImpiegati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewTeamImpiegati.Name = "dataGridViewTeamImpiegati";
            this.dataGridViewTeamImpiegati.RowHeadersWidth = 51;
            this.dataGridViewTeamImpiegati.RowTemplate.Height = 29;
            this.dataGridViewTeamImpiegati.Size = new System.Drawing.Size(588, 328);
            this.dataGridViewTeamImpiegati.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "IMPIEGATI";
            // 
            // AggiungiTaskASprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 768);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewTeamImpiegati);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewTask);
            this.Controls.Add(this.buttonTermina);
            this.Controls.Add(this.buttonImpiegato);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.textBoxStoryPoints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxImpiegato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTask);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AggiungiTaskASprint";
            this.Text = "Aggiungi Task A Sprint";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamImpiegati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxTask;
        private Label label1;
        private TextBox textBoxImpiegato;
        private Label label2;
        private TextBox textBoxStoryPoints;
        private Label label3;
        private Button buttonAddTask;
        private Button buttonImpiegato;
        private Button buttonTermina;
        private DataGridView dataGridViewTask;
        private Label label4;
        private DataGridView dataGridViewImpiegati;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridView dataGridViewTeamImpiegati;
    }
}