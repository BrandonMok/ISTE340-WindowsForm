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
    public partial class MoreInfo : MaterialForm
    {
        public MoreInfo(DegreeStatistics ds, Careers careers, Employers employers)
        {
            InitializeComponent();
            this.Size = new Size(900, 600); // Change size of the form
            this.Text = "More Info";  // Change title of 

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
            
            // Title of section
            ml_stats_title.Text = ds.title;

            // Stat1
            ml_stat1_Value.Text = ds.statistics[0].value;
            lbl_stat1_desc.Text = ds.statistics[0].description;
            lbl_stat1_desc.MaximumSize = new Size(125, 0);

            // Stat2
            ml_stat2_Value.Text = ds.statistics[1].value;
            lbl_stat2_desc.Text = ds.statistics[1].description;
            lbl_stat2_desc.MaximumSize = new Size(125, 0);

            // Stat3
            ml_stat3_Value.Text = ds.statistics[2].value;
            lbl_stat3_desc.Text = ds.statistics[2].description;
            lbl_stat3_desc.MaximumSize = new Size(125, 0);

            // Stat4
            ml_stat4_Value.Text = ds.statistics[3].value;
            lbl_stat4_desc.Text = ds.statistics[3].description;
            lbl_stat4_desc.MaximumSize = new Size(125, 0);


  

            // String to hold all concentrations
            var sb = new StringBuilder();
            foreach (string emp in employers.employerNames)
            {
                sb.Append(emp);
                sb.AppendLine();
            }

            lbl_employers_list.Text = sb.ToString();


            var sb2 = new StringBuilder();
            foreach (string career in careers.careerNames)
            {
                sb2.Append(career);
                sb2.AppendLine();
            }
            lbl_careers_list.Text = sb2.ToString();
        }
    }
}
