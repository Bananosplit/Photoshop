using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop {
    public abstract class PixelFilter: ParametrizedFilter  {

        public PixelFilter(IParametres parametres): base(parametres) {}
        public abstract Pixel ProcessPixel(Pixel pixel, IParametres parametres);

        public override Photo Process(Photo original, IParametres parameters) {

            var photo = new Photo(original.width, original.height);

            for (int x = 0; x < original.width; x++) 
                for (int y = 0; y < original.height; y++) 
                    photo[x, y] = ProcessPixel(original[x, y], parameters);

            return photo;
        }

    }
}
