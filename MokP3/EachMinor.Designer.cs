namespace MokP3
{
    partial class EachMinor
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
            this.lbl_specific_minor_Name = new System.Windows.Forms.Label();
            this.lbl_specific_minor_Title = new System.Windows.Forms.Label();
            this.lbl_specific_minor_desc = new System.Windows.Forms.Label();
            this.lbl_specific_minor_concentrations = new System.Windows.Forms.Label();
            this.lbl_specific_minor_concentrationHeader = new System.Windows.Forms.Label();
            this.lbl_specific_minor_note = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_specific_minor_Name
            // 
            this.lbl_specific_minor_Name.AutoSize = true;
            this.lbl_specific_minor_Name.Location = new System.Drawing.Point(344, 112);
            this.lbl_specific_minor_Name.Name = "lbl_specific_minor_Name";
            this.lbl_specific_minor_Name.Size = new System.Drawing.Size(94, 20);
            this.lbl_specific_minor_Name.TabIndex = 0;
            this.lbl_specific_minor_Name.Text = "Minor Name";
            // 
            // lbl_specific_minor_Title
            // 
            this.lbl_specific_minor_Title.AutoSize = true;
            this.lbl_specific_minor_Title.Location = new System.Drawing.Point(219, 140);
            this.lbl_specific_minor_Title.Name = "lbl_specific_minor_Title";
            this.lbl_specific_minor_Title.Size = new System.Drawing.Size(81, 20);
            this.lbl_specific_minor_Title.TabIndex = 1;
            this.lbl_specific_minor_Title.Text = "Minor Title";
            // 
            // lbl_specific_minor_desc
            // 
            this.lbl_specific_minor_desc.AutoSize = true;
            this.lbl_specific_minor_desc.Location = new System.Drawing.Point(45, 195);
            this.lbl_specific_minor_desc.Name = "lbl_specific_minor_desc";
            this.lbl_specific_minor_desc.Size = new System.Drawing.Size(132, 20);
            this.lbl_specific_minor_desc.TabIndex = 2;
            this.lbl_specific_minor_desc.Text = "Minor Description";
            // 
            // lbl_specific_minor_concentrations
            // 
            this.lbl_specific_minor_concentrations.AutoSize = true;
            this.lbl_specific_minor_concentrations.Location = new System.Drawing.Point(344, 466);
            this.lbl_specific_minor_concentrations.Name = "lbl_specific_minor_concentrations";
            this.lbl_specific_minor_concentrations.Size = new System.Drawing.Size(117, 20);
            this.lbl_specific_minor_concentrations.TabIndex = 3;
            this.lbl_specific_minor_concentrations.Text = "Concentrations";
            // 
            // lbl_specific_minor_concentrationHeader
            // 
            this.lbl_specific_minor_concentrationHeader.AutoSize = true;
            this.lbl_specific_minor_concentrationHeader.Location = new System.Drawing.Point(344, 435);
            this.lbl_specific_minor_concentrationHeader.Name = "lbl_specific_minor_concentrationHeader";
            this.lbl_specific_minor_concentrationHeader.Size = new System.Drawing.Size(117, 20);
            this.lbl_specific_minor_concentrationHeader.TabIndex = 4;
            this.lbl_specific_minor_concentrationHeader.Text = "Concentrations";
            // 
            // lbl_specific_minor_note
            // 
            this.lbl_specific_minor_note.AutoSize = true;
            this.lbl_specific_minor_note.Location = new System.Drawing.Point(12, 553);
            this.lbl_specific_minor_note.Name = "lbl_specific_minor_note";
            this.lbl_specific_minor_note.Size = new System.Drawing.Size(0, 20);
            this.lbl_specific_minor_note.TabIndex = 5;
            // 
            // EachMinor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 606);
            this.Controls.Add(this.lbl_specific_minor_note);
            this.Controls.Add(this.lbl_specific_minor_concentrationHeader);
            this.Controls.Add(this.lbl_specific_minor_concentrations);
            this.Controls.Add(this.lbl_specific_minor_desc);
            this.Controls.Add(this.lbl_specific_minor_Title);
            this.Controls.Add(this.lbl_specific_minor_Name);
            this.Name = "EachMinor";
            this.Text = "EachMinor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_specific_minor_Name;
        private System.Windows.Forms.Label lbl_specific_minor_Title;
        private System.Windows.Forms.Label lbl_specific_minor_desc;
        private System.Windows.Forms.Label lbl_specific_minor_concentrations;
        private System.Windows.Forms.Label lbl_specific_minor_concentrationHeader;
        private System.Windows.Forms.Label lbl_specific_minor_note;
    }
}