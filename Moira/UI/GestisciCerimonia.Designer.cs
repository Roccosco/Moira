namespace Moira.UI
{
    partial class GestisciCerimonia
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
            this.dateTimePickerCerimonia = new System.Windows.Forms.DateTimePicker();
            this.textBoxDescCerimonia = new System.Windows.Forms.TextBox();
            this.textBoxNomeCerimonia = new System.Windows.Forms.TextBox();
            this.textBoxCodiceTeam = new System.Windows.Forms.TextBox();
            this.labelCodiceTeam = new System.Windows.Forms.Label();
            this.labelNomeCerimonia = new System.Windows.Forms.Label();
            this.labelDescCerimonia = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.buttonCreaCerimonia = new System.Windows.Forms.Button();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDurata = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePickerCerimonia
            // 
            this.dateTimePickerCerimonia.Location = new System.Drawing.Point(115, 364);
            this.dateTimePickerCerimonia.Name = "dateTimePickerCerimonia";
            this.dateTimePickerCerimonia.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerCerimonia.TabIndex = 0;
            // 
            // textBoxDescCerimonia
            // 
            this.textBoxDescCerimonia.Location = new System.Drawing.Point(115, 214);
            this.textBoxDescCerimonia.Name = "textBoxDescCerimonia";
            this.textBoxDescCerimonia.Size = new System.Drawing.Size(125, 27);
            this.textBoxDescCerimonia.TabIndex = 1;
            // 
            // textBoxNomeCerimonia
            // 
            this.textBoxNomeCerimonia.Location = new System.Drawing.Point(115, 129);
            this.textBoxNomeCerimonia.Name = "textBoxNomeCerimonia";
            this.textBoxNomeCerimonia.Size = new System.Drawing.Size(125, 27);
            this.textBoxNomeCerimonia.TabIndex = 2;
            // 
            // textBoxCodiceTeam
            // 
            this.textBoxCodiceTeam.Location = new System.Drawing.Point(115, 47);
            this.textBoxCodiceTeam.Name = "textBoxCodiceTeam";
            this.textBoxCodiceTeam.Size = new System.Drawing.Size(125, 27);
            this.textBoxCodiceTeam.TabIndex = 3;
            // 
            // labelCodiceTeam
            // 
            this.labelCodiceTeam.AutoSize = true;
            this.labelCodiceTeam.Location = new System.Drawing.Point(115, 24);
            this.labelCodiceTeam.Name = "labelCodiceTeam";
            this.labelCodiceTeam.Size = new System.Drawing.Size(93, 20);
            this.labelCodiceTeam.TabIndex = 5;
            this.labelCodiceTeam.Text = "Codice team";
            // 
            // labelNomeCerimonia
            // 
            this.labelNomeCerimonia.AutoSize = true;
            this.labelNomeCerimonia.Location = new System.Drawing.Point(115, 106);
            this.labelNomeCerimonia.Name = "labelNomeCerimonia";
            this.labelNomeCerimonia.Size = new System.Drawing.Size(50, 20);
            this.labelNomeCerimonia.TabIndex = 6;
            this.labelNomeCerimonia.Text = "Nome";
            // 
            // labelDescCerimonia
            // 
            this.labelDescCerimonia.AutoSize = true;
            this.labelDescCerimonia.Location = new System.Drawing.Point(115, 191);
            this.labelDescCerimonia.Name = "labelDescCerimonia";
            this.labelDescCerimonia.Size = new System.Drawing.Size(86, 20);
            this.labelDescCerimonia.TabIndex = 7;
            this.labelDescCerimonia.Text = "Descrizione";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(115, 257);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(39, 20);
            this.labelTipo.TabIndex = 8;
            this.labelTipo.Text = "Tipo";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(115, 341);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(41, 20);
            this.labelData.TabIndex = 9;
            this.labelData.Text = "Data";
            // 
            // buttonCreaCerimonia
            // 
            this.buttonCreaCerimonia.Location = new System.Drawing.Point(114, 471);
            this.buttonCreaCerimonia.Name = "buttonCreaCerimonia";
            this.buttonCreaCerimonia.Size = new System.Drawing.Size(228, 37);
            this.buttonCreaCerimonia.TabIndex = 10;
            this.buttonCreaCerimonia.Text = "Crea cerimonia";
            this.buttonCreaCerimonia.UseVisualStyleBackColor = true;
            this.buttonCreaCerimonia.Click += new System.EventHandler(this.buttonCreaCerimonia_Click);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "StandUp ",
            "Review",
            "Sporadico"});
            this.comboBoxTipo.Location = new System.Drawing.Point(115, 290);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(151, 28);
            this.comboBoxTipo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Durata in minuti";
            // 
            // textBoxDurata
            // 
            this.textBoxDurata.Location = new System.Drawing.Point(114, 426);
            this.textBoxDurata.Name = "textBoxDurata";
            this.textBoxDurata.Size = new System.Drawing.Size(125, 27);
            this.textBoxDurata.TabIndex = 14;
            // 
            // GestisciCerimonia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 556);
            this.Controls.Add(this.textBoxDurata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.buttonCreaCerimonia);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelDescCerimonia);
            this.Controls.Add(this.labelNomeCerimonia);
            this.Controls.Add(this.labelCodiceTeam);
            this.Controls.Add(this.textBoxCodiceTeam);
            this.Controls.Add(this.textBoxNomeCerimonia);
            this.Controls.Add(this.textBoxDescCerimonia);
            this.Controls.Add(this.dateTimePickerCerimonia);
            this.Name = "GestisciCerimonia";
            this.Text = "GestisciCerimonia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePickerCerimonia;
        private TextBox textBoxDescCerimonia;
        private TextBox textBoxNomeCerimonia;
        private TextBox textBoxCodiceTeam;
        private Label labelCodiceTeam;
        private Label labelNomeCerimonia;
        private Label labelDescCerimonia;
        private Label labelTipo;
        private Label labelData;
        private Button buttonCreaCerimonia;
        private ComboBox comboBoxTipo;
        private Label label1;
        private TextBox textBoxDurata;
    }
}