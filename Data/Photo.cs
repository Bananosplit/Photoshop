using System;

namespace MyPhotoshop
{
	public class Photo
	{
        public Photo(int width, int height) {
			this.width = width;
			this.height = height;
			Pixels = new Pixel[width, height];
        }

		public readonly int width;
		public readonly int height;	
		public readonly Pixel[,] Pixels;

        public Pixel this[int x, int y] {
            get { return Pixels[x, y]; }
            set {Pixels[x, y] = value;}
        }        
    }
}

