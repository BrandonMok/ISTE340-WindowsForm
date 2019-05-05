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
    public partial class EachResearch : MaterialForm
    {
        // ByInterestArea - overloaded constructor
        public EachResearch(ByInterestArea bia) 
        {
            InitializeComponent();
            setFormStyle(); // Set form style

            // Set section title
            ml_eachResearch_sectionTitle.Text = bia.areaName;

            // Panel for each research
            Panel resPanel = null;
            resPanel = new Panel();
            resPanel.BorderStyle = BorderStyle.FixedSingle;
            resPanel.Dock = DockStyle.Fill;

            StringBuilder sb = new StringBuilder();

            for (int i = 0, len = bia.citations.Count; i < len; i++)
            {
                sb.Append(bia.citations[i] + "\n\n");
            }


            Label lblCitation = new Label();
            lblCitation.Text = sb.ToString();
            lblCitation.Location = new Point(0, 0);
            lblCitation.AutoSize = true;
            lblCitation.MaximumSize = new Size(700, 0);

            resPanel.Controls.Add(lblCitation);
            resPanel.Size = new Size(800, 500);

            resPanel.Location = new Point(0, 0);

            panel_research_container.Controls.Add(resPanel);
        }



        // ByFaculty overloaded constructor
        public EachResearch(ByFaculty bf) 
        {
            InitializeComponent();

            setFormStyle(); // Set form style

            // Set form name to THIS research
            this.Text = bf.username;

            // Set the section heading to this faculty's name
            ml_eachResearch_sectionTitle.Text = bf.facultyName;


            // Panel for each research
            Panel resPanel = null;
            resPanel = new Panel();
            resPanel.BorderStyle = BorderStyle.FixedSingle;
            resPanel.Dock = DockStyle.Fill;

            StringBuilder sb = new StringBuilder();

            for (int i = 0, len = bf.citations.Count; i < len; i++)
            {
                sb.Append(bf.citations[i] + "\n\n");
            }


            Label lblCitation = new Label();
            lblCitation.Text = sb.ToString();
            lblCitation.Location = new Point(0, 0);
            lblCitation.AutoSize = true;
            lblCitation.MaximumSize = new Size(700, 0);

            resPanel.Controls.Add(lblCitation);
            resPanel.Size = new Size(800, 500);

            resPanel.Location = new Point(0, 0);

            panel_research_container.Controls.Add(resPanel);
        }





        // Sets the forms style to MaterialForm
        public void setFormStyle()
        {
            this.Size = new Size(900, 500);
            // Set form name to THIS research
            this.Text = "Tables";

            // Styling
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
