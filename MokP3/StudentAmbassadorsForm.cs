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
    public partial class StudentAmbassadorsForm : MaterialForm
    {
        public StudentAmbassadorsForm(StudentAmbassadors st)
        {
            InitializeComponent();
            setFormStyle();

            // Title
            ml_studentAMBTitle.Text = st.title;

            // Picture Box
            pb_studentAMB.Load(st.ambassadorsImageSource);
            pb_studentAMB.SizeMode = PictureBoxSizeMode.StretchImage;
        }




        private void setFormStyle()
        {
            this.Text = "Student Ambassadors";
            this.Size = new Size(900, 600);
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
