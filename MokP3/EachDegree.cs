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
    public partial class EachDegree : MaterialForm
    {

        public EachDegree(Undergraduate undergrad, Graduate grad)
        {
            InitializeComponent();
            setFormStyle();

            string title = "";
            string degreeName = "";
            string description = "";
            List<string> concentrations = null;

      
            // CHECK: If undergrad or graduate object
            if(undergrad != null)
            {
                title = undergrad.title;
                degreeName = undergrad.degreeName;
                description = undergrad.description;
                concentrations = undergrad.concentrations;
            }
            else
            {
                title = grad.title;
                degreeName = grad.degreeName;
                description = grad.description;
                concentrations = grad.concentrations;
            }


            // SAME for both objects - display information
            // Form name
            this.Text = degreeName;

            // Title
            ml_degree_title.Text = title;

            lbl_specific_degreeDescription.Text = description;
            lbl_specific_degreeDescription.Font = new Font("Arial", 9);
            lbl_specific_degreeDescription.MaximumSize = new Size(400, 0);

            // Concentrations literal label
            lbl_Concentrations.Font = new Font("Arial", 10);



            // String to hold all concentrations
            var sb = new StringBuilder();

            // loop through all concentrations
            foreach (string concen in concentrations)
            {
                sb.Append(concen + "\n");
            }

            // set Text
            lbl_specific_degreeConcentrations.Text = sb.ToString();
            lbl_specific_degreeConcentrations.Font = new Font("Arial", 9);
        }



        // Set form style
        private void setFormStyle()
        {
            this.Size = new Size(600, 400); // Change size of the form
            this.Text = "Degrees";  // Change title of 

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
