namespace WinWahlLFH
{
    partial class Stimmzettel
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
            cboKandidat_0_1_static = new CheckBox();
            cboKandidat_0_2_static = new CheckBox();
            cboKandidat_0_3_static = new CheckBox();
            StimmzettelÜbersichtBox = new GroupBox();
            StimmzettelÜbersichtBox.SuspendLayout();
            SuspendLayout();
            // 
            // cboKandidat_0_1_static
            // 
            cboKandidat_0_1_static.AutoSize = true;
            cboKandidat_0_1_static.Location = new Point(24, 58);
            cboKandidat_0_1_static.Name = "cboKandidat_0_1_static";
            cboKandidat_0_1_static.Size = new Size(18, 17);
            cboKandidat_0_1_static.TabIndex = 1;
            cboKandidat_0_1_static.UseVisualStyleBackColor = true;
            // 
            // cboKandidat_0_2_static
            // 
            cboKandidat_0_2_static.AutoSize = true;
            cboKandidat_0_2_static.Location = new Point(125, 58);
            cboKandidat_0_2_static.Name = "cboKandidat_0_2_static";
            cboKandidat_0_2_static.Size = new Size(18, 17);
            cboKandidat_0_2_static.TabIndex = 2;
            cboKandidat_0_2_static.UseVisualStyleBackColor = true;
            cboKandidat_0_2_static.CheckedChanged += cboKandidat_0_2_static_CheckedChanged;
            // 
            // cboKandidat_0_3_static
            // 
            cboKandidat_0_3_static.AutoSize = true;
            cboKandidat_0_3_static.Location = new Point(233, 58);
            cboKandidat_0_3_static.Name = "cboKandidat_0_3_static";
            cboKandidat_0_3_static.Size = new Size(18, 17);
            cboKandidat_0_3_static.TabIndex = 3;
            cboKandidat_0_3_static.UseVisualStyleBackColor = true;
            // 
            // StimmzettelÜbersichtBox
            // 
            StimmzettelÜbersichtBox.Controls.Add(cboKandidat_0_3_static);
            StimmzettelÜbersichtBox.Controls.Add(cboKandidat_0_1_static);
            StimmzettelÜbersichtBox.Controls.Add(cboKandidat_0_2_static);
            StimmzettelÜbersichtBox.Location = new Point(58, 60);
            StimmzettelÜbersichtBox.Name = "StimmzettelÜbersichtBox";
            StimmzettelÜbersichtBox.Size = new Size(686, 125);
            StimmzettelÜbersichtBox.TabIndex = 4;
            StimmzettelÜbersichtBox.TabStop = false;
            StimmzettelÜbersichtBox.Text = "Kandidaten";
            // 
            // Stimmzettel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(20, 20);
            ClientSize = new Size(800, 450);
            Controls.Add(StimmzettelÜbersichtBox);
            Name = "Stimmzettel";
            Text = "Wahl - Stimmzettel";
            StimmzettelÜbersichtBox.ResumeLayout(false);
            StimmzettelÜbersichtBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CheckBox cboKandidat_0_1_static;
        private CheckBox cboKandidat_0_2_static;
        private CheckBox cboKandidat_0_3_static;
        private GroupBox StimmzettelÜbersichtBox;
    }
}