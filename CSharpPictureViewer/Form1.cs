using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpPictureViewer
{
    public partial class frmMain : Form
    {
        protected string[] picFileName;
        protected int picCurrentImage = -1;
        protected bool youAreCool = true;
        
        public frmMain()
        {
            InitializeComponent();            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        public void btnLoadPics_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "JPEG|*.jpg|Bitmaps|*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picFileName = ofd.FileNames;
                picCurrentImage = 0;
                pictureBox1.BackgroundImage = null;
                pictureBox1.Image = Bitmap.FromFile(picFileName[picCurrentImage]);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (youAreCool)
            {
                picCurrentImage = picCurrentImage == 0 ? picFileName.Length - 1 : --picCurrentImage;
                pictureBox1.Image = Bitmap.FromFile(picFileName[picCurrentImage]);
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (youAreCool)
            {
                picCurrentImage = picCurrentImage == picFileName.Length - 1 ? 0 : ++picCurrentImage;
                pictureBox1.Image = Bitmap.FromFile(picFileName[picCurrentImage]);
            }
        }
    }
}
