using System;


namespace MyPhotoshop
{
	public class LighteningFilter : PixelFilter
	{
        public LighteningFilter(): base(new LighteningParametres()) {}

        public override Pixel ProcessPixel(Pixel pixel, IParametres parameters) {
            return pixel * (parameters as LighteningParametres).Coefficient;
        }

        public override string ToString ()
		{
			return "Осветление/затемнение";
		}
    }
}

