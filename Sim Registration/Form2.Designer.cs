namespace Sim_Registration
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            Label[] staticLabels = {
                new Label() { Text = "Mobile:", Location = new System.Drawing.Point(30, 30) },
                new Label() { Text = "Firstname:", Location = new System.Drawing.Point(30, 70) },
                new Label() { Text = "Lastname:", Location = new System.Drawing.Point(30, 110) },
                new Label() { Text = "Sex:", Location = new System.Drawing.Point(30, 150) },
                new Label() { Text = "Status:", Location = new System.Drawing.Point(30, 190) },
                new Label() { Text = "Birthday:", Location = new System.Drawing.Point(30, 230) },
                new Label() { Text = "Location:", Location = new System.Drawing.Point(30, 270) }
            };

            foreach (var lbl in staticLabels)
            {
                lbl.AutoSize = true;
                this.Controls.Add(lbl);
            }

            // Data labels
            int x = 130;
            this.lblMobile.Location = new System.Drawing.Point(x, 30);
            this.lblFirstname.Location = new System.Drawing.Point(x, 70);
            this.lblLastname.Location = new System.Drawing.Point(x, 110);
            this.lblSex.Location = new System.Drawing.Point(x, 150);
            this.lblStatus.Location = new System.Drawing.Point(x, 190);
            this.lblBirthday.Location = new System.Drawing.Point(x, 230);
            this.lblLocation.Location = new System.Drawing.Point(x, 270);

            this.lblMobile.AutoSize = this.lblFirstname.AutoSize = this.lblLastname.AutoSize =
            this.lblSex.AutoSize = this.lblStatus.AutoSize = this.lblBirthday.AutoSize = this.lblLocation.AutoSize = true;

            // PictureBox
            this.pictureBox1.Location = new System.Drawing.Point(330, 30);
            this.pictureBox1.Size = new System.Drawing.Size(180, 150);
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // Form2
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblMobile, lblFirstname, lblLastname, lblSex, lblStatus, lblBirthday, lblLocation, pictureBox1
            });
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIM CARD Registration Details";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblMobile, lblFirstname, lblLastname, lblSex, lblStatus, lblBirthday, lblLocation;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
