using System;


namespace MyPhotoshop
{
	public class LighteningFilter : PixelFilter, IFilter
	{
		public override ParameterInfo[] GetParameters()
		{
			return new []
			{
				new ParameterInfo { Name="Коэффициент", MaxValue=10, MinValue=0, Increment=0.1, DefaultValue=1 }
				
			};
		}
		
		public override string ToString ()
		{
			return "Осветление/затемнение";
		}

		protected override Pixel ProcessPixel(Pixel pixel, double[] parameters) {
            return new Pixel(pixel * parameters[0]);
        }
    }
}

