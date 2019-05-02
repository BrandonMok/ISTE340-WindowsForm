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
    public partial class EachMinor : MaterialForm
    {
        public EachMinor(UgMinor ugm)
        {
            InitializeComponent();
            this.Size = new Size(600, 450); // Change size of the form
            this.Text = "Minor";  // Change title of 

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );



            // Setting all the information onto form
            lbl_specific_minor_Name.Text = ugm.name;
            lbl_specific_minor_Title.Text = ugm.title;
            lbl_specific_minor_desc.Text = ugm.description;
            lbl_specific_minor_desc.MaximumSize = new Size(500, 300);


            // courses section - is a list
            List<string> courses = ugm.courses;

            // loop through all concentrations
            var sb = new StringBuilder(); // string builder so concentrations aren't stack on top
            foreach (string course in courses)
            {
                sb.Append(course + "\n");
            }

            // set Text
            lbl_specific_minor_concentrations.Text = sb.ToString();


            // only add note if there is one
            if (ugm.note != "")
            {
                lbl_specific_minor_note.Text = "**" + ugm.note;
                lbl_specific_minor_note.MaximumSize = new Size(500, 0);
            }
        }
    }
}
