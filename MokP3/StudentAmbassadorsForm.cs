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
    public partial class StudentAmbassadorsForm : MaterialForm
    {
        public StudentAmbassadorsForm(StudentAmbassadors st)
        {
            InitializeComponent();
            setFormStyle();

            // Title
            ml_studentAMBTitle.Text = st.title;

            // Picture Box
            pb_studentAMB.Load(st.ambassadorsImageSource);
            pb_studentAMB.SizeMode = PictureBoxSizeMode.StretchImage;

            // MISSION
            ml_missionTitle.Text = st.subSectionContent[0].title;
            lbl_mission_desc.Text = st.subSectionContent[0].description;
            lbl_mission_desc.MaximumSize = new Size(700, 0);

            // OVERVIEW
            ml_overviewTitle.Text = st.subSectionContent[1].title;
            lbl_overview_Desc.Text = st.subSectionContent[1].description;
            lbl_overview_Desc.MaximumSize = new Size(700, 0);

            // CRITERIA
            ml_criteria_title.Text = st.subSectionContent[2].title;
            lbl_criteria_desc.Text = st.subSectionContent[2].description;
            lbl_criteria_desc.MaximumSize = new Size(700, 0);

            // DUTIES
            ml_duties_title.Text = st.subSectionContent[3].title;
            lbl_duties_desc.Text = st.subSectionContent[3].description;
            lbl_duties_desc.MaximumSize = new Size(700, 0);

            // EXPECTATIONS
            ml_expectations_title.Text = st.subSectionContent[4].title;
            lbl_expectations_desc.Text = st.subSectionContent[4].description;
            lbl_expectations_desc.MaximumSize = new Size(700, 0);

            // PERKS
            ml_perks_title.Text = st.subSectionContent[5].title;
            lbl_perks_desc.Text = st.subSectionContent[5].description;
            lbl_perks_desc.MaximumSize = new Size(700, 0);

            // APPLY
            ml_apply_title.Text = st.subSectionContent[6].title;
            lbl_apply_desc.Text = st.subSectionContent[6].description;
            lbl_apply_desc.MaximumSize = new Size(700, 0);

            lbl_note.Text = st.note;
            lbl_note.MaximumSize = new Size(700, 0);
        }

        // LINK
        private void ll_applyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel ll = sender as LinkLabel;
            System.Diagnostics.Process.Start(ll.Text);
        }




        private void setFormStyle()
        {
            this.Text = "Student Ambassadors";
            this.Size = new Size(900, 600);
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }
    }
}
