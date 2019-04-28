namespace MokP3
{
    partial class FacStaff
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
            this.ml_people_username = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_people_name = new System.Windows.Forms.Label();
            this.pb_indv_personImage = new System.Windows.Forms.PictureBox();
            this.lbl_tagline = new System.Windows.Forms.Label();
            this.lbl_people_title = new System.Windows.Forms.Label();
            this.lbl_people_office = new System.Windows.Forms.Label();
            this.lbl_people_interestArea = new System.Windows.Forms.Label();
            this.lbl_people_phone = new System.Windows.Forms.Label();
            this.lbl_people_email = new System.Windows.Forms.Label();
            this.ll_website = new System.Windows.Forms.LinkLabel();
            this.panel_contactInfo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_indv_personImage)).BeginInit();
            this.panel_contactInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ml_people_username
            // 
            this.ml_people_username.AutoSize = true;
            this.ml_people_username.Depth = 0;
            this.ml_people_username.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_people_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_people_username.Location = new System.Drawing.Point(353, 131);
            this.ml_people_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_people_username.Name = "ml_people_username";
            this.ml_people_username.Size = new System.Drawing.Size(115, 27);
            this.ml_people_username.TabIndex = 0;
            this.ml_people_username.Text = "UserName";
            // 
            // lbl_people_name
            // 
            this.lbl_people_name.AutoSize = true;
            this.lbl_people_name.Location = new System.Drawing.Point(343, 197);
            this.lbl_people_name.Name = "lbl_people_name";
            this.lbl_people_name.Size = new System.Drawing.Size(51, 20);
            this.lbl_people_name.TabIndex = 1;
            this.lbl_people_name.Text = "Name";
            // 
            // pb_indv_personImage
            // 
            this.pb_indv_personImage.Location = new System.Drawing.Point(327, 240);
            this.pb_indv_personImage.Name = "pb_indv_personImage";
            this.pb_indv_personImage.Size = new System.Drawing.Size(172, 152);
            this.pb_indv_personImage.TabIndex = 2;
            this.pb_indv_personImage.TabStop = false;
            // 
            // lbl_tagline
            // 
            this.lbl_tagline.AutoSize = true;
            this.lbl_tagline.Location = new System.Drawing.Point(327, 408);
            this.lbl_tagline.Name = "lbl_tagline";
            this.lbl_tagline.Size = new System.Drawing.Size(51, 20);
            this.lbl_tagline.TabIndex = 3;
            this.lbl_tagline.Text = "label1";
            // 
            // lbl_people_title
            // 
            this.lbl_people_title.AutoSize = true;
            this.lbl_people_title.Location = new System.Drawing.Point(327, 451);
            this.lbl_people_title.Name = "lbl_people_title";
            this.lbl_people_title.Size = new System.Drawing.Size(51, 20);
            this.lbl_people_title.TabIndex = 4;
            this.lbl_people_title.Text = "label1";
            // 
            // lbl_people_office
            // 
            this.lbl_people_office.AutoSize = true;
            this.lbl_people_office.Location = new System.Drawing.Point(17, 24);
            this.lbl_people_office.Name = "lbl_people_office";
            this.lbl_people_office.Size = new System.Drawing.Size(51, 20);
            this.lbl_people_office.TabIndex = 5;
            this.lbl_people_office.Text = "Office";
            // 
            // lbl_people_interestArea
            // 
            this.lbl_people_interestArea.AutoSize = true;
            this.lbl_people_interestArea.Location = new System.Drawing.Point(327, 495);
            this.lbl_people_interestArea.Name = "lbl_people_interestArea";
            this.lbl_people_interestArea.Size = new System.Drawing.Size(102, 20);
            this.lbl_people_interestArea.TabIndex = 6;
            this.lbl_people_interestArea.Text = "Interest Area";
            // 
            // lbl_people_phone
            // 
            this.lbl_people_phone.AutoSize = true;
            this.lbl_people_phone.Location = new System.Drawing.Point(17, 70);
            this.lbl_people_phone.Name = "lbl_people_phone";
            this.lbl_people_phone.Size = new System.Drawing.Size(55, 20);
            this.lbl_people_phone.TabIndex = 8;
            this.lbl_people_phone.Text = "Phone";
            // 
            // lbl_people_email
            // 
            this.lbl_people_email.AutoSize = true;
            this.lbl_people_email.Location = new System.Drawing.Point(20, 117);
            this.lbl_people_email.Name = "lbl_people_email";
            this.lbl_people_email.Size = new System.Drawing.Size(48, 20);
            this.lbl_people_email.TabIndex = 9;
            this.lbl_people_email.Text = "Email";
            // 
            // ll_website
            // 
            this.ll_website.AutoSize = true;
            this.ll_website.Location = new System.Drawing.Point(20, 150);
            this.ll_website.Name = "ll_website";
            this.ll_website.Size = new System.Drawing.Size(67, 20);
            this.ll_website.TabIndex = 10;
            this.ll_website.TabStop = true;
            this.ll_website.Text = "Website";
            this.ll_website.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_website_LinkClicked);
            // 
            // panel_contactInfo
            // 
            this.panel_contactInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_contactInfo.Controls.Add(this.lbl_people_office);
            this.panel_contactInfo.Controls.Add(this.ll_website);
            this.panel_contactInfo.Controls.Add(this.lbl_people_phone);
            this.panel_contactInfo.Controls.Add(this.lbl_people_email);
            this.panel_contactInfo.Location = new System.Drawing.Point(655, 240);
            this.panel_contactInfo.Name = "panel_contactInfo";
            this.panel_contactInfo.Size = new System.Drawing.Size(268, 222);
            this.panel_contactInfo.TabIndex = 11;
            // 
            // FacStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 815);
            this.Controls.Add(this.panel_contactInfo);
            this.Controls.Add(this.lbl_people_interestArea);
            this.Controls.Add(this.lbl_people_title);
            this.Controls.Add(this.lbl_tagline);
            this.Controls.Add(this.pb_indv_personImage);
            this.Controls.Add(this.lbl_people_name);
            this.Controls.Add(this.ml_people_username);
            this.Name = "FacStaff";
            this.Text = "FacStaff";
            ((System.ComponentModel.ISupportInitialize)(this.pb_indv_personImage)).EndInit();
            this.panel_contactInfo.ResumeLayout(false);
            this.panel_contactInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel ml_people_username;
        private System.Windows.Forms.Label lbl_people_name;
        private System.Windows.Forms.PictureBox pb_indv_personImage;
        private System.Windows.Forms.Label lbl_tagline;
        private System.Windows.Forms.Label lbl_people_title;
        private System.Windows.Forms.Label lbl_people_office;
        private System.Windows.Forms.Label lbl_people_interestArea;
        private System.Windows.Forms.Label lbl_people_phone;
        private System.Windows.Forms.Label lbl_people_email;
        private System.Windows.Forms.LinkLabel ll_website;
        private System.Windows.Forms.Panel panel_contactInfo;
    }
}