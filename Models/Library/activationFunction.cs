using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCMApp.Models.Library
{
    public class activationFunction
    {
        double valueFroActivationFunction;
        public activationFunction(double valueFroActivationFunction, ISetActivationFunction fun)
        {
            this.valueFroActivationFunction = valueFroActivationFunction;
            actFunction = fun;
        }
        public ISetActivationFunction actFunction { private get; set; }
        public double SetActivationFunction(double valueFroActivationFunction)
        {
            return actFunction.SetActivationFunction(valueFroActivationFunction);
        }
    }
    public interface ISetActivationFunction
    {
        double SetActivationFunction(double valueFroActivationFunction);
    }
    public class bivalentFunction : ISetActivationFunction
    {
        public double SetActivationFunction(double valueFroActivationFunction)
        {
            if (valueFroActivationFunction > 0) return 1;
            else return 0;
        }
    }
    public class trivalentFunction : ISetActivationFunction
    {
        public double SetActivationFunction(double valueFroActivationFunction)
        {
            if (valueFroActivationFunction > 0) return 1;
            if (valueFroActivationFunction == 0) return 0;
            else return -1;
        }
    }
    public class sigmoidFunction : ISetActivationFunction
    {
        public double SetActivationFunction(double valueFroActivationFunction)
        {
            return 1 / (1 - Math.Pow((Math.E), -valueFroActivationFunction));
        }
    }
    public class hyperbolicTangentFunction : ISetActivationFunction
    {
        public double SetActivationFunction(double valueFroActivationFunction)
        {
            return Math.Tan(valueFroActivationFunction);
        }
    }
}
