using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace CropImage
{
    public partial class FormCropImage : Form
    {
        int picBox_width;
        int picBox_height;
        float picBox_scale;
        Bitmap bitmap;
        public FormCropImage()
        {
            InitializeComponent();
            picBox_width = picBox_original.Width;
            picBox_height = picBox_original.Height;
            picBox_scale = (float)picBox_width / picBox_height;
        }
        OpenFileDialog open = new OpenFileDialog();
        private void picBox_original_Click(object sender, EventArgs e)
        {
            open.Title = "Select files to crop";
            open.Multiselect = true;
            open.Filter = "Images *.JPG;*.PNG|*.jpg;*.png|"
                            + "JPG Files|*.jpg|"
                            + "PNG Files|*.png|"
                            + "All Files|*.*";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bitmap = new Bitmap(open.FileName);
                bitmap = ConvertTo32bpp(bitmap);

                fillBox(picBox_original, bitmap, textview_sizeOriginal);
                Bitmap bm = crop(bitmap);
                fillBox(picBox_crop, bm, textview_sizeCrop);
            }
        }
        private Bitmap ConvertTo32bpp(Image img)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height));
            return bmp;
        }
        private void fillBox(PictureBox picBox, Bitmap bm, TextBox textview_size)
        {

            picBox.Width = picBox_width;
            picBox.Height = picBox_height;
            float picScale = (float)bm.Width / bm.Height;
            if (picScale > picBox_scale)
                picBox.Height = (int)(picBox_height / picScale * picBox_scale);
            else if (picScale < picBox_scale)
                picBox.Width = (int)(picBox_width * picScale / picBox_scale);
            picBox.Image = bm;
            textview_size.Text = String.Format(@"{0}x{1}", bm.Width, bm.Height);
        }
        private Bitmap crop(Bitmap bitmap)
        {
            if (bitmap == null) return null;

            int newWidth = bitmap.Width * (200 - (int)(nud_left.Value + nud_right.Value)) / 200;
            int newHeight = bitmap.Height * (200 - (int)(nud_top.Value + nud_bot.Value)) / 200;

            if (newWidth * newHeight == 0) return null;
            Bitmap bm = new Bitmap(newWidth, newHeight);

            Graphics g = Graphics.FromImage(bm);
            int newX = (int)(bitmap.Width * nud_left.Value / 200);
            int newY = (int)(bitmap.Height * nud_top.Value / 200);
            g.DrawImage(bitmap, -newX, -newY);

            return bm;
        }

        private void resize(object sender, EventArgs e)
        {
            Bitmap bm = crop(bitmap);
            fillBox(picBox_crop, bm, textview_sizeCrop);
        }

        private void btn_resize_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.Description = "Select the directory that you want to save file.";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                String path = fbd.SelectedPath + "\\crop_";
                foreach (string file in open.FileNames)
                {
                    Bitmap bm = new Bitmap(file);
                    bm = ConvertTo32bpp(bm);
                    bm = crop(bm);
                    bm.Save(path+file.Substring(file.LastIndexOf('\\') + 1), ImageFormat.Png);
                }
            }
        }
    }
}
