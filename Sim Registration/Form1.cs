using System;
using System.Windows.Forms;
using Sim_Registration;

namespace Sim_Registration
{
    public partial class Form1 : Form
    {
        string imagePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagePath = ofd.FileName;
                    pictureBox1.ImageLocation = imagePath;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Pass data to Form2
            Form2 form2 = new Form2(
                txtMobile.Text,
                txtFirstname.Text,
                txtLastname.Text,
                rbMale.Checked ? "Male" : "Female",
                cmbStatus.Text,
                dtpBirthday.Value.ToShortDateString(),
                txtLocation.Text,
                imagePath
            );
            form2.Show();
            this.Hide();
        }
    }
}
