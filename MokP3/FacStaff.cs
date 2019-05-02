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
    public partial class FacStaff : MaterialForm
    {
        // Pass in either a faculty or staff obj
        public FacStaff(Faculty fac, Staff staff)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );


            if(fac != null)
            {
                ml_people_username.Text = fac.username;
                ml_people_name.Text = fac.name;

                if(fac.tagline != null && fac.tagline != "")
                {
                    lbl_tagline.Text = fac.tagline;
                }
                else
                {
                    lbl_tagline.Text = "";
                }

                // Picture Box
                pb_indv_personImage.Load(fac.imagePath);
                pb_indv_personImage.SizeMode = PictureBoxSizeMode.StretchImage;

                // Title
                lbl_people_title.Text = fac.title;
                lbl_people_title.Font = new Font("Arial", 10);


                // Interest Area
                if (fac.interestArea != null && fac.interestArea != "")
                {
                    lbl_people_interestArea.Text += ": " + fac.interestArea;
                }
                else
                {
                    lbl_people_interestArea.Text = "";
                }


                // Office
                lbl_people_office.Text = fac.office;

                // WEbsite
                if(fac.website != null && fac.website != "")
                {
                    ll_website.Text = fac.website;
                }
                else
                {
                    ll_website.Text = "";
                }

                // Phone
                lbl_people_phone.Text = fac.phone;

                // email
                lbl_people_email.Text = fac.email;
            }
            else
            {
                // STAFF OBJ
                ml_people_username.Text = staff.username;
                ml_people_name.Text = staff.name;

                if (staff.tagline != null && staff.tagline != "")
                {
                    lbl_tagline.Text = staff.tagline;
                }
                else
                {
                    lbl_tagline.Text = "";
                }

                // Picture Box
                pb_indv_personImage.Load(staff.imagePath);
                pb_indv_personImage.SizeMode = PictureBoxSizeMode.StretchImage;

                // Title
                lbl_people_title.Text = staff.title;
                lbl_people_title.Font = new Font("Arial", 10);


                // Interest Area
                if (staff.interestArea != null && staff.interestArea != "")
                {
                    lbl_people_interestArea.Text += ": " + staff.interestArea;
                }
                else
                {
                    lbl_people_interestArea.Text = "";
                }


                // Office
                lbl_people_office.Text = staff.office;

                // WEbsite
                if (staff.website != null && staff.website != "")
                {
                    ll_website.Text = staff.website;
                }
                else
                {
                    ll_website.Text = "";
                }

                // Phone
                lbl_people_phone.Text = staff.phone;

                // email
                lbl_people_email.Text = staff.email;
            }

        }

        private void ll_website_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel personlbl = sender as LinkLabel;
            personlbl.LinkVisited = true;

            System.Diagnostics.Process.Start(personlbl.Text);
        }
        //public FacStaff(Staff me)
        //{
        //    InitializeComponent();
        //    MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        //    materialSkinManager.AddFormToManage(this);

        //    materialSkinManager.ColorScheme = new ColorScheme(
        //        Primary.Blue400, Primary.Blue500,
        //        Primary.Blue500, Accent.LightBlue200,
        //        TextShade.WHITE
        //    );
        //}



    }
}
