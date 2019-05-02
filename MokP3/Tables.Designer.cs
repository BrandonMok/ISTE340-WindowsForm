namespace MokP3
{
    partial class Tables
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
            this.listView_Employment = new System.Windows.Forms.ListView();
            this.listView_Coop = new System.Windows.Forms.ListView();
            this.ml_employmentTable_title = new MaterialSkin.Controls.MaterialLabel();
            this.ml_coopTable_title = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // listView_Employment
            // 
            this.listView_Employment.Location = new System.Drawing.Point(72, 165);
            this.listView_Employment.Name = "listView_Employment";
            this.listView_Employment.Size = new System.Drawing.Size(1039, 237);
            this.listView_Employment.TabIndex = 12;
            this.listView_Employment.UseCompatibleStateImageBehavior = false;
            // 
            // listView_Coop
            // 
            this.listView_Coop.Location = new System.Drawing.Point(63, 491);
            this.listView_Coop.Name = "listView_Coop";
            this.listView_Coop.Size = new System.Drawing.Size(1039, 237);
            this.listView_Coop.TabIndex = 13;
            this.listView_Coop.UseCompatibleStateImageBehavior = false;
            // 
            // ml_employmentTable_title
            // 
            this.ml_employmentTable_title.AutoSize = true;
            this.ml_employmentTable_title.Depth = 0;
            this.ml_employmentTable_title.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_employmentTable_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_employmentTable_title.Location = new System.Drawing.Point(498, 119);
            this.ml_employmentTable_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_employmentTable_title.Name = "ml_employmentTable_title";
            this.ml_employmentTable_title.Size = new System.Drawing.Size(193, 27);
            this.ml_employmentTable_title.TabIndex = 16;
            this.ml_employmentTable_title.Text = "Employment Table";
            // 
            // ml_coopTable_title
            // 
            this.ml_coopTable_title.AutoSize = true;
            this.ml_coopTable_title.Depth = 0;
            this.ml_coopTable_title.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_coopTable_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_coopTable_title.Location = new System.Drawing.Point(521, 444);
            this.ml_coopTable_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_coopTable_title.Name = "ml_coopTable_title";
            this.ml_coopTable_title.Size = new System.Drawing.Size(123, 27);
            this.ml_coopTable_title.TabIndex = 17;
            this.ml_coopTable_title.Text = "Coop Table";
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1241, 782);
            this.Controls.Add(this.ml_coopTable_title);
            this.Controls.Add(this.ml_employmentTable_title);
            this.Controls.Add(this.listView_Coop);
            this.Controls.Add(this.listView_Employment);
            this.Name = "Tables";
            this.Text = "Tables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Employment;
        private System.Windows.Forms.ListView listView_Coop;
        private MaterialSkin.Controls.MaterialLabel ml_employmentTable_title;
        private MaterialSkin.Controls.MaterialLabel ml_coopTable_title;
    }
}