namespace MokP3
{
    partial class CoopEnrollmentForm
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
            this.ml_coopEnroll_title = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_prereq_desc = new System.Windows.Forms.Label();
            this.ml_prereq_title = new MaterialSkin.Controls.MaterialLabel();
            this.tb_coopEnroll = new System.Windows.Forms.TabControl();
            this.tb_prerea = new System.Windows.Forms.TabPage();
            this.tb_enroll = new System.Windows.Forms.TabPage();
            this.tb_approval = new System.Windows.Forms.TabPage();
            this.ml_Enroll1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_enroll1_desc = new System.Windows.Forms.Label();
            this.ml_enroll2 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_enroll2_desc = new System.Windows.Forms.Label();
            this.ml_approval_title = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_approval_desc = new System.Windows.Forms.Label();
            this.ll_link = new System.Windows.Forms.LinkLabel();
            this.tb_coopEnroll.SuspendLayout();
            this.tb_prerea.SuspendLayout();
            this.tb_enroll.SuspendLayout();
            this.tb_approval.SuspendLayout();
            this.SuspendLayout();
            // 
            // ml_coopEnroll_title
            // 
            this.ml_coopEnroll_title.AutoSize = true;
            this.ml_coopEnroll_title.Depth = 0;
            this.ml_coopEnroll_title.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_coopEnroll_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_coopEnroll_title.Location = new System.Drawing.Point(403, 106);
            this.ml_coopEnroll_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_coopEnroll_title.Name = "ml_coopEnroll_title";
            this.ml_coopEnroll_title.Size = new System.Drawing.Size(54, 27);
            this.ml_coopEnroll_title.TabIndex = 0;
            this.ml_coopEnroll_title.Text = "Title";
            // 
            // lbl_prereq_desc
            // 
            this.lbl_prereq_desc.AutoSize = true;
            this.lbl_prereq_desc.Location = new System.Drawing.Point(62, 80);
            this.lbl_prereq_desc.Name = "lbl_prereq_desc";
            this.lbl_prereq_desc.Size = new System.Drawing.Size(89, 20);
            this.lbl_prereq_desc.TabIndex = 0;
            this.lbl_prereq_desc.Text = "Description";
            // 
            // ml_prereq_title
            // 
            this.ml_prereq_title.AutoSize = true;
            this.ml_prereq_title.Depth = 0;
            this.ml_prereq_title.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_prereq_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_prereq_title.Location = new System.Drawing.Point(370, 31);
            this.ml_prereq_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_prereq_title.Name = "ml_prereq_title";
            this.ml_prereq_title.Size = new System.Drawing.Size(84, 27);
            this.ml_prereq_title.TabIndex = 1;
            this.ml_prereq_title.Text = "PreReq";
            // 
            // tb_coopEnroll
            // 
            this.tb_coopEnroll.Controls.Add(this.tb_prerea);
            this.tb_coopEnroll.Controls.Add(this.tb_enroll);
            this.tb_coopEnroll.Controls.Add(this.tb_approval);
            this.tb_coopEnroll.Location = new System.Drawing.Point(32, 149);
            this.tb_coopEnroll.Name = "tb_coopEnroll";
            this.tb_coopEnroll.SelectedIndex = 0;
            this.tb_coopEnroll.Size = new System.Drawing.Size(1006, 538);
            this.tb_coopEnroll.TabIndex = 2;
            // 
            // tb_prerea
            // 
            this.tb_prerea.Controls.Add(this.ml_prereq_title);
            this.tb_prerea.Controls.Add(this.lbl_prereq_desc);
            this.tb_prerea.Location = new System.Drawing.Point(4, 29);
            this.tb_prerea.Name = "tb_prerea";
            this.tb_prerea.Padding = new System.Windows.Forms.Padding(3);
            this.tb_prerea.Size = new System.Drawing.Size(998, 505);
            this.tb_prerea.TabIndex = 0;
            this.tb_prerea.Text = "Pre-requisites";
            this.tb_prerea.UseVisualStyleBackColor = true;
            // 
            // tb_enroll
            // 
            this.tb_enroll.Controls.Add(this.lbl_enroll2_desc);
            this.tb_enroll.Controls.Add(this.ml_enroll2);
            this.tb_enroll.Controls.Add(this.lbl_enroll1_desc);
            this.tb_enroll.Controls.Add(this.ml_Enroll1);
            this.tb_enroll.Location = new System.Drawing.Point(4, 29);
            this.tb_enroll.Name = "tb_enroll";
            this.tb_enroll.Padding = new System.Windows.Forms.Padding(3);
            this.tb_enroll.Size = new System.Drawing.Size(998, 505);
            this.tb_enroll.TabIndex = 1;
            this.tb_enroll.Text = "Enroll";
            this.tb_enroll.UseVisualStyleBackColor = true;
            // 
            // tb_approval
            // 
            this.tb_approval.Controls.Add(this.ll_link);
            this.tb_approval.Controls.Add(this.lbl_approval_desc);
            this.tb_approval.Controls.Add(this.ml_approval_title);
            this.tb_approval.Location = new System.Drawing.Point(4, 29);
            this.tb_approval.Name = "tb_approval";
            this.tb_approval.Size = new System.Drawing.Size(998, 505);
            this.tb_approval.TabIndex = 2;
            this.tb_approval.Text = "Approval";
            this.tb_approval.UseVisualStyleBackColor = true;
            // 
            // ml_Enroll1
            // 
            this.ml_Enroll1.AutoSize = true;
            this.ml_Enroll1.Depth = 0;
            this.ml_Enroll1.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_Enroll1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_Enroll1.Location = new System.Drawing.Point(165, 29);
            this.ml_Enroll1.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_Enroll1.Name = "ml_Enroll1";
            this.ml_Enroll1.Size = new System.Drawing.Size(66, 27);
            this.ml_Enroll1.TabIndex = 0;
            this.ml_Enroll1.Text = "Title1";
            // 
            // lbl_enroll1_desc
            // 
            this.lbl_enroll1_desc.AutoSize = true;
            this.lbl_enroll1_desc.Location = new System.Drawing.Point(49, 75);
            this.lbl_enroll1_desc.Name = "lbl_enroll1_desc";
            this.lbl_enroll1_desc.Size = new System.Drawing.Size(89, 20);
            this.lbl_enroll1_desc.TabIndex = 1;
            this.lbl_enroll1_desc.Text = "Description";
            // 
            // ml_enroll2
            // 
            this.ml_enroll2.AutoSize = true;
            this.ml_enroll2.Depth = 0;
            this.ml_enroll2.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_enroll2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_enroll2.Location = new System.Drawing.Point(165, 238);
            this.ml_enroll2.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_enroll2.Name = "ml_enroll2";
            this.ml_enroll2.Size = new System.Drawing.Size(71, 27);
            this.ml_enroll2.TabIndex = 2;
            this.ml_enroll2.Text = "Title 2";
            // 
            // lbl_enroll2_desc
            // 
            this.lbl_enroll2_desc.AutoSize = true;
            this.lbl_enroll2_desc.Location = new System.Drawing.Point(53, 298);
            this.lbl_enroll2_desc.Name = "lbl_enroll2_desc";
            this.lbl_enroll2_desc.Size = new System.Drawing.Size(89, 20);
            this.lbl_enroll2_desc.TabIndex = 3;
            this.lbl_enroll2_desc.Text = "Description";
            // 
            // ml_approval_title
            // 
            this.ml_approval_title.AutoSize = true;
            this.ml_approval_title.Depth = 0;
            this.ml_approval_title.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_approval_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_approval_title.Location = new System.Drawing.Point(367, 30);
            this.ml_approval_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_approval_title.Name = "ml_approval_title";
            this.ml_approval_title.Size = new System.Drawing.Size(98, 27);
            this.ml_approval_title.TabIndex = 0;
            this.ml_approval_title.Text = "Approval";
            // 
            // lbl_approval_desc
            // 
            this.lbl_approval_desc.AutoSize = true;
            this.lbl_approval_desc.Location = new System.Drawing.Point(48, 77);
            this.lbl_approval_desc.Name = "lbl_approval_desc";
            this.lbl_approval_desc.Size = new System.Drawing.Size(89, 20);
            this.lbl_approval_desc.TabIndex = 1;
            this.lbl_approval_desc.Text = "Description";
            // 
            // ll_link
            // 
            this.ll_link.AutoSize = true;
            this.ll_link.Location = new System.Drawing.Point(185, 287);
            this.ll_link.Name = "ll_link";
            this.ll_link.Size = new System.Drawing.Size(532, 20);
            this.ll_link.TabIndex = 2;
            this.ll_link.TabStop = true;
            this.ll_link.Text = "http://www.rit.edu/emcs/oce/student/stu_alum_pdfs/RITJobZoneGuide.pdf";
            this.ll_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_link_LinkClicked);
            // 
            // CoopEnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 699);
            this.Controls.Add(this.tb_coopEnroll);
            this.Controls.Add(this.ml_coopEnroll_title);
            this.Name = "CoopEnrollmentForm";
            this.Text = "CoopEnrollmentForm";
            this.tb_coopEnroll.ResumeLayout(false);
            this.tb_prerea.ResumeLayout(false);
            this.tb_prerea.PerformLayout();
            this.tb_enroll.ResumeLayout(false);
            this.tb_enroll.PerformLayout();
            this.tb_approval.ResumeLayout(false);
            this.tb_approval.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel ml_coopEnroll_title;
        private MaterialSkin.Controls.MaterialLabel ml_prereq_title;
        private System.Windows.Forms.Label lbl_prereq_desc;
        private System.Windows.Forms.TabControl tb_coopEnroll;
        private System.Windows.Forms.TabPage tb_prerea;
        private System.Windows.Forms.TabPage tb_enroll;
        private System.Windows.Forms.TabPage tb_approval;
        private System.Windows.Forms.Label lbl_enroll1_desc;
        private MaterialSkin.Controls.MaterialLabel ml_Enroll1;
        private System.Windows.Forms.Label lbl_enroll2_desc;
        private MaterialSkin.Controls.MaterialLabel ml_enroll2;
        private System.Windows.Forms.Label lbl_approval_desc;
        private MaterialSkin.Controls.MaterialLabel ml_approval_title;
        private System.Windows.Forms.LinkLabel ll_link;
    }
}