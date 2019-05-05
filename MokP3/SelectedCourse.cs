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
    public partial class SelectedCourse : MaterialForm
    {
        public SelectedCourse(Course selectedCourse)
        {
            InitializeComponent();
            setFormStyle();

            this.Text = selectedCourse.courseID;

            // Set title
            ml_course_title.Text = selectedCourse.title;

            ml_course_ID.Text = selectedCourse.courseID;

            lbl_course_desc.Text = selectedCourse.description;
            lbl_course_desc.AutoSize = true;
            lbl_course_desc.MaximumSize = new Size(500, 0);
            lbl_course_desc.Font = new Font("Arial", 9);

        }


        private void setFormStyle()
        {
            this.Size = new Size(600, 500); // Change size of the form

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
