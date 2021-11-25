using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop {
    class GrayScaleFilter : IFilter {
        public readonly double R = 0.299;
        public readonly double G = 0.587;
        public readonly double B = 0.114;

        public ParameterInfo[] GetParameters() {
            return new ParameterInfo[] {
               new ParameterInfo() {  }
            };
        }

        Pixel SetPixelForGrayFilter(Pixel first, Pixel second) {
            var r = first.ChanelR * second.ChanelR;
            var g = first.ChanelG * second.ChanelG;
            var b = first.ChanelB * second.ChanelB;
            var summ = r + g + b;
            return new Pixel(summ, summ, summ);
        }

        public Photo Process(Photo original, double[] parameters) {
            var photo = new Photo(original.width, original.height);
            var parametresPixel = new Pixel(R, G, B);

            for (int x = 0; x < original.width; x++) {
                for (int y = 0; y < original.height; y++) {
                    photo[x, y] = SetPixelForGrayFilter(original[x,y], parametresPixel );
                }
            }

            return photo;
        }

        public override string ToString() {
            return "Оттенки серого";
        }
    }
}
