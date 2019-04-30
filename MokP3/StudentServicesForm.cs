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
        private Panel facultyAdvisorsPanel;
        private Panel istMinorAdvisingPanel;

        private List<Panel> panelList;


        // Constructor
        public StudentServicesForm(StudentServices ss)
        {
            this.ss = ss;

            InitializeComponent();

            setFormStyle(); // Set Form Style

            // Initialize panel list
            panelList = new List<Panel>();


            // Load all info for all panels here
            // methods here, but don't show yet
            loadAcademicAdvisors();
            loadProfessionalAdvisors();
            loadFacultyAdvisors();


            // Keep a list of all panels
            // Will use to show/hide based on clicked button
            panelList.Add(academicAdvisorPanel);
            panelList.Add(professonalAdvisorsPanel);
            panelList.Add(facultyAdvisorsPanel);
 //           panelList.Add(istMinorAdvisingPanel);
        }



        #region AcademicAdvisors
        // Academic Advisors Click Button
        private void mb_academicAdvisor_Click(object sender, EventArgs e)
        {
            hideShowPanels(academicAdvisorPanel);
            academicAdvisorPanel.Visible = !academicAdvisorPanel.Visible;
        }

        private void loadAcademicAdvisors()
        {
            // First time! Only ran once
            //if (academicAdvisorPanel == null)
            //{
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
                academicAdvisorPanel.Visible = false; // HIDE IT initially
           // }
        }

        private void faqLinkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel ll = sender as LinkLabel;
            System.Diagnostics.Process.Start(ll.Text);
        }
        #endregion

        #region ProfessionalAdvisors
        private void mb_professionalAdvisors_Click(object sender, EventArgs e)
        {
            hideShowPanels(professonalAdvisorsPanel);
            professonalAdvisorsPanel.Visible = !professonalAdvisorsPanel.Visible;
        }

        private void loadProfessionalAdvisors()
        {
            // Professional Advisors
            professonalAdvisorsPanel = new Panel();
            professonalAdvisorsPanel.Dock = DockStyle.Fill;

            MaterialLabel mlTitle = new MaterialLabel();
            mlTitle.Text = ss.professonalAdvisors.title;
            mlTitle.AutoSize = true;
            mlTitle.Location = new Point(340, 30);
            professonalAdvisorsPanel.Controls.Add(mlTitle);


            int xCoord = 100;

            List<AdvisorInformation> advisorsList = ss.professonalAdvisors.advisorInformation;
            for (int i = 0, len = advisorsList.Count; i < len; i++)
            {
                // Panel
                Panel advisorPanel = new Panel();
                advisorPanel.Size = new Size(200, 200);
                advisorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                // Advisor Name
                MaterialLabel mlName = new MaterialLabel();
                mlName.Text = advisorsList[i].name;
                mlName.AutoSize = true;
                mlName.Location = new Point(50, 60);
                advisorPanel.Controls.Add(mlName); // add this label to this advisor's panel

                // Department
                Label lblDep = new Label();
                lblDep.Text = advisorsList[i].department;
                lblDep.AutoSize = true;
                lblDep.Location = new Point(30, 80);
                lblDep.MaximumSize = new Size(150, 0);
                advisorPanel.Controls.Add(lblDep);

                // Email
                Label lblEmail = new Label();
                lblEmail.Text = advisorsList[i].email;
                lblEmail.AutoSize = true;
                lblEmail.Location = new Point(50, 150);
                advisorPanel.Controls.Add(lblEmail);

                // Positioning
                if (i != 0)
                {
                    xCoord += 220;
                }

                advisorPanel.Location = new Point(xCoord, 60);
                professonalAdvisorsPanel.Controls.Add(advisorPanel);
            }


            panel_advisors_container.Controls.Add(professonalAdvisorsPanel);
            professonalAdvisorsPanel.Visible = false;
        }
        #endregion


        #region FacultyAdvisors
        private void mb_facultyAdvisors_Click(object sender, EventArgs e)
        {
            hideShowPanels(facultyAdvisorsPanel);
            facultyAdvisorsPanel.Visible = !facultyAdvisorsPanel.Visible;
        }

        private void loadFacultyAdvisors()
        {
            facultyAdvisorsPanel = new Panel();
            facultyAdvisorsPanel.Dock = DockStyle.Fill;

            // Title
            MaterialLabel ml_FacAdvTitle = new MaterialLabel();
            ml_FacAdvTitle.Text = ss.facultyAdvisors.title;
            ml_FacAdvTitle.Location = new Point(340, 30);
            facultyAdvisorsPanel.Controls.Add(ml_FacAdvTitle);

            // Description
            Label lbl_facAdv = new Label();
            lbl_facAdv.Text = ss.facultyAdvisors.description;
            lbl_facAdv.AutoSize = true;
            lbl_facAdv.Location = new Point(200, 50);
            lbl_facAdv.MaximumSize = new Size(500, 0);
            facultyAdvisorsPanel.Controls.Add(lbl_facAdv);

            facultyAdvisorsPanel.Visible = false;

            panel_advisors_container.Controls.Add(facultyAdvisorsPanel); // add this panel to main
        }
        #endregion







        // Hides all other panels besides the one passed in
        private void hideShowPanels(Panel currPanel)
        {
            // Loop through all panels and set all other panels to hide
            // use len to cycle, calculated ONCE so all can use
            int len = panelList.Count;
            for (int i  = 0; i < len; i++)
            {
                if(panelList[i] != currPanel)
                {
                    panelList[i].Visible = false;
                }
            }
        }


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
