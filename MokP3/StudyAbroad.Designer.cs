namespace MokP3
{
    partial class StudyAbroad
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
            this.lbl_studyAbroad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_studyAbroad
            // 
            this.lbl_studyAbroad.AutoSize = true;
            this.lbl_studyAbroad.Location = new System.Drawing.Point(404, 96);
            this.lbl_studyAbroad.Name = "lbl_studyAbroad";
            this.lbl_studyAbroad.Size = new System.Drawing.Size(106, 20);
            this.lbl_studyAbroad.TabIndex = 0;
            this.lbl_studyAbroad.Text = "Study Abroad";
            // 
            // StudyAbroad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 573);
            this.Controls.Add(this.lbl_studyAbroad);
            this.Name = "StudyAbroad";
            this.Text = "StudyAbroad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_studyAbroad;
    }
}