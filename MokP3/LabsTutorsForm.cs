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
    public partial class LabsTutorsForm : MaterialForm
    {
        public LabsTutorsForm(TutorsAndLabInformation tli)
        {
            InitializeComponent();

            setFormStyle(); // set form style

            // Set main Title
            ml_TutorsLabs_title.Text = tli.title;

            // Set Description
            lbl_description.Text = tli.description;
            lbl_description.MaximumSize = new Size(500, 0);
        }

        // link label click
        private void ll_labHours_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel ll = sender as LinkLabel;
            ll.LinkVisited = true;

            System.Diagnostics.Process.Start(ll.Text);
        }



        // Sets the form styles
        private void setFormStyle()
        {
            this.Text = "Tutors / Labs";

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
