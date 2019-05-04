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
            this.lbl_specific_degreeDescription = new System.Windows.Forms.Label();
            this.lbl_specific_degreeConcentrations = new System.Windows.Forms.Label();
            this.lbl_Concentrations = new System.Windows.Forms.Label();
            this.ml_degree_title = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lbl_specific_degreeDescription
            // 
            this.lbl_specific_degreeDescription.AutoSize = true;
            this.lbl_specific_degreeDescription.Location = new System.Drawing.Point(160, 167);
            this.lbl_specific_degreeDescription.Name = "lbl_specific_degreeDescription";
            this.lbl_specific_degreeDescription.Size = new System.Drawing.Size(146, 20);
            this.lbl_specific_degreeDescription.TabIndex = 2;
            this.lbl_specific_degreeDescription.Text = "Degree Description";
            // 
            // lbl_specific_degreeConcentrations
            // 
            this.lbl_specific_degreeConcentrations.AutoSize = true;
            this.lbl_specific_degreeConcentrations.Location = new System.Drawing.Point(258, 320);
            this.lbl_specific_degreeConcentrations.Name = "lbl_specific_degreeConcentrations";
            this.lbl_specific_degreeConcentrations.Size = new System.Drawing.Size(164, 20);
            this.lbl_specific_degreeConcentrations.TabIndex = 3;
            this.lbl_specific_degreeConcentrations.Text = "List of Concentrations";
            // 
            // lbl_Concentrations
            // 
            this.lbl_Concentrations.AutoSize = true;
            this.lbl_Concentrations.Location = new System.Drawing.Point(258, 279);
            this.lbl_Concentrations.Name = "lbl_Concentrations";
            this.lbl_Concentrations.Size = new System.Drawing.Size(121, 20);
            this.lbl_Concentrations.TabIndex = 4;
            this.lbl_Concentrations.Text = "Concentrations:";
            // 
            // ml_degree_title
            // 
            this.ml_degree_title.AutoSize = true;
            this.ml_degree_title.Depth = 0;
            this.ml_degree_title.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_degree_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_degree_title.Location = new System.Drawing.Point(219, 117);
            this.ml_degree_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_degree_title.Name = "ml_degree_title";
            this.ml_degree_title.Size = new System.Drawing.Size(128, 27);
            this.ml_degree_title.TabIndex = 5;
            this.ml_degree_title.Text = "Degree Title";
            // 
            // EachDegree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 505);
            this.Controls.Add(this.ml_degree_title);
            this.Controls.Add(this.lbl_Concentrations);
            this.Controls.Add(this.lbl_specific_degreeConcentrations);
            this.Controls.Add(this.lbl_specific_degreeDescription);
            this.Name = "EachDegree";
            this.Text = "EachDegree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_specific_degreeDescription;
        private System.Windows.Forms.Label lbl_specific_degreeConcentrations;
        private System.Windows.Forms.Label lbl_Concentrations;
        private MaterialSkin.Controls.MaterialLabel ml_degree_title;
    }
}