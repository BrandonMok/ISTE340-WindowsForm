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

            int xCoord = 0;
            int yCoord = 0;

            for (int i = 0; i < listLength; i++)
            {
                if( i != 0)
                {
                    if (xCoord >= 800)
                    {
                        xCoord = 0;
                        yCoord += 50;
                    }
                    else
                    {
                        xCoord += 400;
                    }
                }


                // Form Names
                Label lblName = new Label();
                lblName.Text = gradFormsList[i].formName;
                lblName.Location = new Point(xCoord, yCoord);
                panel_gForms.Controls.Add(lblName);


                // Link Labels
                LinkLabel linkLbl = new LinkLabel();
                linkLbl.Text = gradFormsList[i].href;
                linkLbl.AutoSize = true;
                linkLbl.Location = new Point(xCoord, yCoord + 25);


                // Set on click for linklabels
                linkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelClick);
                linkLbl.LinkVisited = true;

                panel_gForms.Controls.Add(lblName);
                panel_gForms.Controls.Add(linkLbl);
            }


            // UNDERGRADUATE FORM
            LinkLabel linkLabel = new LinkLabel();
            linkLabel.Text = forms.undergraduateForms[0].href;
            linkLabel.LinkVisited = true;
            linkLabel.AutoSize = true;
            linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelClick);
            linkLabel.Location = new Point(0, 25);

            Label lblUFormName = new Label();
            lblUFormName.Text = forms.undergraduateForms[0].formName;
            lblUFormName.Location = new Point(0, 0);

            panel_undergradFroms.Controls.Add(linkLabel);
            panel_undergradFroms.Controls.Add(lblUFormName);
        }

        // Link Label click
        private void linkLabelClick(object sender, EventArgs e)
        {
            LinkLabel ll = sender as LinkLabel;

            // Put in try catch so doesn't interrupt the program if cannot find them
            // Form links don't work from api or from prev projects
            try
            {
                System.Diagnostics.Process.Start(ll.Text);
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception);
            }
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
