using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCMApp.Models.Library
{
    public class defuzzificationMethod
    {
        double[] valuesAfterFunction;
        int[] domainValues;
        public defuzzificationMethod(double[] valuesAfterFunction, int[] domainValues, IDefuzzified mov)
        {
            this.valuesAfterFunction = valuesAfterFunction;
            this.domainValues = domainValues;
            Defuzzified = mov;
        }
        public IDefuzzified Defuzzified { private get; set; }
        public double Defuzzify(double[] valuesAfterFunction, int[] domainValues)
        {
            return Defuzzified.Defuzzify(valuesAfterFunction, domainValues);
        }
    }
    public interface IDefuzzified
    {
        double Defuzzify(double[] valuesAfterFunction, int[] domainValues);
    }
    public class centerOfGravityMethod : IDefuzzified
    {
        public double Defuzzify(double[] valuesAfterFunction, int[] domainValues)
        {
            int numberOfVAlues = domainValues.Length;

            double[] valuesOfFunction = new double[numberOfVAlues];

            for (int i = 0; i < numberOfVAlues; i++)
            {
                valuesOfFunction[i] = domainValues[i] * valuesAfterFunction[i];
            }
            double numerator = valuesOfFunction.Sum();
            double denominator = valuesAfterFunction.Sum();
            return numerator / denominator;

        }
    }
    public class middleOfMaximaMethod : IDefuzzified
    {
        public double Defuzzify(double[] valuesAfterFunction, int[] domainValues)
        {
            int numberOfVAlues = domainValues.Length;
            int numberOfMaxima = 0;

            for (int i = 0; i < numberOfVAlues; i++)
            {
                if(valuesAfterFunction[i] == valuesAfterFunction.Max())
                {
                    numberOfMaxima++;
                }
            }
            int[] domainValuesWithMaxima = new int[numberOfVAlues];
            for (int i = 0; i < numberOfVAlues; i++)
            {
                if (valuesAfterFunction[i] == valuesAfterFunction.Max())
                {
                    domainValuesWithMaxima[i] = domainValues[i];
                }
            }

            double numerator = domainValuesWithMaxima.Sum();
            return numerator / numberOfMaxima;

        }
    }
}
