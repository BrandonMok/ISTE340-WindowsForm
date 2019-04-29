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
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.SuspendLayout();
            // 
            // ml_eachResearch_sectionTitle
            // 
            this.ml_eachResearch_sectionTitle.AutoSize = true;
            this.ml_eachResearch_sectionTitle.Depth = 0;
            this.ml_eachResearch_sectionTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_eachResearch_sectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_eachResearch_sectionTitle.Location = new System.Drawing.Point(496, 109);
            this.ml_eachResearch_sectionTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_eachResearch_sectionTitle.Name = "ml_eachResearch_sectionTitle";
            this.ml_eachResearch_sectionTitle.Size = new System.Drawing.Size(168, 27);
            this.ml_eachResearch_sectionTitle.TabIndex = 0;
            this.ml_eachResearch_sectionTitle.Text = "Research Name";
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(63, 163);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(1072, 486);
            this.materialListView1.TabIndex = 1;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // EachResearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 680);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.ml_eachResearch_sectionTitle);
            this.Name = "EachResearch";
            this.Text = "EachResearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel ml_eachResearch_sectionTitle;
        private MaterialSkin.Controls.MaterialListView materialListView1;
    }
}