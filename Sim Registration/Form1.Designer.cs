namespace Sim_Registration
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.MaskedTextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // Labels
            this.lblMobile.Text = "Mobile:";
            this.lblMobile.Location = new System.Drawing.Point(30, 30);
            this.lblFirstname.Text = "Firstname:";
            this.lblFirstname.Location = new System.Drawing.Point(30, 70);
            this.lblLastname.Text = "Lastname:";
            this.lblLastname.Location = new System.Drawing.Point(30, 110);
            this.lblSex.Text = "Sex:";
            this.lblSex.Location = new System.Drawing.Point(30, 150);
            this.lblStatus.Text = "Status:";
            this.lblStatus.Location = new System.Drawing.Point(30, 190);
            this.lblBirthday.Text = "Birthday:";
            this.lblBirthday.Location = new System.Drawing.Point(30, 230);
            this.lblLocation.Text = "Location:";
            this.lblLocation.Location = new System.Drawing.Point(30, 270);

            // Textboxes and Inputs
            this.txtMobile.Location = new System.Drawing.Point(130, 30);
            this.txtMobile.Mask = "0000-000-0000";
            this.txtMobile.Width = 150;

            this.txtFirstname.Location = new System.Drawing.Point(130, 70);
            this.txtFirstname.Width = 150;

            this.txtLastname.Location = new System.Drawing.Point(130, 110);
            this.txtLastname.Width = 150;

            this.rbMale.Text = "Male";
            this.rbMale.Location = new System.Drawing.Point(130, 150);
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;

            this.rbFemale.Text = "Female";
            this.rbFemale.Location = new System.Drawing.Point(200, 150);
            this.rbFemale.AutoSize = true;

            this.cmbStatus.Items.AddRange(new object[] { "Single", "Married", "Widowed", "Its Complicated" });
            this.cmbStatus.Location = new System.Drawing.Point(130, 190);
            this.cmbStatus.Width = 150;

            this.dtpBirthday.Location = new System.Drawing.Point(130, 230);
            this.dtpBirthday.Width = 150;

            this.txtLocation.Location = new System.Drawing.Point(130, 270);
            this.txtLocation.Width = 150;

            // PictureBox
            this.pictureBox1.Location = new System.Drawing.Point(320, 30);
            this.pictureBox1.Size = new System.Drawing.Size(180, 150);
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // Buttons
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Location = new System.Drawing.Point(360, 190);
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);

            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Location = new System.Drawing.Point(200, 330);
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblMobile, lblFirstname, lblLastname, lblSex, lblStatus, lblBirthday, lblLocation,
                txtMobile, txtFirstname, txtLastname, rbMale, rbFemale, cmbStatus, dtpBirthday,
                txtLocation, pictureBox1, btnBrowse, btnSubmit
            });
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIM CARD Registration";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblMobile, lblFirstname, lblLastname, lblSex, lblStatus, lblBirthday, lblLocation;
        private System.Windows.Forms.MaskedTextBox txtMobile;
        private System.Windows.Forms.TextBox txtFirstname, txtLastname, txtLocation;
        private System.Windows.Forms.RadioButton rbMale, rbFemale;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrowse, btnSubmit;
    }
}
