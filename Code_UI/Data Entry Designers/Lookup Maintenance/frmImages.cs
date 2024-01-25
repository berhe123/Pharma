using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharma.Code_UI.Data_Entry_Designers.Lookup_Maintenance
{
    public partial class frmImages : Form
    {
        private const string DialogCaption = " Image Settings";
        public frmImages()
        {
            InitializeComponent();
       
        }
        private void ShowImage()
        {
            try
            {
                if (CImageSetting.OrganizationLogo != null)
                    pictureBox1.Image = CPhoto.ByteArrayToPicture(CImageSetting.OrganizationLogo);
                else
                    pictureBox1.Image = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void frmImages_Load(object sender, EventArgs e)
        {
         this.ShowImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Multiselect = true;
            opf.Filter = "Chose Image (*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif ";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                string picpath = opf.FileName.ToString();
                //textBox_image_path.Text = picpath;
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Chose Image (*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif ";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                string picpath = opf.FileName.ToString();
                //textBox_image_path.Text = picpath;
                pictureBox1.Image = Image.FromFile(opf.FileName);

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Chose Image (*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif ";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                string picpath = opf.FileName.ToString();
                //textBox_image_path.Text = picpath;
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnImportLogo_Click(object sender, EventArgs e)
        {
            try
            {
                dlgOpenFileDialog.Title = "Select a Logo";
                dlgOpenFileDialog.Multiselect = true;
                dlgOpenFileDialog.Filter = "JPEG Compressed Image(*.jpg)|*.jpg|Graphic Interchange Format (*.gif)|*.gif";
                dlgOpenFileDialog.FilterIndex = 2;
                dlgOpenFileDialog.FileName = "";
                dlgOpenFileDialog.ShowDialog();
                pictureBox1.ImageLocation = dlgOpenFileDialog.FileName;
                pictureBox1.Text = dlgOpenFileDialog.FileName;


                pictureBox2.ImageLocation = dlgOpenFileDialog.FileName;
                pictureBox2.Text = dlgOpenFileDialog.FileName;



                pictureBox3.ImageLocation = dlgOpenFileDialog.FileName;
                pictureBox3.Text = dlgOpenFileDialog.FileName;


                pictureBox4.ImageLocation = dlgOpenFileDialog.FileName;
                pictureBox4.Text = dlgOpenFileDialog.FileName;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPasteLogo_Click(object sender, EventArgs e)
        {
            try
            {
                if (Clipboard.GetDataObject() != null)
                {
                    IDataObject data = Clipboard.GetDataObject();

                    if (data.GetDataPresent(DataFormats.Bitmap))
                    {
                        Image image = (Image)data.GetData(DataFormats.Bitmap, true);
                        pictureBox1.Image = image;
                       
                        
                    }
                    else
                    {
                        MessageBox.Show("No image exists in the clipboard.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshLogo_Click(object sender, EventArgs e)
        {
            try
            {
                if (CImageSetting.OrganizationLogo != null)
                {
                    pictureBox1.Image = CPhoto.ByteArrayToPicture(CImageSetting.OrganizationLogo);

                }
                else
                pictureBox1.Image = null;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearLogo_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = null;
              
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WriteSettings()
        {
            try
            {
                
                byte[] logo;
                if (pictureBox1.Image != null)
                {
                    logo = CPhoto.PictureToByteArray(pictureBox1.Image);
                    CImageAppSetting.SaveSetting("Pharma", "OrganizationLogo", "", "", logo, "");
                }
                else
                    CImageAppSetting.SaveSetting("Pharma", "OrganizationLogo", "", "", null, "");


                if (pictureBox2.Image != null)
                {
                    logo = CPhoto.PictureToByteArray(pictureBox2.Image);
                    CImageAppSetting.SaveSetting("Pharma", "OrganizationLogo", "", "", logo, "");
                }
                else
                    CImageAppSetting.SaveSetting("Pharma", "OrganizationLogo", "", "", null, "");


                if (pictureBox3.Image != null)
                {
                    logo = CPhoto.PictureToByteArray(pictureBox3.Image);
                    CImageAppSetting.SaveSetting("Pharma", "OrganizationLogo", "", "", logo, "");
                }
                else
                    CImageAppSetting.SaveSetting("Pharma", "OrganizationLogo", "", "", null, "");


                if (pictureBox4.Image != null)
                {
                    logo = CPhoto.PictureToByteArray(pictureBox4.Image);
                    CImageAppSetting.SaveSetting("Pharma", "OrganizationLogo", "", "", logo, "");
                }
                else
                    CImageAppSetting.SaveSetting("Pharma", "OrganizationLogo", "", "", null, "");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                this.WriteSettings();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}