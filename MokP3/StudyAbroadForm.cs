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
    public partial class StudyAbroadForm : MaterialForm
    {
        public StudyAbroadForm(StudyAbroad sa)
        {
            InitializeComponent();

            setFormStyle();

            // Description
            lbl_studyAbroad_desc.Text = sa.description;
            lbl_studyAbroad_desc.MaximumSize = new Size(450, 0);
            lbl_studyAbroad_desc.Font = new Font("Arial", 9);

            // Place 1
            ml_place1_name.Text = sa.places[0].nameOfPlace;
            lbl_place1_desc.Text = sa.places[0].description;
            lbl_place1_desc.MaximumSize = new Size(250, 0);

            // Place 2
            ml_place2_name.Text = sa.places[1].nameOfPlace;
            lbl_place2_desc.Text = sa.places[1].description;
            lbl_place2_desc.MaximumSize = new Size(250, 0);
        }

        private void setFormStyle()
        {
            // Set the title of the form
            this.Text = "Study Abroad";

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
