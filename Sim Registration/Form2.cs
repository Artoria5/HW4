using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sim_Registration
{
    public partial class Form2 : Form
    {
        public Form2(string mobile, string firstname, string lastname, string sex, string status, string birthday, string location, string imagePath)
        {
            InitializeComponent();

            lblMobile.Text = mobile;
            lblFirstname.Text = firstname;
            lblLastname.Text = lastname;
            lblSex.Text = sex;
            lblStatus.Text = status;
            lblBirthday.Text = birthday;
            lblLocation.Text = location;

            if (!string.IsNullOrEmpty(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }
    }
}
