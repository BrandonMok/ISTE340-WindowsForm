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


            setListViewProps();

            ListViewItem lviResearch;
            for(int i = 0; i < bia.citations.Count; i++)
            {
                lviResearch = new ListViewItem(new String[] {
                    bia.citations[i]
                });
                materialListView1.Items.Add(lviResearch);
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

            setListViewProps();

            ListViewItem lviResearch;
            for (int i = 0; i < bf.citations.Count; i++)
            {
                lviResearch = new ListViewItem(new String[] {
                    bf.citations[i]
                });
                materialListView1.Items.Add(lviResearch);
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

        // Sets the ListView properties
        public void setListViewProps()
        {
            materialListView1.View = View.Details;
            materialListView1.GridLines = true;
            materialListView1.FullRowSelect = true;
            materialListView1.Width = 800;
            materialListView1.Columns.Add("Research", 790);
        }
    }
}
