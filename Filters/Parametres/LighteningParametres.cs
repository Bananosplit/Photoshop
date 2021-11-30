using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop {
    public class LighteningParametres : IParametres {

        public double Coefficient;

        public ParameterInfo[] GetDescription() {
            return new[]
            {
                new ParameterInfo { Name="Коэффициент", MaxValue=10, MinValue=0, Increment=0.1, DefaultValue=1 }
            };
        }

        public void Parse(double[] parametres) {
            Coefficient = parametres[0];
        }
    }
}
