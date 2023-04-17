using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attractionsApp
{
    internal class Attraction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Image Pic { get; set; }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
            Image img = (Image)converter.ConvertFrom(byteArrayIn);

            return img;
        }

        public void SetPicFromBlob(Stream blob)
        {
            Pic = Image.FromStream(blob);
        }
    }
}
