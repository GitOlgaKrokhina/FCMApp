using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCMApp.Controllers
{
    public class successFactorController
    {
        public static string returnValueOfMembershipFunction(string text)
        {
            if (text == "треугольная") return  "TriangularFunction";
            if (text == "трапециевидная") return "TrapezoidalFunction";
            if (text == "квадратичная S-сплайн") return "QuadraticSsplineFunction";
            if (text == "квадратичная Z-сплайн") return "QuadraticZsplineFunction";
            if (text == "экспоненциальная (гауссова)") return "ExponentialFunction";
            if (text == "колоколообразная") return "BellShapedFunction";
            else return "";

        }
        public static string returnValueOfDefuzzification(string text)
        {
            if (text == "метод среднего максимумам (Middle of Maxima)") return "middleOfMaximaMethod";
            if (text == "метод центра тяжести (Center of Gravity)") return "centerOfGravityMethod";
            else return "";

        }
    }
}
