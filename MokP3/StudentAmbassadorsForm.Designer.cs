namespace MokP3
{
    partial class StudentAmbassadorsForm
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
            this.ml_studentAMBTitle = new MaterialSkin.Controls.MaterialLabel();
            this.pb_studentAMB = new System.Windows.Forms.PictureBox();
            this.tb_studentAMB = new System.Windows.Forms.TabControl();
            this.tb_Mission = new System.Windows.Forms.TabPage();
            this.tb_overview = new System.Windows.Forms.TabPage();
            this.tb_criteria = new System.Windows.Forms.TabPage();
            this.tb_Duties = new System.Windows.Forms.TabPage();
            this.tb_expectations = new System.Windows.Forms.TabPage();
            this.tb_perks = new System.Windows.Forms.TabPage();
            this.tb_apply = new System.Windows.Forms.TabPage();
            this.ml_missionTitle = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_mission_desc = new System.Windows.Forms.Label();
            this.ml_overviewTitle = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_overview_Desc = new System.Windows.Forms.Label();
            this.ml_criteria_title = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_criteria_desc = new System.Windows.Forms.Label();
            this.ml_duties_title = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_duties_desc = new System.Windows.Forms.Label();
            this.ml_expectations_title = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_expectations_desc = new System.Windows.Forms.Label();
            this.ml_perks_title = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_perks_desc = new System.Windows.Forms.Label();
            this.ml_apply_title = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_apply_desc = new System.Windows.Forms.Label();
            this.ll_applyLink = new System.Windows.Forms.LinkLabel();
            this.lbl_note = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_studentAMB)).BeginInit();
            this.tb_studentAMB.SuspendLayout();
            this.tb_Mission.SuspendLayout();
            this.tb_overview.SuspendLayout();
            this.tb_criteria.SuspendLayout();
            this.tb_Duties.SuspendLayout();
            this.tb_expectations.SuspendLayout();
            this.tb_perks.SuspendLayout();
            this.tb_apply.SuspendLayout();
            this.SuspendLayout();
            // 
            // ml_studentAMBTitle
            // 
            this.ml_studentAMBTitle.AutoSize = true;
            this.ml_studentAMBTitle.Depth = 0;
            this.ml_studentAMBTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_studentAMBTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_studentAMBTitle.Location = new System.Drawing.Point(391, 116);
            this.ml_studentAMBTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_studentAMBTitle.Name = "ml_studentAMBTitle";
            this.ml_studentAMBTitle.Size = new System.Drawing.Size(54, 27);
            this.ml_studentAMBTitle.TabIndex = 0;
            this.ml_studentAMBTitle.Text = "Title";
            // 
            // pb_studentAMB
            // 
            this.pb_studentAMB.Location = new System.Drawing.Point(338, 146);
            this.pb_studentAMB.Name = "pb_studentAMB";
            this.pb_studentAMB.Size = new System.Drawing.Size(626, 292);
            this.pb_studentAMB.TabIndex = 1;
            this.pb_studentAMB.TabStop = false;
            // 
            // tb_studentAMB
            // 
            this.tb_studentAMB.Controls.Add(this.tb_Mission);
            this.tb_studentAMB.Controls.Add(this.tb_overview);
            this.tb_studentAMB.Controls.Add(this.tb_criteria);
            this.tb_studentAMB.Controls.Add(this.tb_Duties);
            this.tb_studentAMB.Controls.Add(this.tb_expectations);
            this.tb_studentAMB.Controls.Add(this.tb_perks);
            this.tb_studentAMB.Controls.Add(this.tb_apply);
            this.tb_studentAMB.Location = new System.Drawing.Point(32, 468);
            this.tb_studentAMB.Name = "tb_studentAMB";
            this.tb_studentAMB.SelectedIndex = 0;
            this.tb_studentAMB.Size = new System.Drawing.Size(1245, 422);
            this.tb_studentAMB.TabIndex = 2;
            // 
            // tb_Mission
            // 
            this.tb_Mission.Controls.Add(this.lbl_mission_desc);
            this.tb_Mission.Controls.Add(this.ml_missionTitle);
            this.tb_Mission.Location = new System.Drawing.Point(4, 29);
            this.tb_Mission.Name = "tb_Mission";
            this.tb_Mission.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Mission.Size = new System.Drawing.Size(1237, 389);
            this.tb_Mission.TabIndex = 0;
            this.tb_Mission.Text = "Mission";
            this.tb_Mission.UseVisualStyleBackColor = true;
            // 
            // tb_overview
            // 
            this.tb_overview.Controls.Add(this.lbl_overview_Desc);
            this.tb_overview.Controls.Add(this.ml_overviewTitle);
            this.tb_overview.Location = new System.Drawing.Point(4, 29);
            this.tb_overview.Name = "tb_overview";
            this.tb_overview.Padding = new System.Windows.Forms.Padding(3);
            this.tb_overview.Size = new System.Drawing.Size(1237, 389);
            this.tb_overview.TabIndex = 1;
            this.tb_overview.Text = "Overview";
            this.tb_overview.UseVisualStyleBackColor = true;
            // 
            // tb_criteria
            // 
            this.tb_criteria.Controls.Add(this.lbl_criteria_desc);
            this.tb_criteria.Controls.Add(this.ml_criteria_title);
            this.tb_criteria.Location = new System.Drawing.Point(4, 29);
            this.tb_criteria.Name = "tb_criteria";
            this.tb_criteria.Size = new System.Drawing.Size(1237, 389);
            this.tb_criteria.TabIndex = 2;
            this.tb_criteria.Text = "Criteria";
            this.tb_criteria.UseVisualStyleBackColor = true;
            // 
            // tb_Duties
            // 
            this.tb_Duties.Controls.Add(this.lbl_duties_desc);
            this.tb_Duties.Controls.Add(this.ml_duties_title);
            this.tb_Duties.Location = new System.Drawing.Point(4, 29);
            this.tb_Duties.Name = "tb_Duties";
            this.tb_Duties.Size = new System.Drawing.Size(1237, 389);
            this.tb_Duties.TabIndex = 3;
            this.tb_Duties.Text = "Duties";
            this.tb_Duties.UseVisualStyleBackColor = true;
            // 
            // tb_expectations
            // 
            this.tb_expectations.Controls.Add(this.lbl_expectations_desc);
            this.tb_expectations.Controls.Add(this.ml_expectations_title);
            this.tb_expectations.Location = new System.Drawing.Point(4, 29);
            this.tb_expectations.Name = "tb_expectations";
            this.tb_expectations.Size = new System.Drawing.Size(1237, 389);
            this.tb_expectations.TabIndex = 4;
            this.tb_expectations.Text = "Expectations";
            this.tb_expectations.UseVisualStyleBackColor = true;
            // 
            // tb_perks
            // 
            this.tb_perks.Controls.Add(this.lbl_perks_desc);
            this.tb_perks.Controls.Add(this.ml_perks_title);
            this.tb_perks.Location = new System.Drawing.Point(4, 29);
            this.tb_perks.Name = "tb_perks";
            this.tb_perks.Size = new System.Drawing.Size(1237, 389);
            this.tb_perks.TabIndex = 5;
            this.tb_perks.Text = "Perks";
            this.tb_perks.UseVisualStyleBackColor = true;
            // 
            // tb_apply
            // 
            this.tb_apply.Controls.Add(this.lbl_note);
            this.tb_apply.Controls.Add(this.ll_applyLink);
            this.tb_apply.Controls.Add(this.lbl_apply_desc);
            this.tb_apply.Controls.Add(this.ml_apply_title);
            this.tb_apply.Location = new System.Drawing.Point(4, 29);
            this.tb_apply.Name = "tb_apply";
            this.tb_apply.Size = new System.Drawing.Size(1237, 389);
            this.tb_apply.TabIndex = 6;
            this.tb_apply.Text = "Apply";
            this.tb_apply.UseVisualStyleBackColor = true;
            // 
            // ml_missionTitle
            // 
            this.ml_missionTitle.AutoSize = true;
            this.ml_missionTitle.Depth = 0;
            this.ml_missionTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_missionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_missionTitle.Location = new System.Drawing.Point(547, 37);
            this.ml_missionTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_missionTitle.Name = "ml_missionTitle";
            this.ml_missionTitle.Size = new System.Drawing.Size(194, 27);
            this.ml_missionTitle.TabIndex = 0;
            this.ml_missionTitle.Text = "Mission Statement";
            // 
            // lbl_mission_desc
            // 
            this.lbl_mission_desc.AutoSize = true;
            this.lbl_mission_desc.Location = new System.Drawing.Point(127, 79);
            this.lbl_mission_desc.Name = "lbl_mission_desc";
            this.lbl_mission_desc.Size = new System.Drawing.Size(89, 20);
            this.lbl_mission_desc.TabIndex = 1;
            this.lbl_mission_desc.Text = "Description";
            // 
            // ml_overviewTitle
            // 
            this.ml_overviewTitle.AutoSize = true;
            this.ml_overviewTitle.Depth = 0;
            this.ml_overviewTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_overviewTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_overviewTitle.Location = new System.Drawing.Point(542, 34);
            this.ml_overviewTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_overviewTitle.Name = "ml_overviewTitle";
            this.ml_overviewTitle.Size = new System.Drawing.Size(102, 27);
            this.ml_overviewTitle.TabIndex = 0;
            this.ml_overviewTitle.Text = "Overview";
            // 
            // lbl_overview_Desc
            // 
            this.lbl_overview_Desc.AutoSize = true;
            this.lbl_overview_Desc.Location = new System.Drawing.Point(114, 79);
            this.lbl_overview_Desc.Name = "lbl_overview_Desc";
            this.lbl_overview_Desc.Size = new System.Drawing.Size(89, 20);
            this.lbl_overview_Desc.TabIndex = 1;
            this.lbl_overview_Desc.Text = "Description";
            // 
            // ml_criteria_title
            // 
            this.ml_criteria_title.AutoSize = true;
            this.ml_criteria_title.Depth = 0;
            this.ml_criteria_title.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_criteria_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_criteria_title.Location = new System.Drawing.Point(539, 35);
            this.ml_criteria_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_criteria_title.Name = "ml_criteria_title";
            this.ml_criteria_title.Size = new System.Drawing.Size(81, 27);
            this.ml_criteria_title.TabIndex = 0;
            this.ml_criteria_title.Text = "Criteria";
            // 
            // lbl_criteria_desc
            // 
            this.lbl_criteria_desc.AutoSize = true;
            this.lbl_criteria_desc.Location = new System.Drawing.Point(118, 80);
            this.lbl_criteria_desc.Name = "lbl_criteria_desc";
            this.lbl_criteria_desc.Size = new System.Drawing.Size(89, 20);
            this.lbl_criteria_desc.TabIndex = 1;
            this.lbl_criteria_desc.Text = "Description";
            // 
            // ml_duties_title
            // 
            this.ml_duties_title.AutoSize = true;
            this.ml_duties_title.Depth = 0;
            this.ml_duties_title.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_duties_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_duties_title.Location = new System.Drawing.Point(522, 34);
            this.ml_duties_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_duties_title.Name = "ml_duties_title";
            this.ml_duties_title.Size = new System.Drawing.Size(73, 27);
            this.ml_duties_title.TabIndex = 0;
            this.ml_duties_title.Text = "Duties";
            // 
            // lbl_duties_desc
            // 
            this.lbl_duties_desc.AutoSize = true;
            this.lbl_duties_desc.Location = new System.Drawing.Point(124, 76);
            this.lbl_duties_desc.Name = "lbl_duties_desc";
            this.lbl_duties_desc.Size = new System.Drawing.Size(89, 20);
            this.lbl_duties_desc.TabIndex = 1;
            this.lbl_duties_desc.Text = "Description";
            // 
            // ml_expectations_title
            // 
            this.ml_expectations_title.AutoSize = true;
            this.ml_expectations_title.Depth = 0;
            this.ml_expectations_title.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_expectations_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_expectations_title.Location = new System.Drawing.Point(527, 35);
            this.ml_expectations_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_expectations_title.Name = "ml_expectations_title";
            this.ml_expectations_title.Size = new System.Drawing.Size(139, 27);
            this.ml_expectations_title.TabIndex = 0;
            this.ml_expectations_title.Text = "Expectations";
            // 
            // lbl_expectations_desc
            // 
            this.lbl_expectations_desc.AutoSize = true;
            this.lbl_expectations_desc.Location = new System.Drawing.Point(126, 76);
            this.lbl_expectations_desc.Name = "lbl_expectations_desc";
            this.lbl_expectations_desc.Size = new System.Drawing.Size(89, 20);
            this.lbl_expectations_desc.TabIndex = 1;
            this.lbl_expectations_desc.Text = "Description";
            // 
            // ml_perks_title
            // 
            this.ml_perks_title.AutoSize = true;
            this.ml_perks_title.Depth = 0;
            this.ml_perks_title.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_perks_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_perks_title.Location = new System.Drawing.Point(515, 29);
            this.ml_perks_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_perks_title.Name = "ml_perks_title";
            this.ml_perks_title.Size = new System.Drawing.Size(67, 27);
            this.ml_perks_title.TabIndex = 0;
            this.ml_perks_title.Text = "Perks";
            // 
            // lbl_perks_desc
            // 
            this.lbl_perks_desc.AutoSize = true;
            this.lbl_perks_desc.Location = new System.Drawing.Point(130, 75);
            this.lbl_perks_desc.Name = "lbl_perks_desc";
            this.lbl_perks_desc.Size = new System.Drawing.Size(89, 20);
            this.lbl_perks_desc.TabIndex = 1;
            this.lbl_perks_desc.Text = "Description";
            // 
            // ml_apply_title
            // 
            this.ml_apply_title.AutoSize = true;
            this.ml_apply_title.Depth = 0;
            this.ml_apply_title.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_apply_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_apply_title.Location = new System.Drawing.Point(530, 34);
            this.ml_apply_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_apply_title.Name = "ml_apply_title";
            this.ml_apply_title.Size = new System.Drawing.Size(65, 27);
            this.ml_apply_title.TabIndex = 0;
            this.ml_apply_title.Text = "Apply";
            // 
            // lbl_apply_desc
            // 
            this.lbl_apply_desc.AutoSize = true;
            this.lbl_apply_desc.Location = new System.Drawing.Point(298, 83);
            this.lbl_apply_desc.Name = "lbl_apply_desc";
            this.lbl_apply_desc.Size = new System.Drawing.Size(89, 20);
            this.lbl_apply_desc.TabIndex = 1;
            this.lbl_apply_desc.Text = "Description";
            // 
            // ll_applyLink
            // 
            this.ll_applyLink.AutoSize = true;
            this.ll_applyLink.Location = new System.Drawing.Point(444, 165);
            this.ll_applyLink.Name = "ll_applyLink";
            this.ll_applyLink.Size = new System.Drawing.Size(234, 20);
            this.ll_applyLink.TabIndex = 2;
            this.ll_applyLink.TabStop = true;
            this.ll_applyLink.Text = "http://goo.gl/forms/PIL1T1JGdm";
            this.ll_applyLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_applyLink_LinkClicked);
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.Location = new System.Drawing.Point(92, 293);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(43, 20);
            this.lbl_note.TabIndex = 3;
            this.lbl_note.Text = "Note";
            // 
            // StudentAmbassadorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 967);
            this.Controls.Add(this.tb_studentAMB);
            this.Controls.Add(this.pb_studentAMB);
            this.Controls.Add(this.ml_studentAMBTitle);
            this.Name = "StudentAmbassadorsForm";
            this.Text = "StudentAmbassadorsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pb_studentAMB)).EndInit();
            this.tb_studentAMB.ResumeLayout(false);
            this.tb_Mission.ResumeLayout(false);
            this.tb_Mission.PerformLayout();
            this.tb_overview.ResumeLayout(false);
            this.tb_overview.PerformLayout();
            this.tb_criteria.ResumeLayout(false);
            this.tb_criteria.PerformLayout();
            this.tb_Duties.ResumeLayout(false);
            this.tb_Duties.PerformLayout();
            this.tb_expectations.ResumeLayout(false);
            this.tb_expectations.PerformLayout();
            this.tb_perks.ResumeLayout(false);
            this.tb_perks.PerformLayout();
            this.tb_apply.ResumeLayout(false);
            this.tb_apply.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel ml_studentAMBTitle;
        private System.Windows.Forms.PictureBox pb_studentAMB;
        private System.Windows.Forms.TabControl tb_studentAMB;
        private System.Windows.Forms.TabPage tb_Mission;
        private System.Windows.Forms.TabPage tb_overview;
        private System.Windows.Forms.TabPage tb_criteria;
        private System.Windows.Forms.TabPage tb_Duties;
        private System.Windows.Forms.TabPage tb_expectations;
        private System.Windows.Forms.TabPage tb_perks;
        private System.Windows.Forms.TabPage tb_apply;
        private System.Windows.Forms.Label lbl_mission_desc;
        private MaterialSkin.Controls.MaterialLabel ml_missionTitle;
        private MaterialSkin.Controls.MaterialLabel ml_overviewTitle;
        private System.Windows.Forms.Label lbl_overview_Desc;
        private System.Windows.Forms.Label lbl_criteria_desc;
        private MaterialSkin.Controls.MaterialLabel ml_criteria_title;
        private System.Windows.Forms.Label lbl_duties_desc;
        private MaterialSkin.Controls.MaterialLabel ml_duties_title;
        private System.Windows.Forms.Label lbl_expectations_desc;
        private MaterialSkin.Controls.MaterialLabel ml_expectations_title;
        private System.Windows.Forms.Label lbl_perks_desc;
        private MaterialSkin.Controls.MaterialLabel ml_perks_title;
        private System.Windows.Forms.Label lbl_apply_desc;
        private MaterialSkin.Controls.MaterialLabel ml_apply_title;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.LinkLabel ll_applyLink;
    }
}