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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(61, 117);
            this.textBoxTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(179, 27);
            this.textBoxTask.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codice identificativo task da aggiungere";
            // 
            // textBoxImpiegato
            // 
            this.textBoxImpiegato.Enabled = false;
            this.textBoxImpiegato.Location = new System.Drawing.Point(61, 295);
            this.textBoxImpiegato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxImpiegato.Name = "textBoxImpiegato";
            this.textBoxImpiegato.Size = new System.Drawing.Size(179, 27);
            this.textBoxImpiegato.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codice univoco Impiegato che prende in carico il task";
            // 
            // textBoxStoryPoints
            // 
            this.textBoxStoryPoints.Location = new System.Drawing.Point(61, 184);
            this.textBoxStoryPoints.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStoryPoints.Name = "textBoxStoryPoints";
            this.textBoxStoryPoints.Size = new System.Drawing.Size(179, 27);
            this.textBoxStoryPoints.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Story points del task";
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(58, 213);
            this.buttonAddTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(182, 31);
            this.buttonAddTask.TabIndex = 8;
            this.buttonAddTask.Text = "Aggiungi task";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // buttonImpiegato
            // 
            this.buttonImpiegato.Enabled = false;
            this.buttonImpiegato.Location = new System.Drawing.Point(58, 324);
            this.buttonImpiegato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonImpiegato.Name = "buttonImpiegato";
            this.buttonImpiegato.Size = new System.Drawing.Size(182, 31);
            this.buttonImpiegato.TabIndex = 9;
            this.buttonImpiegato.Text = "Associa impiegato";
            this.buttonImpiegato.UseVisualStyleBackColor = true;
            this.buttonImpiegato.Click += new System.EventHandler(this.buttonImpiegato_Click);
            // 
            // buttonTermina
            // 
            this.buttonTermina.Enabled = false;
            this.buttonTermina.Location = new System.Drawing.Point(58, 416);
            this.buttonTermina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTermina.Name = "buttonTermina";
            this.buttonTermina.Size = new System.Drawing.Size(182, 31);
            this.buttonTermina.TabIndex = 10;
            this.buttonTermina.Text = "Termina";
            this.buttonTermina.UseVisualStyleBackColor = true;
            this.buttonTermina.Click += new System.EventHandler(this.buttonTermina_Click);
            // 
            // dataGridViewTask
            // 
            this.dataGridViewTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTask.Location = new System.Drawing.Point(488, 110);
            this.dataGridViewTask.Name = "dataGridViewTask";
            this.dataGridViewTask.RowHeadersWidth = 51;
            this.dataGridViewTask.RowTemplate.Height = 29;
            this.dataGridViewTask.Size = new System.Drawing.Size(349, 337);
            this.dataGridViewTask.TabIndex = 11;
            // 
            // AggiungiTaskASprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 614);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AggiungiTaskASprint";
            this.Text = "AggiungiTaskASprint";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).EndInit();
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
    }
}