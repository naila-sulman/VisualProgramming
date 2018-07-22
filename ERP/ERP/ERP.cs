using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ERP
{
    public partial class ERP : Form
    {
        public ERP()
        {
            InitializeComponent();
        }
        private static Bitmap ChangeOpacity(Image img, float opacityvalue)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height); // Determining Width and Height of Source Image
            Graphics graphics = Graphics.FromImage(bmp);
            ColorMatrix colormatrix = new ColorMatrix();
            colormatrix.Matrix33 = opacityvalue;
            ImageAttributes imgAttribute = new ImageAttributes();
            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
            graphics.Dispose();   // Releasing all resource used by graphics 
            return bmp;
        }

        float opacityvalue = 0.1f;

        private void ERP_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = ChangeOpacity(Image.FromFile(@"C:\Users\Sulman\Desktop\erp_logo_lg.jpg"), opacityvalue);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            opacityvalue += 0.05f;
            pictureBox1.Image = ChangeOpacity(Image.FromFile(@"C:\Users\Sulman\Desktop\erp_logo_lg.jpg"), opacityvalue);
            if (opacityvalue >= 1.0f)
            {
                timer1.Stop();
                timer2.Start();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            opacityvalue -= 0.05f;
            pictureBox1.Image = ChangeOpacity(Image.FromFile(@"C:\Users\Sulman\Desktop\erp_logo_lg.jpg"), opacityvalue);
            if (opacityvalue < 0.1f)
            {
                timer2.Stop();
                Login loginfrm = new Login();
                loginfrm.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
