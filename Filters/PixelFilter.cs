using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop {
    public class PixelFilter<TParam>: ParametrizedFilter<TParam>
        where TParam: IParametres, new()
    {
        public readonly string FilterName;
        Func<Pixel, TParam, Pixel> ProcessPixel;

        public PixelFilter(string nameFilter, Func<Pixel, TParam, Pixel> processPixel) {
            FilterName = nameFilter;
            ProcessPixel = processPixel;
        }

        public override Photo Process(Photo original, TParam parameters) {
            
            var photo = new Photo(original.width, original.height);
            
            for (int x = 0; x < original.width; x++) 
                for (int y = 0; y < original.height; y++)
                    photo[x, y] = ProcessPixel(original[x, y], parameters);
            
            return photo;
        }

        public override string ToString() {
            return FilterName;
        }
    }
}


