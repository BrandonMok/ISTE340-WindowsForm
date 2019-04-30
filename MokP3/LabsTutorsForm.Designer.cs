namespace MokP3
{
    partial class LabsTutorsForm
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
            this.ml_TutorsLabs_title = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_description = new System.Windows.Forms.Label();
            this.ll_labHours = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ml_TutorsLabs_title
            // 
            this.ml_TutorsLabs_title.AutoSize = true;
            this.ml_TutorsLabs_title.Depth = 0;
            this.ml_TutorsLabs_title.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_TutorsLabs_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_TutorsLabs_title.Location = new System.Drawing.Point(379, 112);
            this.ml_TutorsLabs_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_TutorsLabs_title.Name = "ml_TutorsLabs_title";
            this.ml_TutorsLabs_title.Size = new System.Drawing.Size(249, 27);
            this.ml_TutorsLabs_title.TabIndex = 0;
            this.ml_TutorsLabs_title.Text = "Tutors / Lab Information";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(140, 175);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(89, 20);
            this.lbl_description.TabIndex = 1;
            this.lbl_description.Text = "Description";
            // 
            // ll_labHours
            // 
            this.ll_labHours.AutoSize = true;
            this.ll_labHours.Location = new System.Drawing.Point(145, 378);
            this.ll_labHours.Name = "ll_labHours";
            this.ll_labHours.Size = new System.Drawing.Size(179, 20);
            this.ll_labHours.TabIndex = 2;
            this.ll_labHours.TabStop = true;
            this.ll_labHours.Text = "http://www.istlabs.rit.edu";
            this.ll_labHours.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_labHours_LinkClicked);
            // 
            // LabsTutorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 530);
            this.Controls.Add(this.ll_labHours);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.ml_TutorsLabs_title);
            this.Name = "LabsTutorsForm";
            this.Text = "LabsTutorsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel ml_TutorsLabs_title;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.LinkLabel ll_labHours;
    }
}