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
    public partial class EachResource : MaterialForm
    {
        public EachResource(StudyAbroad sa)
        {
            InitializeComponent();

            setUpFormStyle(); //sets up the form's styling

            // Set the form title
            this.Text = sa.title;


            

        }


        // SetUpFormStyle sets up all form styling
        private void setUpFormStyle()
        {
            this.Size = new Size(900, 500); // Change size of the form

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
