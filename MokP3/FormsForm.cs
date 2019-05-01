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
    public partial class FormsForm : MaterialForm
    {
        public FormsForm(Forms forms)
        {
            InitializeComponent();
            setFormStyle();

            // List of all graduate forms
            List<GraduateForm> gradFormsList = forms.graduateForms;
            int listLength = gradFormsList.Count;

            for(int i = 0; i < listLength; i++)
            {
                // Link Labels
                LinkLabel linkLbl = new LinkLabel();
                linkLbl.Text = gradFormsList[i].href;
                linkLbl.AutoSize = true;

                // Set on click for linklabels
                linkLbl.Click += linkLabelClick;

                // Put in panel along form name?
            }

        }

        // Link Label click
        private void linkLabelClick(object sender, EventArgs e)
        {
            LinkLabel linkLbl = sender as LinkLabel;
            System.Diagnostics.Process.Start(linkLbl.Text);
        }

        private void setFormStyle()
        {
            this.Text = "Forms";
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
