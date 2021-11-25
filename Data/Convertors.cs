using System;
using System.Drawing;

namespace MyPhotoshop
{
	public static class Convertors
	{
		public static Photo Bitmap2Photo(Bitmap bmp)
		{
			var photo = new Photo(bmp.Width, bmp.Height);

            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++) {
                    var pixel = bmp.GetPixel(x, y);
					photo[x, y] = new Pixel(
						(double)pixel.R / 255,
						(double)pixel.G / 255,
						(double)pixel.B / 255
					);
				}
            return photo;
		}

        static int ToChannel(double val) {
            return (int)(val * 255);
        }

        public static Bitmap Photo2Bitmap(Photo photo)
		{
			var bmp = new Bitmap(photo.width,photo.height);
			for (int x = 0; x < bmp.Width; x++)
				for (int y = 0; y < bmp.Height; y++)
					bmp.SetPixel(x, y, Color.FromArgb(
                        ToChannel(photo[x, y].ChanelR),
                        ToChannel(photo[x, y].ChanelG),
                        ToChannel(photo[x, y].ChanelB)
                        ));
					       		
			return bmp;
		}
	}
}

