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
    public partial class StudentServicesForm : MaterialForm
    {
        private StudentServices ss;
        private Panel academicAdvisorPanel;
        private Panel professonalAdvisorsPanel;

        // Constructor
        public StudentServicesForm(StudentServices ss)
        {
            this.ss = ss;

            InitializeComponent();

            setFormStyle(); // Set Form Style
        }


        #region AcademicAdvisors
        // Academic Advisors Click Button
        private void mb_academicAdvisor_Click(object sender, EventArgs e)
        {
            // Check if panel doesn't exist
            // First time! Only ran once
            if (academicAdvisorPanel == null)
            {
                academicAdvisorPanel = new Panel();
                academicAdvisorPanel.Dock = DockStyle.Fill;

                MaterialLabel mlTitle = new MaterialLabel();
                mlTitle.Text = ss.academicAdvisors.title;
                mlTitle.Location = new Point(380, 20);
                academicAdvisorPanel.Controls.Add(mlTitle);

                Label lblDesc = new Label();
                lblDesc.Text = ss.academicAdvisors.description;
                lblDesc.MaximumSize = new Size(500, 500);
                lblDesc.AutoSize = true;
                lblDesc.Location = new Point(180, 50);
                academicAdvisorPanel.Controls.Add(lblDesc);

                Label lblFAQ = new Label();
                lblFAQ.Text = ss.academicAdvisors.faq.title;
                lblFAQ.AutoSize = true;
                lblFAQ.Font = new Font("Arial", 10);
                lblFAQ.Location = new Point(180, 220);
                academicAdvisorPanel.Controls.Add(lblFAQ);

                LinkLabel ll = new LinkLabel();
                ll.Text = ss.academicAdvisors.faq.contentHref;
                ll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(faqLinkClick);
                ll.Location = new Point(180, 250);
                academicAdvisorPanel.Controls.Add(ll);

                panel_advisors_container.Controls.Add(academicAdvisorPanel);
                academicAdvisorPanel.Show();
            }
            else 
            {
                // Toggle visibility
                academicAdvisorPanel.Visible = !academicAdvisorPanel.Visible;
            }
        }

        private void faqLinkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel ll = sender as LinkLabel;
            System.Diagnostics.Process.Start(ll.Text);
        }
        #endregion



        // Set Form Styling
        private void setFormStyle()
        {
            this.Text = "Advisors";

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
