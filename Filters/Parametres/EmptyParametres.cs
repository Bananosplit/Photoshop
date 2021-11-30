using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop {
    public class EmptyParametres : IParametres {

        double Coeficient;

        public ParameterInfo[] GetDescription() {
            return new ParameterInfo[0];
        }

        public void Parse(double[] parametres) {
            Coeficient = 0;
        }
    }
}
