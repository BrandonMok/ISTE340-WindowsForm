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


            // Y Coordinate to know where to place the next panel below
            int yCoord = 0;

            // Went the route of making panels for each citation so that main container can scroll
            for (int i = 0; i < bia.citations.Count; i++)
            {
                Panel citationPanel = new Panel();
                citationPanel.BorderStyle = BorderStyle.FixedSingle;
                citationPanel.Size = new Size(800, 60);

                Label lblNew = new Label();
                lblNew.Text = bia.citations[i];
                lblNew.AutoSize = true;
                lblNew.Font = new Font("Arial", 8);
                lblNew.MaximumSize = new Size(750, 0);
                lblNew.Location = new Point(10, 0);

                if(i != 0)
                {
                    yCoord += 80;
                }

                // This citation panel add the label
                citationPanel.Controls.Add(lblNew);
                citationPanel.Location = new Point(20, yCoord); // Set position 

                // Add to main container
                panel_research_container.Controls.Add(citationPanel);
            }
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


            // Y Coordinate to know where to place the next panel below
            int yCoord = 0;

            // Went the route of making panels for each citation so that main container can scroll
            for (int i = 0; i < bf.citations.Count; i++)
            {
                Panel citationPanel = new Panel();
                citationPanel.BorderStyle = BorderStyle.FixedSingle;
                citationPanel.Size = new Size(800, 60);

                Label lblNew = new Label();
                lblNew.Text = bf.citations[i];
                lblNew.AutoSize = true;
                lblNew.Font = new Font("Arial", 8);
                lblNew.MaximumSize = new Size(750, 0);
                lblNew.Location = new Point(10, 0);

                if (i != 0)
                {
                    yCoord += 80;
                }

                // This citation panel add the label
                citationPanel.Controls.Add(lblNew);
                citationPanel.Location = new Point(20, yCoord); // Set position 

                // Add to main container
                panel_research_container.Controls.Add(citationPanel);
            }
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
