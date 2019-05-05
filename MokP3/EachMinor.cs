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
using Newtonsoft.Json.Linq;
using RESTUtil;

namespace MokP3
{
    public partial class EachMinor : MaterialForm
    {
        REST rj = new REST("http://ist.rit.edu/api");
        List<Course> courseList = null;


        public EachMinor(UgMinor ugm)
        {
            InitializeComponent();
            setFormStyle();


            if(courseList == null)
            {
                string path = "/course/";
                string coursePath = rj.getRESTDataJSON(path);
                courseList = JToken.Parse(coursePath).ToObject<List<Course>>();
            }

           



            // Setting all the information onto form
            ml_minor_name.Text = ugm.name;
            lbl_specific_minor_Title.Text = ugm.title;
            lbl_specific_minor_desc.Text = ugm.description;
            lbl_specific_minor_desc.MaximumSize = new Size(550, 300);


            // courses section - is a list
            List<string> courses = ugm.courses;

            var yCoord = 0;
            foreach (string course in courses)
            {
                yCoord += 15;
                LinkLabel linklblCourse = new LinkLabel();
                linklblCourse.AutoSize = true;
                linklblCourse.Text = course;
                linklblCourse.LinkClicked += new LinkLabelLinkClickedEventHandler(findCourse);
                linklblCourse.Location = new Point(10, yCoord);

                panel_concList.Controls.Add(linklblCourse);
            }



            // only add note if there is one
            if (ugm.note != "")
            {
                lbl_specific_minor_note.Text = "**" + ugm.note;
                lbl_specific_minor_note.MaximumSize = new Size(550, 0);
            }
        }

        // Separate form to show specific course info
        private void findCourse(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLbl = sender as LinkLabel;

            // Get the clicked course
            Course clickedCourse = courseList.Find(x => x.courseID == linkLbl.Text);

            // Show form
            SelectedCourse sc = new SelectedCourse(clickedCourse);
            sc.ShowDialog();
        }


        // Form Styling setup
        private void setFormStyle()
        {
            this.Size = new Size(600, 500); // Change size of the form
            this.Text = "Minor";  // Change title of 

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
