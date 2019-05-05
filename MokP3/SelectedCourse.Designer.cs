namespace MokP3
{
    partial class SelectedCourse
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
            this.ml_course_title = new MaterialSkin.Controls.MaterialLabel();
            this.ml_course_ID = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_course_desc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ml_course_title
            // 
            this.ml_course_title.AutoSize = true;
            this.ml_course_title.Depth = 0;
            this.ml_course_title.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_course_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_course_title.Location = new System.Drawing.Point(240, 117);
            this.ml_course_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_course_title.Name = "ml_course_title";
            this.ml_course_title.Size = new System.Drawing.Size(128, 27);
            this.ml_course_title.TabIndex = 0;
            this.ml_course_title.Text = "Course Title";
            // 
            // ml_course_ID
            // 
            this.ml_course_ID.AutoSize = true;
            this.ml_course_ID.Depth = 0;
            this.ml_course_ID.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_course_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_course_ID.Location = new System.Drawing.Point(309, 168);
            this.ml_course_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_course_ID.Name = "ml_course_ID";
            this.ml_course_ID.Size = new System.Drawing.Size(101, 27);
            this.ml_course_ID.TabIndex = 1;
            this.ml_course_ID.Text = "CourseID";
            // 
            // lbl_course_desc
            // 
            this.lbl_course_desc.AutoSize = true;
            this.lbl_course_desc.Location = new System.Drawing.Point(59, 222);
            this.lbl_course_desc.Name = "lbl_course_desc";
            this.lbl_course_desc.Size = new System.Drawing.Size(89, 20);
            this.lbl_course_desc.TabIndex = 2;
            this.lbl_course_desc.Text = "Description";
            // 
            // SelectedCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 548);
            this.Controls.Add(this.lbl_course_desc);
            this.Controls.Add(this.ml_course_ID);
            this.Controls.Add(this.ml_course_title);
            this.Name = "SelectedCourse";
            this.Text = "SelectedCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel ml_course_title;
        private MaterialSkin.Controls.MaterialLabel ml_course_ID;
        private System.Windows.Forms.Label lbl_course_desc;
    }
}