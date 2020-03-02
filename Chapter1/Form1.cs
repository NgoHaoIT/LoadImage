using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter1
{
    public partial class Form1 : Form
    {
        private Button btnLoadImage;
        private Button btnExit;
        private PictureBox pbxPhoto;
        public Form1()
        {
            InitializeComponent();
            this.Text = "My First Form";

            //create and configure button
            btnLoadImage = new Button();
            btnLoadImage.Text = "Load Image";
            btnLoadImage.Top=10;
            btnLoadImage.Left=10;
            this.Controls.Add(btnLoadImage);
            btnLoadImage.Click += new EventHandler(this.HandleLoadClick);
            btnLoadImage.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            btnExit = new Button();
            btnExit.Text = "Exit Form";
            btnExit.Top = 10;
            btnExit.Left = 80;
            this.Controls.Add(btnExit);
            btnExit.Click += new EventHandler(this.ExitForm);

            pbxPhoto = new PictureBox();
            pbxPhoto.BorderStyle =BorderStyle.Fixed3D;
            pbxPhoto.Width = this.Width / 2;
            pbxPhoto.Height = this.Height / 2;
            pbxPhoto.Left = (this.Width - pbxPhoto.Width) / 2;
            pbxPhoto.Top = (this.Height - pbxPhoto.Height) / 2;
            pbxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPhoto.Dock = DockStyle.Fill;
            this.Controls.Add(pbxPhoto);
            pbxPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
|                               AnchorStyles.Left | AnchorStyles.Right;

            //MessageBox.Show(this.Text);
        }

        private void ExitForm(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HandleLoadClick(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Ngo Van Hao";
            dlg.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbxPhoto.Image = new Bitmap(dlg.OpenFile());
            }
            dlg.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
