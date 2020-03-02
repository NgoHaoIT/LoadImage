using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Load Image";
            pbxImage.BorderStyle = BorderStyle.Fixed3D;
            pbxImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open File";
            ofd.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbxImage.Image = new Bitmap(ofd.OpenFile());
            }
            ofd.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }
    }
}
