using System;
using System.Windows.Forms;

namespace MyPhotoshop
{
	class MainClass
	{
        [STAThread]
		public static void Main (string[] args)
		{
			var window=new MainWindow();
			window.AddFilter (new PixelFilter<LighteningParametres>(
				"Осветление/затемнение",
				(pixel, parametres) => pixel * parametres.Coefficient));

			window.AddFilter(new PixelFilter<GrayScaleParametres>(
				"Оттенки серого",
				(pixel, parametres) => {
					var r = pixel.ChanelR * 0.299;
					var g = pixel.ChanelG * 0.587;
					var b = pixel.ChanelB * 0.114;
					var summ = r + g + b;
					return new Pixel(summ, summ, summ);
				}));
			Application.Run (window);
		}
	}
}
