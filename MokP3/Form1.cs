using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MokP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Change size of the form!
            this.Size = new Size(700,450);

            // json2csharp.com


            // ABOUT
            string jsonAbout = getRESTData("/about/"); 
            About about = JToken.Parse(jsonAbout).ToObject<About>(); // cast it to the About object

            //textBox1.Text = about.description;
            lbl_description.Text = about.description;
            lbl_description.MaximumSize = new Size(500, 0);
            lbl_description.Font = new Font("Arial", 9);

            lbl_quote.Text = about.quote;
            lbl_quote.MaximumSize = new Size(400, 0);
            lbl_quote.Font = new Font("Arial", 8);


            // DEGREES
            string jsonDegrees = getRESTData("/degrees/");
            Degrees degrees = JToken.Parse(jsonDegrees).ToObject<Degrees>();



            // MINORS
            string jsonMinors = getRESTData("/minors/");
            Minors minors = JToken.Parse(jsonMinors).ToObject<Minors>();


            // EMPLOYMENT
            string jsonEmployment = getRESTData("/employment/");
            Employment employment = JToken.Parse(jsonEmployment).ToObject<Employment>();


            // RESEARCH
            string jsonResearch = getRESTData("/research/");
            Research research = JToken.Parse(jsonResearch).ToObject<Research>();


            // NEWS
            string jsonNews = getRESTData("/news/");
            News news = JToken.Parse(jsonNews).ToObject<News>();


            // FOOTER
            string jsonFooter = getRESTData("/footer/");
            Footer footer = JToken.Parse(jsonFooter).ToObject<Footer>();




            // PEOPLE
            string jsonPeople = getRESTData("/people/");
            People people = JToken.Parse(jsonPeople).ToObject<People>();
            //Console.WriteLine(jsonPeople);
            Console.WriteLine(people.faculty); // returns a list

            //for(int i = 0; i < people.faculty.Count; i++)
            //{
            //    Console.WriteLine(people.faculty[i].username);
            //}



            // RESOURCES
            string jsonResources = getRESTData("/resources/");
            Resources resources = JToken.Parse(jsonResources).ToObject<Resources>();
            //populate the link label with the RIT JobZoneLink!
            linkLabel1.Text = resources.coopEnrollment.RITJobZoneGuidelink;
        }




        #region getRestData

        public string getRESTData(string uri)
        {
            // base URI
            string baseUri = "http://ist.rit.edu/api";

            // connect to the api
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUri + uri);

            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException we)
            {
                WebResponse err = we.Response;
                using(Stream responseStream = err.GetResponseStream())
                {
                    StreamReader r = new StreamReader(responseStream, Encoding.UTF8);
                    return r.ReadToEnd();
                }
            }
        }

        #endregion





        // Can be used multiple times
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // go and load the pdf!
            // which url do I need? We can get it from sender

            // LinkLabel me = (LinkLabel)sender; 
            LinkLabel me = sender as LinkLabel;

            // make me look like I was visited
            me.LinkVisited = true;

            System.Diagnostics.Process.Start(me.Text);
        }

        private void homeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel_home.Hide();
            panel_home.Show();
        }
    }
}
