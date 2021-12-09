using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop {
    public abstract class ParametrizedFilter<TParams>: IFilter
        where TParams: IParametres, new() 
    {

        public  ParameterInfo[] GetParameters() {
            return new TParams().GetDescription();
        }

        public Photo Process(Photo original, double[] values) {
            var parametres = new TParams();
            parametres.Parse(values);
            return Process(original, parametres);
        }

        public abstract Photo Process(Photo original, TParams parametres);
        
    }
}
