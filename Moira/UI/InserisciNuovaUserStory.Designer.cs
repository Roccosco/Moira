namespace Moira.UI
{
    partial class InserisciNuovaUserStory
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescrizione = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPosizione = new System.Windows.Forms.TextBox();
            this.buttonInserisciUserStory = new System.Windows.Forms.Button();
            this.buttonInserisciNuovoTask = new System.Windows.Forms.Button();
            this.buttonInserisciPosizioneUserStory = new System.Windows.Forms.Button();
            this.buttonConferma = new System.Windows.Forms.Button();
            this.richTextBoxMessaggi = new System.Windows.Forms.RichTextBox();
            this.panelBacklog = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(392, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuova userstory";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(31, 143);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(263, 27);
            this.textBoxNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrizione:";
            // 
            // textBoxDescrizione
            // 
            this.textBoxDescrizione.Location = new System.Drawing.Point(31, 255);
            this.textBoxDescrizione.Name = "textBoxDescrizione";
            this.textBoxDescrizione.Size = new System.Drawing.Size(263, 27);
            this.textBoxDescrizione.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Posizione nel backlog:";
            // 
            // textBoxPosizione
            // 
            this.textBoxPosizione.Location = new System.Drawing.Point(351, 200);
            this.textBoxPosizione.Name = "textBoxPosizione";
            this.textBoxPosizione.Size = new System.Drawing.Size(245, 27);
            this.textBoxPosizione.TabIndex = 5;
            this.textBoxPosizione.Text = "0";
            // 
            // buttonInserisciUserStory
            // 
            this.buttonInserisciUserStory.Location = new System.Drawing.Point(31, 344);
            this.buttonInserisciUserStory.Name = "buttonInserisciUserStory";
            this.buttonInserisciUserStory.Size = new System.Drawing.Size(245, 29);
            this.buttonInserisciUserStory.TabIndex = 7;
            this.buttonInserisciUserStory.Text = "Inserisci Userstory";
            this.buttonInserisciUserStory.UseVisualStyleBackColor = true;
            this.buttonInserisciUserStory.Click += new System.EventHandler(this.buttonInserisciUserStory_Click);
            // 
            // buttonInserisciNuovoTask
            // 
            this.buttonInserisciNuovoTask.Enabled = false;
            this.buttonInserisciNuovoTask.Location = new System.Drawing.Point(351, 111);
            this.buttonInserisciNuovoTask.Name = "buttonInserisciNuovoTask";
            this.buttonInserisciNuovoTask.Size = new System.Drawing.Size(245, 29);
            this.buttonInserisciNuovoTask.TabIndex = 8;
            this.buttonInserisciNuovoTask.Text = "Inserisci Task";
            this.buttonInserisciNuovoTask.UseVisualStyleBackColor = true;
            this.buttonInserisciNuovoTask.Click += new System.EventHandler(this.buttonInserisciNuovoTask_Click);
            // 
            // buttonInserisciPosizioneUserStory
            // 
            this.buttonInserisciPosizioneUserStory.Enabled = false;
            this.buttonInserisciPosizioneUserStory.Location = new System.Drawing.Point(351, 285);
            this.buttonInserisciPosizioneUserStory.Name = "buttonInserisciPosizioneUserStory";
            this.buttonInserisciPosizioneUserStory.Size = new System.Drawing.Size(245, 29);
            this.buttonInserisciPosizioneUserStory.TabIndex = 9;
            this.buttonInserisciPosizioneUserStory.Text = "Conferma posizione";
            this.buttonInserisciPosizioneUserStory.UseVisualStyleBackColor = true;
            this.buttonInserisciPosizioneUserStory.Click += new System.EventHandler(this.buttonInserisciPosizioneUserStory_Click);
            // 
            // buttonConferma
            // 
            this.buttonConferma.Location = new System.Drawing.Point(351, 364);
            this.buttonConferma.Name = "buttonConferma";
            this.buttonConferma.Size = new System.Drawing.Size(245, 29);
            this.buttonConferma.TabIndex = 10;
            this.buttonConferma.Text = "Conferma inserimento";
            this.buttonConferma.UseVisualStyleBackColor = true;
            this.buttonConferma.Visible = false;
            this.buttonConferma.Click += new System.EventHandler(this.buttonConferma_Click);
            // 
            // richTextBoxMessaggi
            // 
            this.richTextBoxMessaggi.Location = new System.Drawing.Point(31, 460);
            this.richTextBoxMessaggi.Name = "richTextBoxMessaggi";
            this.richTextBoxMessaggi.ReadOnly = true;
            this.richTextBoxMessaggi.Size = new System.Drawing.Size(565, 271);
            this.richTextBoxMessaggi.TabIndex = 11;
            this.richTextBoxMessaggi.Text = "";
            // 
            // panelBacklog
            // 
            this.panelBacklog.AutoScroll = true;
            this.panelBacklog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBacklog.Location = new System.Drawing.Point(629, 25);
            this.panelBacklog.Name = "panelBacklog";
            this.panelBacklog.Size = new System.Drawing.Size(250, 706);
            this.panelBacklog.TabIndex = 12;
            // 
            // InserisciNuovaUserStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 743);
            this.Controls.Add(this.panelBacklog);
            this.Controls.Add(this.richTextBoxMessaggi);
            this.Controls.Add(this.buttonConferma);
            this.Controls.Add(this.buttonInserisciPosizioneUserStory);
            this.Controls.Add(this.buttonInserisciNuovoTask);
            this.Controls.Add(this.buttonInserisciUserStory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPosizione);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDescrizione);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Name = "InserisciNuovaUserStory";
            this.Text = "Inserisci nuova userstory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxNome;
        private Label label2;
        private Label label3;
        private TextBox textBoxDescrizione;
        private Label label4;
        private TextBox textBoxPosizione;
        private Button buttonInserisciUserStory;
        private Button buttonInserisciNuovoTask;
        private Button buttonInserisciPosizioneUserStory;
        private Button buttonConferma;
        private RichTextBox richTextBoxMessaggi;
        private Panel panelBacklog;
    }
}