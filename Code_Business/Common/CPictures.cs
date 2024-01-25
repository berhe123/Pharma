using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
namespace Pharma
{
    class CPicture
    {
        public static byte[] GetPictureByteFromFile(string strImageFileName)
        {
            FileStream fStream = new FileStream(strImageFileName, FileMode.Open, FileAccess.Read);
            // Create a buffer to hold the stream of bytes
            byte[] ImageBuffer = new byte[fStream.Length];
            // Read the bytes from this stream and put it into the image buffer
            fStream.Read(ImageBuffer, 0, (int)fStream.Length);
            // Close the stream
            fStream.Close();
            return ImageBuffer;
        }
        public static byte[] PictureToByteArray(System.Drawing.Image image)
        {

            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public static Image ByteArrayToPicture(byte[] byteArray)
        {
            // Create a buffer to hold the stream of bytes
            MemoryStream ms = new MemoryStream(byteArray);
            // Read the bytes from this stream and put it into the image buffer
            Image returnImage = Image.FromStream(ms);

            return returnImage;
        }

        public static void ShowPicture(byte[] myByteArray, PictureBox picImage, int intMaxWidth, int intMaxHeight)
        {
            //int intMaxWidth = 200;
            //int intMaxHeight = 200;
            if (myByteArray.Length > 0)
            {
                // Create a new MemoryStream and write all the information from
                // the byte array into the stream
                MemoryStream fStream = new MemoryStream(myByteArray, true);
                fStream.Write(myByteArray, 0, myByteArray.Length);

                // Use the MemoryStream to create the new BitMap object
                Bitmap FinalImage = new Bitmap(fStream);
                // See if the image stored will fit in the picture box. If it's too big, 
                // resize and create a new BitMap object and assign to the PictureBox control
                if (FinalImage.Width > intMaxWidth && FinalImage.Height > intMaxHeight)
                {
                    Bitmap AlteredImage = new Bitmap(FinalImage, new Size(intMaxWidth, intMaxHeight));
                    picImage.Image = AlteredImage;
                }
                else
                    picImage.Image = FinalImage;

                // Close the stream
                fStream.Close();
            }
        }
        public static void ShowPicture(byte[] myByteArray, PictureBox picImage)
        {

            if (myByteArray.Length > 0)
            {
                // Create a new MemoryStream and write all the information from
                // the byte array into the stream
                MemoryStream fStream = new MemoryStream(myByteArray, true);
                fStream.Write(myByteArray, 0, myByteArray.Length);

                // Use the MemoryStream to create the new BitMap object
                Bitmap FinalImage = new Bitmap(fStream);

                picImage.Image = FinalImage;

                // Close the stream
                fStream.Close();
            }
        }
    }

}
