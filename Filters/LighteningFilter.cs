using System;


namespace MyPhotoshop
{
	public class LighteningFilter :  PixelFilter<LighteningParametres>
	{

        public override Pixel ProcessPixel(Pixel pixel, LighteningParametres parameters) {
            return pixel * parameters.Coefficient;
        }

        public override string ToString ()
		{
			return "Осветление/затемнение";
		}
    }
}

