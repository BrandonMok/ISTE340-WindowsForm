using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MokP3
{
    public partial class CoopEnrollmentForm : MaterialForm
    {
        public CoopEnrollmentForm(CoopEnrollment ce)
        {
            InitializeComponent();
            setFormStyle();

            // Set Title
            ml_coopEnroll_title.Text = ce.title;

            // PREREQ
            ml_prereq_title.Text = ce.enrollmentInformationContent[0].title;
            lbl_prereq_desc.Text = ce.enrollmentInformationContent[0].description;
            lbl_prereq_desc.AutoSize = true;
            lbl_prereq_desc.MaximumSize = new Size(600, 0);

            // ENROLL
            ml_Enroll1.Text = ce.enrollmentInformationContent[1].title;
            lbl_enroll1_desc.Text = ce.enrollmentInformationContent[1].description;
            lbl_enroll1_desc.AutoSize = true;
            lbl_enroll1_desc.MaximumSize = new Size(600, 0);

            ml_enroll2.Text = ce.enrollmentInformationContent[2].title;
            lbl_enroll2_desc.Text = ce.enrollmentInformationContent[2].description;
            lbl_enroll2_desc.AutoSize = true;
            lbl_enroll2_desc.MaximumSize = new Size(600, 0);

            // APPROVAL
            ml_approval_title.Text = ce.enrollmentInformationContent[3].title;
            lbl_approval_desc.Text = ce.enrollmentInformationContent[3].description;
            lbl_approval_desc.AutoSize = true;
            lbl_approval_desc.MaximumSize = new Size(600, 0);
        }

        private void setFormStyle()
        {
            this.Text = "Coop Enrollment";
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void ll_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linklabel = sender as LinkLabel;
            System.Diagnostics.Process.Start(linklabel.Text);
        }
    }
}
