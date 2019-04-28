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
    public partial class Tables : MaterialForm
    {
        public Tables(Employment employment)
        {
            InitializeComponent();
            this.Text = "Employment Tables";
            this.Size = new Size(900, 600);



            // Prepare the listView for COOP
            listView_Coop.View = View.Details;
            listView_Coop.GridLines = true;
            listView_Coop.FullRowSelect = true;
            listView_Coop.Width = 800;

            //assign columns for COOP
            listView_Coop.Columns.Add("Employers", 200);
            listView_Coop.Columns.Add("Degree", 200);
            listView_Coop.Columns.Add("City", 200);
            listView_Coop.Columns.Add("Term", 100);


            // COOP
            ListViewItem item; // like a row
            for (int i = 0; i < employment.coopTable.coopInformation.Count; i++)
            {
                item = new ListViewItem(new string[]{
                    employment.coopTable.coopInformation[i].employer,
                    employment.coopTable.coopInformation[i].degree,
                    employment.coopTable.coopInformation[i].city,
                    employment.coopTable.coopInformation[i].term
                });
                listView_Coop.Items.Add(item);
            }



            // Prepare EMPLOYMENT listView
            listView_Employment.View = View.Details;
            listView_Employment.GridLines = true;
            listView_Employment.FullRowSelect = true;
            listView_Employment.Width = 800;

            //assign columns for EMPLOYMENT listView
            listView_Employment.Columns.Add("Employers", 200);
            listView_Employment.Columns.Add("Degree", 100);
            listView_Employment.Columns.Add("City", 100);
            listView_Employment.Columns.Add("Title", 200);
            listView_Employment.Columns.Add("Start Date", 80);


            // EmploymentTable - ListView
            ListViewItem employmentItem; // like a row
            for (int i = 0; i < employment.employmentTable.professionalEmploymentInformation.Count; i++)
            {
                employmentItem = new ListViewItem(new string[]{
                    employment.employmentTable.professionalEmploymentInformation[i].employer,
                    employment.employmentTable.professionalEmploymentInformation[i].degree,
                    employment.employmentTable.professionalEmploymentInformation[i].city,
                    employment.employmentTable.professionalEmploymentInformation[i].title,
                    employment.employmentTable.professionalEmploymentInformation[i].startDate
                });
                listView_Employment.Items.Add(employmentItem);
            }
        }
    }
}
