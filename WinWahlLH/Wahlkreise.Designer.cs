namespace WinWahlLFH
{
    partial class Wahlkreise
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
            WahlkreiseListBox = new ListBox();
            WahlkreiseBearbeitenGroup = new GroupBox();
            WahlkreisOrtBox = new TextBox();
            addWahlkreisBtn = new Button();
            btnLoeschenWahlkreis = new Button();
            OrtNameLabel = new Label();
            WahlkreisSpeichernBtn = new Button();
            WahlkreisAbbrechenBtn = new Button();
            WahlkreisWahlberechtigtBox = new TextBox();
            WahlkreisWahlberechtigtLabel = new Label();
            WahlkreiseBearbeitenGroup.SuspendLayout();
            SuspendLayout();
            // 
            // WahlkreiseListBox
            // 
            WahlkreiseListBox.FormattingEnabled = true;
            WahlkreiseListBox.Location = new Point(31, 44);
            WahlkreiseListBox.Name = "WahlkreiseListBox";
            WahlkreiseListBox.Size = new Size(311, 304);
            WahlkreiseListBox.TabIndex = 0;
            WahlkreiseListBox.SelectedIndexChanged += WahlkreiseListBox_SelectedIndexChanged;
            // 
            // WahlkreiseBearbeitenGroup
            // 
            WahlkreiseBearbeitenGroup.Controls.Add(WahlkreisWahlberechtigtLabel);
            WahlkreiseBearbeitenGroup.Controls.Add(WahlkreisWahlberechtigtBox);
            WahlkreiseBearbeitenGroup.Controls.Add(WahlkreisAbbrechenBtn);
            WahlkreiseBearbeitenGroup.Controls.Add(WahlkreisSpeichernBtn);
            WahlkreiseBearbeitenGroup.Controls.Add(OrtNameLabel);
            WahlkreiseBearbeitenGroup.Controls.Add(WahlkreisOrtBox);
            WahlkreiseBearbeitenGroup.Location = new Point(429, 44);
            WahlkreiseBearbeitenGroup.Name = "WahlkreiseBearbeitenGroup";
            WahlkreiseBearbeitenGroup.Size = new Size(322, 304);
            WahlkreiseBearbeitenGroup.TabIndex = 1;
            WahlkreiseBearbeitenGroup.TabStop = false;
            WahlkreiseBearbeitenGroup.Enter += WahlkreiseBearbeitenGroup_Enter;
            // 
            // WahlkreisOrtBox
            // 
            WahlkreisOrtBox.Location = new Point(50, 52);
            WahlkreisOrtBox.Name = "WahlkreisOrtBox";
            WahlkreisOrtBox.Size = new Size(233, 27);
            WahlkreisOrtBox.TabIndex = 0;
            WahlkreisOrtBox.TextChanged += WahlkreisOrtBox_TextChanged;
            // 
            // addWahlkreisBtn
            // 
            addWahlkreisBtn.Location = new Point(31, 363);
            addWahlkreisBtn.Name = "addWahlkreisBtn";
            addWahlkreisBtn.Size = new Size(130, 29);
            addWahlkreisBtn.TabIndex = 2;
            addWahlkreisBtn.Text = "Neuer Wahlkreis";
            addWahlkreisBtn.UseVisualStyleBackColor = true;
            addWahlkreisBtn.Click += button1_Click;
            // 
            // btnLoeschenWahlkreis
            // 
            btnLoeschenWahlkreis.Location = new Point(184, 363);
            btnLoeschenWahlkreis.Name = "btnLoeschenWahlkreis";
            btnLoeschenWahlkreis.Size = new Size(94, 29);
            btnLoeschenWahlkreis.TabIndex = 3;
            btnLoeschenWahlkreis.Text = "Löschen";
            btnLoeschenWahlkreis.UseVisualStyleBackColor = true;
            // 
            // OrtNameLabel
            // 
            OrtNameLabel.AutoSize = true;
            OrtNameLabel.Location = new Point(50, 29);
            OrtNameLabel.Name = "OrtNameLabel";
            OrtNameLabel.Size = new Size(30, 20);
            OrtNameLabel.TabIndex = 1;
            OrtNameLabel.Text = "Ort";
            OrtNameLabel.Click += OrtNameLabel_Click;
            // 
            // WahlkreisSpeichernBtn
            // 
            WahlkreisSpeichernBtn.Location = new Point(50, 259);
            WahlkreisSpeichernBtn.Name = "WahlkreisSpeichernBtn";
            WahlkreisSpeichernBtn.Size = new Size(94, 29);
            WahlkreisSpeichernBtn.TabIndex = 8;
            WahlkreisSpeichernBtn.Text = "Hinzufügen";
            WahlkreisSpeichernBtn.UseVisualStyleBackColor = true;
            WahlkreisSpeichernBtn.MouseCaptureChanged += button1_Click;
            // 
            // WahlkreisAbbrechenBtn
            // 
            WahlkreisAbbrechenBtn.Location = new Point(189, 259);
            WahlkreisAbbrechenBtn.Name = "WahlkreisAbbrechenBtn";
            WahlkreisAbbrechenBtn.Size = new Size(94, 29);
            WahlkreisAbbrechenBtn.TabIndex = 9;
            WahlkreisAbbrechenBtn.Text = "Abbrechen";
            WahlkreisAbbrechenBtn.UseVisualStyleBackColor = true;
            // 
            // WahlkreisWahlberechtigtBox
            // 
            WahlkreisWahlberechtigtBox.Location = new Point(50, 129);
            WahlkreisWahlberechtigtBox.Name = "WahlkreisWahlberechtigtBox";
            WahlkreisWahlberechtigtBox.Size = new Size(233, 27);
            WahlkreisWahlberechtigtBox.TabIndex = 10;
            WahlkreisWahlberechtigtBox.TextChanged += WahlkreisWahlberechtigtBox_TextChanged;
            // 
            // WahlkreisWahlberechtigtLabel
            // 
            WahlkreisWahlberechtigtLabel.AutoSize = true;
            WahlkreisWahlberechtigtLabel.Location = new Point(50, 106);
            WahlkreisWahlberechtigtLabel.Name = "WahlkreisWahlberechtigtLabel";
            WahlkreisWahlberechtigtLabel.Size = new Size(201, 20);
            WahlkreisWahlberechtigtLabel.TabIndex = 11;
            WahlkreisWahlberechtigtLabel.Text = "Anzahl der Wahlberechtigten";
            // 
            // Wahlkreise
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoeschenWahlkreis);
            Controls.Add(addWahlkreisBtn);
            Controls.Add(WahlkreiseBearbeitenGroup);
            Controls.Add(WahlkreiseListBox);
            Name = "Wahlkreise";
            Text = "Wahlkreise";
            WahlkreiseBearbeitenGroup.ResumeLayout(false);
            WahlkreiseBearbeitenGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox WahlkreiseListBox;
        private GroupBox WahlkreiseBearbeitenGroup;
        private TextBox WahlkreisOrtBox;
        private Button addWahlkreisBtn;
        private Button btnLoeschenWahlkreis;
        private Label OrtNameLabel;
        private Button WahlkreisSpeichernBtn;
        private Button WahlkreisAbbrechenBtn;
        private Label WahlkreisWahlberechtigtLabel;
        private TextBox WahlkreisWahlberechtigtBox;
    }
}