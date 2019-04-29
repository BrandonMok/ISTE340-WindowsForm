namespace MokP3
{
    partial class EachResearch
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
            this.ml_eachResearch_sectionTitle = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ml_eachResearch_sectionTitle
            // 
            this.ml_eachResearch_sectionTitle.AutoSize = true;
            this.ml_eachResearch_sectionTitle.Depth = 0;
            this.ml_eachResearch_sectionTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_eachResearch_sectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_eachResearch_sectionTitle.Location = new System.Drawing.Point(468, 89);
            this.ml_eachResearch_sectionTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_eachResearch_sectionTitle.Name = "ml_eachResearch_sectionTitle";
            this.ml_eachResearch_sectionTitle.Size = new System.Drawing.Size(168, 27);
            this.ml_eachResearch_sectionTitle.TabIndex = 0;
            this.ml_eachResearch_sectionTitle.Text = "Research Name";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(32, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 402);
            this.panel1.TabIndex = 1;
            // 
            // EachResearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ml_eachResearch_sectionTitle);
            this.Name = "EachResearch";
            this.Text = "EachResearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel ml_eachResearch_sectionTitle;
        private System.Windows.Forms.Panel panel1;
    }
}