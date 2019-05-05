namespace MokP3
{
    partial class EachMinor
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
            this.lbl_specific_minor_Title = new System.Windows.Forms.Label();
            this.lbl_specific_minor_desc = new System.Windows.Forms.Label();
            this.lbl_specific_minor_concentrationHeader = new System.Windows.Forms.Label();
            this.lbl_specific_minor_note = new System.Windows.Forms.Label();
            this.panel_minor_desc = new System.Windows.Forms.Panel();
            this.panel_minor_note = new System.Windows.Forms.Panel();
            this.panel_concentrations = new System.Windows.Forms.Panel();
            this.ml_minor_name = new MaterialSkin.Controls.MaterialLabel();
            this.panel_concList = new System.Windows.Forms.Panel();
            this.panel_minor_desc.SuspendLayout();
            this.panel_minor_note.SuspendLayout();
            this.panel_concentrations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_specific_minor_Title
            // 
            this.lbl_specific_minor_Title.AutoSize = true;
            this.lbl_specific_minor_Title.Location = new System.Drawing.Point(241, 152);
            this.lbl_specific_minor_Title.Name = "lbl_specific_minor_Title";
            this.lbl_specific_minor_Title.Size = new System.Drawing.Size(81, 20);
            this.lbl_specific_minor_Title.TabIndex = 1;
            this.lbl_specific_minor_Title.Text = "Minor Title";
            // 
            // lbl_specific_minor_desc
            // 
            this.lbl_specific_minor_desc.AutoSize = true;
            this.lbl_specific_minor_desc.Location = new System.Drawing.Point(-4, 0);
            this.lbl_specific_minor_desc.Name = "lbl_specific_minor_desc";
            this.lbl_specific_minor_desc.Size = new System.Drawing.Size(132, 20);
            this.lbl_specific_minor_desc.TabIndex = 2;
            this.lbl_specific_minor_desc.Text = "Minor Description";
            // 
            // lbl_specific_minor_concentrationHeader
            // 
            this.lbl_specific_minor_concentrationHeader.AutoSize = true;
            this.lbl_specific_minor_concentrationHeader.Location = new System.Drawing.Point(23, 13);
            this.lbl_specific_minor_concentrationHeader.Name = "lbl_specific_minor_concentrationHeader";
            this.lbl_specific_minor_concentrationHeader.Size = new System.Drawing.Size(117, 20);
            this.lbl_specific_minor_concentrationHeader.TabIndex = 4;
            this.lbl_specific_minor_concentrationHeader.Text = "Concentrations";
            // 
            // lbl_specific_minor_note
            // 
            this.lbl_specific_minor_note.AutoSize = true;
            this.lbl_specific_minor_note.Location = new System.Drawing.Point(13, 18);
            this.lbl_specific_minor_note.Name = "lbl_specific_minor_note";
            this.lbl_specific_minor_note.Size = new System.Drawing.Size(0, 20);
            this.lbl_specific_minor_note.TabIndex = 5;
            // 
            // panel_minor_desc
            // 
            this.panel_minor_desc.Controls.Add(this.lbl_specific_minor_desc);
            this.panel_minor_desc.Location = new System.Drawing.Point(47, 185);
            this.panel_minor_desc.Name = "panel_minor_desc";
            this.panel_minor_desc.Size = new System.Drawing.Size(869, 246);
            this.panel_minor_desc.TabIndex = 6;
            // 
            // panel_minor_note
            // 
            this.panel_minor_note.Controls.Add(this.lbl_specific_minor_note);
            this.panel_minor_note.Location = new System.Drawing.Point(47, 671);
            this.panel_minor_note.Name = "panel_minor_note";
            this.panel_minor_note.Size = new System.Drawing.Size(860, 83);
            this.panel_minor_note.TabIndex = 7;
            // 
            // panel_concentrations
            // 
            this.panel_concentrations.Controls.Add(this.panel_concList);
            this.panel_concentrations.Controls.Add(this.lbl_specific_minor_concentrationHeader);
            this.panel_concentrations.Location = new System.Drawing.Point(270, 437);
            this.panel_concentrations.Name = "panel_concentrations";
            this.panel_concentrations.Size = new System.Drawing.Size(326, 228);
            this.panel_concentrations.TabIndex = 8;
            // 
            // ml_minor_name
            // 
            this.ml_minor_name.AutoSize = true;
            this.ml_minor_name.Depth = 0;
            this.ml_minor_name.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_minor_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_minor_name.Location = new System.Drawing.Point(332, 106);
            this.ml_minor_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_minor_name.Name = "ml_minor_name";
            this.ml_minor_name.Size = new System.Drawing.Size(132, 27);
            this.ml_minor_name.TabIndex = 9;
            this.ml_minor_name.Text = "Minor Name";
            // 
            // panel_concList
            // 
            this.panel_concList.Location = new System.Drawing.Point(0, 36);
            this.panel_concList.Name = "panel_concList";
            this.panel_concList.Size = new System.Drawing.Size(326, 178);
            this.panel_concList.TabIndex = 10;
            // 
            // EachMinor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 780);
            this.Controls.Add(this.ml_minor_name);
            this.Controls.Add(this.panel_concentrations);
            this.Controls.Add(this.panel_minor_note);
            this.Controls.Add(this.panel_minor_desc);
            this.Controls.Add(this.lbl_specific_minor_Title);
            this.Name = "EachMinor";
            this.Text = "EachMinor";
            this.panel_minor_desc.ResumeLayout(false);
            this.panel_minor_desc.PerformLayout();
            this.panel_minor_note.ResumeLayout(false);
            this.panel_minor_note.PerformLayout();
            this.panel_concentrations.ResumeLayout(false);
            this.panel_concentrations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_specific_minor_Title;
        private System.Windows.Forms.Label lbl_specific_minor_desc;
        private System.Windows.Forms.Label lbl_specific_minor_concentrationHeader;
        private System.Windows.Forms.Label lbl_specific_minor_note;
        private System.Windows.Forms.Panel panel_minor_desc;
        private System.Windows.Forms.Panel panel_minor_note;
        private System.Windows.Forms.Panel panel_concentrations;
        private MaterialSkin.Controls.MaterialLabel ml_minor_name;
        private System.Windows.Forms.Panel panel_concList;
    }
}