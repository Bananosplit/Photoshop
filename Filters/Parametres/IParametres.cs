using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop {
    public interface IParametres {
        /// <summary>
        /// Возвращает информацию о настройках
        /// </summary>
        /// <returns></returns>
        ParameterInfo[] GetDescription();


        /// <summary>
        /// Устанавливает поля класса в соответствии с массивом переданных величин
        /// </summary>
        /// <param name="parametres"></param>
        void Parse(double[] parametres);

    }
}
