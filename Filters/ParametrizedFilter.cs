using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop {
    public abstract class ParametrizedFilter: IFilter {

        IParametres parametres;

        public ParametrizedFilter(IParametres parametres) {
            this.parametres = parametres;
        }

        public  ParameterInfo[] GetParameters() {
            return parametres.GetDescription();
        }


        public Photo Process(Photo original, double[] values) {
            this.parametres.Parse(values);
            return Process(original, this.parametres);
            
        }

        public abstract Photo Process(Photo original, IParametres parametres);
        
    }
}
