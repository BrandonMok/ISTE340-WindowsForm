namespace MokP3
{
    partial class FormsForm
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
            this.ml_graduateForms = new MaterialSkin.Controls.MaterialLabel();
            this.panel_gForms = new System.Windows.Forms.Panel();
            this.ml_undergradFrom_title = new MaterialSkin.Controls.MaterialLabel();
            this.panel_undergradFroms = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ml_graduateForms
            // 
            this.ml_graduateForms.AutoSize = true;
            this.ml_graduateForms.Depth = 0;
            this.ml_graduateForms.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_graduateForms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_graduateForms.Location = new System.Drawing.Point(450, 106);
            this.ml_graduateForms.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_graduateForms.Name = "ml_graduateForms";
            this.ml_graduateForms.Size = new System.Drawing.Size(168, 27);
            this.ml_graduateForms.TabIndex = 0;
            this.ml_graduateForms.Text = "Graduate Forms";
            // 
            // panel_gForms
            // 
            this.panel_gForms.Location = new System.Drawing.Point(38, 146);
            this.panel_gForms.Name = "panel_gForms";
            this.panel_gForms.Size = new System.Drawing.Size(1045, 314);
            this.panel_gForms.TabIndex = 1;
            // 
            // ml_undergradFrom_title
            // 
            this.ml_undergradFrom_title.AutoSize = true;
            this.ml_undergradFrom_title.Depth = 0;
            this.ml_undergradFrom_title.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_undergradFrom_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_undergradFrom_title.Location = new System.Drawing.Point(425, 501);
            this.ml_undergradFrom_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_undergradFrom_title.Name = "ml_undergradFrom_title";
            this.ml_undergradFrom_title.Size = new System.Drawing.Size(222, 27);
            this.ml_undergradFrom_title.TabIndex = 2;
            this.ml_undergradFrom_title.Text = "Undergraduate Forms";
            // 
            // panel_undergradFroms
            // 
            this.panel_undergradFroms.Location = new System.Drawing.Point(38, 547);
            this.panel_undergradFroms.Name = "panel_undergradFroms";
            this.panel_undergradFroms.Size = new System.Drawing.Size(1045, 186);
            this.panel_undergradFroms.TabIndex = 3;
            // 
            // FormsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 754);
            this.Controls.Add(this.panel_undergradFroms);
            this.Controls.Add(this.ml_undergradFrom_title);
            this.Controls.Add(this.panel_gForms);
            this.Controls.Add(this.ml_graduateForms);
            this.Name = "FormsForm";
            this.Text = "FormsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel ml_graduateForms;
        private System.Windows.Forms.Panel panel_gForms;
        private MaterialSkin.Controls.MaterialLabel ml_undergradFrom_title;
        private System.Windows.Forms.Panel panel_undergradFroms;
    }
}