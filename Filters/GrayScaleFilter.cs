using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop {
    public class GrayScaleFilter : PixelFilter<GrayScaleParametres> { 

      //  public GrayScaleFilter() :base(new GrayScaleParametres()) { }

        private readonly double r = 0.299;
        private readonly double g = 0.587;
        private readonly double b = 0.114;

   
        public override string ToString() {
            return "Оттенки серого";
        }

        public override Pixel ProcessPixel(Pixel pixel, GrayScaleParametres parameters) {
            var r = pixel.ChanelR * this.r;
            var g = pixel.ChanelG * this.g;
            var b = pixel.ChanelB * this.b;
            var summ = r + g + b;
            return new Pixel(summ, summ, summ);
        }
    }
}
