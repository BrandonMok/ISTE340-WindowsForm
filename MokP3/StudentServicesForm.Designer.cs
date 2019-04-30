namespace MokP3
{
    partial class StudentServicesForm
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
            this.ml_studentServices_title = new MaterialSkin.Controls.MaterialLabel();
            this.panel_advisors_container = new System.Windows.Forms.Panel();
            this.mb_academicAdvisor = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mb_professionalAdvisors = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mb_facultyAdvisors = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mb_ISTMinorsAdvisors = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // ml_studentServices_title
            // 
            this.ml_studentServices_title.AutoSize = true;
            this.ml_studentServices_title.Depth = 0;
            this.ml_studentServices_title.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_studentServices_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_studentServices_title.Location = new System.Drawing.Point(577, 108);
            this.ml_studentServices_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_studentServices_title.Name = "ml_studentServices_title";
            this.ml_studentServices_title.Size = new System.Drawing.Size(94, 27);
            this.ml_studentServices_title.TabIndex = 0;
            this.ml_studentServices_title.Text = "Advising";
            // 
            // panel_advisors_container
            // 
            this.panel_advisors_container.Location = new System.Drawing.Point(12, 205);
            this.panel_advisors_container.Name = "panel_advisors_container";
            this.panel_advisors_container.Size = new System.Drawing.Size(1213, 672);
            this.panel_advisors_container.TabIndex = 2;
            // 
            // mb_academicAdvisor
            // 
            this.mb_academicAdvisor.AutoSize = true;
            this.mb_academicAdvisor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mb_academicAdvisor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mb_academicAdvisor.Depth = 0;
            this.mb_academicAdvisor.Icon = null;
            this.mb_academicAdvisor.Location = new System.Drawing.Point(86, 153);
            this.mb_academicAdvisor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mb_academicAdvisor.Name = "mb_academicAdvisor";
            this.mb_academicAdvisor.Primary = true;
            this.mb_academicAdvisor.Size = new System.Drawing.Size(230, 36);
            this.mb_academicAdvisor.TabIndex = 3;
            this.mb_academicAdvisor.Text = "Academic Advisors";
            this.mb_academicAdvisor.UseVisualStyleBackColor = true;
            this.mb_academicAdvisor.Click += new System.EventHandler(this.mb_academicAdvisor_Click);
            // 
            // mb_professionalAdvisors
            // 
            this.mb_professionalAdvisors.AutoSize = true;
            this.mb_professionalAdvisors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mb_professionalAdvisors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mb_professionalAdvisors.Depth = 0;
            this.mb_professionalAdvisors.Icon = null;
            this.mb_professionalAdvisors.Location = new System.Drawing.Point(347, 153);
            this.mb_professionalAdvisors.MouseState = MaterialSkin.MouseState.HOVER;
            this.mb_professionalAdvisors.Name = "mb_professionalAdvisors";
            this.mb_professionalAdvisors.Primary = true;
            this.mb_professionalAdvisors.Size = new System.Drawing.Size(274, 36);
            this.mb_professionalAdvisors.TabIndex = 4;
            this.mb_professionalAdvisors.Text = "Professional Advisors";
            this.mb_professionalAdvisors.UseVisualStyleBackColor = true;
            // 
            // mb_facultyAdvisors
            // 
            this.mb_facultyAdvisors.AutoSize = true;
            this.mb_facultyAdvisors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mb_facultyAdvisors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mb_facultyAdvisors.Depth = 0;
            this.mb_facultyAdvisors.Icon = null;
            this.mb_facultyAdvisors.Location = new System.Drawing.Point(658, 153);
            this.mb_facultyAdvisors.MouseState = MaterialSkin.MouseState.HOVER;
            this.mb_facultyAdvisors.Name = "mb_facultyAdvisors";
            this.mb_facultyAdvisors.Primary = true;
            this.mb_facultyAdvisors.Size = new System.Drawing.Size(215, 36);
            this.mb_facultyAdvisors.TabIndex = 5;
            this.mb_facultyAdvisors.Text = "Faculty Advisors";
            this.mb_facultyAdvisors.UseVisualStyleBackColor = true;
            // 
            // mb_ISTMinorsAdvisors
            // 
            this.mb_ISTMinorsAdvisors.AutoSize = true;
            this.mb_ISTMinorsAdvisors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mb_ISTMinorsAdvisors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mb_ISTMinorsAdvisors.Depth = 0;
            this.mb_ISTMinorsAdvisors.Icon = null;
            this.mb_ISTMinorsAdvisors.Location = new System.Drawing.Point(923, 153);
            this.mb_ISTMinorsAdvisors.MouseState = MaterialSkin.MouseState.HOVER;
            this.mb_ISTMinorsAdvisors.Name = "mb_ISTMinorsAdvisors";
            this.mb_ISTMinorsAdvisors.Primary = true;
            this.mb_ISTMinorsAdvisors.Size = new System.Drawing.Size(223, 36);
            this.mb_ISTMinorsAdvisors.TabIndex = 6;
            this.mb_ISTMinorsAdvisors.Text = "IST Minor Advising";
            this.mb_ISTMinorsAdvisors.UseVisualStyleBackColor = true;
            // 
            // StudentServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 889);
            this.Controls.Add(this.mb_ISTMinorsAdvisors);
            this.Controls.Add(this.mb_facultyAdvisors);
            this.Controls.Add(this.mb_professionalAdvisors);
            this.Controls.Add(this.mb_academicAdvisor);
            this.Controls.Add(this.panel_advisors_container);
            this.Controls.Add(this.ml_studentServices_title);
            this.Name = "StudentServicesForm";
            this.Text = "StudentServicesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel ml_studentServices_title;
        private System.Windows.Forms.Panel panel_advisors_container;
        private MaterialSkin.Controls.MaterialRaisedButton mb_academicAdvisor;
        private MaterialSkin.Controls.MaterialRaisedButton mb_professionalAdvisors;
        private MaterialSkin.Controls.MaterialRaisedButton mb_facultyAdvisors;
        private MaterialSkin.Controls.MaterialRaisedButton mb_ISTMinorsAdvisors;
    }
}