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
            this.lbl_tables_employment = new System.Windows.Forms.Label();
            this.lbl_tables_coop = new System.Windows.Forms.Label();
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
            // lbl_tables_employment
            // 
            this.lbl_tables_employment.AutoSize = true;
            this.lbl_tables_employment.Location = new System.Drawing.Point(520, 131);
            this.lbl_tables_employment.Name = "lbl_tables_employment";
            this.lbl_tables_employment.Size = new System.Drawing.Size(140, 20);
            this.lbl_tables_employment.TabIndex = 14;
            this.lbl_tables_employment.Text = "Employment Table";
            // 
            // lbl_tables_coop
            // 
            this.lbl_tables_coop.AutoSize = true;
            this.lbl_tables_coop.Location = new System.Drawing.Point(529, 446);
            this.lbl_tables_coop.Name = "lbl_tables_coop";
            this.lbl_tables_coop.Size = new System.Drawing.Size(90, 20);
            this.lbl_tables_coop.TabIndex = 15;
            this.lbl_tables_coop.Text = "Coop Table";
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1241, 782);
            this.Controls.Add(this.lbl_tables_coop);
            this.Controls.Add(this.lbl_tables_employment);
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
        private System.Windows.Forms.Label lbl_tables_employment;
        private System.Windows.Forms.Label lbl_tables_coop;
    }
}