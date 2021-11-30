using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop {
    public class GrayScaleParametres : IParametres {
        public ParameterInfo[] GetDescription() {
            return new ParameterInfo[0];
        }

        public void Parse(double[] parametres) {}
    }
}
