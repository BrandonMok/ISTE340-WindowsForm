namespace MokP3
{
    partial class EachDegree
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
            this.lbl_specific_degreeName = new System.Windows.Forms.Label();
            this.lbl_specific_degreeTitle = new System.Windows.Forms.Label();
            this.lbl_specific_degreeDescription = new System.Windows.Forms.Label();
            this.lbl_specific_degreeConcentrations = new System.Windows.Forms.Label();
            this.lbl_Concentrations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_specific_degreeName
            // 
            this.lbl_specific_degreeName.AutoSize = true;
            this.lbl_specific_degreeName.Location = new System.Drawing.Point(349, 113);
            this.lbl_specific_degreeName.Name = "lbl_specific_degreeName";
            this.lbl_specific_degreeName.Size = new System.Drawing.Size(108, 20);
            this.lbl_specific_degreeName.TabIndex = 0;
            this.lbl_specific_degreeName.Text = "Degree Name";
            // 
            // lbl_specific_degreeTitle
            // 
            this.lbl_specific_degreeTitle.AutoSize = true;
            this.lbl_specific_degreeTitle.Location = new System.Drawing.Point(254, 163);
            this.lbl_specific_degreeTitle.Name = "lbl_specific_degreeTitle";
            this.lbl_specific_degreeTitle.Size = new System.Drawing.Size(95, 20);
            this.lbl_specific_degreeTitle.TabIndex = 1;
            this.lbl_specific_degreeTitle.Text = "Degree Title";
            // 
            // lbl_specific_degreeDescription
            // 
            this.lbl_specific_degreeDescription.AutoSize = true;
            this.lbl_specific_degreeDescription.Location = new System.Drawing.Point(168, 229);
            this.lbl_specific_degreeDescription.Name = "lbl_specific_degreeDescription";
            this.lbl_specific_degreeDescription.Size = new System.Drawing.Size(146, 20);
            this.lbl_specific_degreeDescription.TabIndex = 2;
            this.lbl_specific_degreeDescription.Text = "Degree Description";
            // 
            // lbl_specific_degreeConcentrations
            // 
            this.lbl_specific_degreeConcentrations.AutoSize = true;
            this.lbl_specific_degreeConcentrations.Location = new System.Drawing.Point(267, 367);
            this.lbl_specific_degreeConcentrations.Name = "lbl_specific_degreeConcentrations";
            this.lbl_specific_degreeConcentrations.Size = new System.Drawing.Size(164, 20);
            this.lbl_specific_degreeConcentrations.TabIndex = 3;
            this.lbl_specific_degreeConcentrations.Text = "List of Concentrations";
            // 
            // lbl_Concentrations
            // 
            this.lbl_Concentrations.AutoSize = true;
            this.lbl_Concentrations.Location = new System.Drawing.Point(267, 326);
            this.lbl_Concentrations.Name = "lbl_Concentrations";
            this.lbl_Concentrations.Size = new System.Drawing.Size(121, 20);
            this.lbl_Concentrations.TabIndex = 4;
            this.lbl_Concentrations.Text = "Concentrations:";
            // 
            // EachDegree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Concentrations);
            this.Controls.Add(this.lbl_specific_degreeConcentrations);
            this.Controls.Add(this.lbl_specific_degreeDescription);
            this.Controls.Add(this.lbl_specific_degreeTitle);
            this.Controls.Add(this.lbl_specific_degreeName);
            this.Name = "EachDegree";
            this.Text = "EachDegree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_specific_degreeName;
        private System.Windows.Forms.Label lbl_specific_degreeTitle;
        private System.Windows.Forms.Label lbl_specific_degreeDescription;
        private System.Windows.Forms.Label lbl_specific_degreeConcentrations;
        private System.Windows.Forms.Label lbl_Concentrations;
    }
}