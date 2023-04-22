using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCMApp.Models.Library
{
    public class membershipFunction
    {
        object TYPE_MFUNCTION;
        double[] PARAMETERS_MFUNCTION;
        int[] DOMAIN_MFUCTION = new int[2];
        defuzzificationMethod DEFUZZIFICZTION_METHOD_MFUNCTION;
        public membershipFunction(object type, double[] parameters, int[] domain, defuzzificationMethod dMethod)
        {
            this.TYPE_MFUNCTION = type;
            this.PARAMETERS_MFUNCTION = parameters;
            this.DOMAIN_MFUCTION = domain;
            this.DEFUZZIFICZTION_METHOD_MFUNCTION = dMethod;
        }

    }
    public class TriangularFunction
    {
        int[] x;
        int leftA;
        int rightB;
        int middleC;
        public TriangularFunction(int[] x, int leftA, int middleC, int rightB)
        {
            this.x = x;
            this.leftA = leftA;
            this.rightB = rightB;
            this.middleC = middleC;
        }

        public double[] GetTriangularFunctionValues(int[] x, int leftA, int middleC, int rightB)
        {
            double[] arrayY = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] <= leftA) arrayY[i] = 0;

                if (leftA <= x[i] && x[i] < middleC)
                {
                    if (middleC == leftA) arrayY[i] = 1;
                    else arrayY[i] = (x[i] - leftA) / (middleC - leftA);
                }
                    
                if (x[i] == middleC) arrayY[i] = 1;

                if (middleC < x[i] && x[i] <= rightB)
                {
                    if (rightB == middleC) arrayY[i] = 1;
                    else arrayY[i] = (rightB - x[i]) / (rightB - middleC);
                }

                    

                if (x[i] >= rightB) arrayY[i] = 0;
            }
            return arrayY;
        }
    }
    public class TrapezoidalFunction
    {
        int[] x;
        int leftA;
        int rightB;
        int firstMiddleC;
        int secondMiddleD;
        public TrapezoidalFunction(int[] x, int leftA, int firstMiddleC, int secondMiddleD, int rightB)
        {
            this.x = x;
            this.leftA = leftA;
            this.rightB = rightB;
            this.firstMiddleC = firstMiddleC;
            this.secondMiddleD = secondMiddleD;
        }

        public double[] GetTrapezoidalFunctionValues(int[] x, int leftA, int firstMiddleC, int secondMiddleD, int rightB)
        {
            double[] arrayY = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] <= leftA) arrayY[i] = 0;
                
                if (leftA <= x[i] && x[i] <= firstMiddleC)
                {
                    if (firstMiddleC == leftA) { arrayY[i] = 1; }
                    else arrayY[i] = (x[i] - leftA) / (firstMiddleC - leftA);
                }
                
                if (firstMiddleC <= x[i] && x[i] <= secondMiddleD) arrayY[i] = 1;
                
                if (secondMiddleD <= x[i] && x[i] <= rightB)
                {
                    if(rightB == secondMiddleD) { arrayY[i] = 1; }
                    else arrayY[i] = (rightB - x[i]) / (rightB - secondMiddleD);
                } 
               
                if (x[i] >= rightB) arrayY[i] = 0;
            }
            return arrayY;
        }
    }
    public class QuadraticSsplineFunction
    {
        int[] x;
        int leftA;
        int rightB;
        public QuadraticSsplineFunction(int[] x, int leftA, int rightB)
        {
            this.x = x;
            this.leftA = leftA;
            this.rightB = rightB;
        }
        public double[] GetQuadraticSsplineFunctionValues(int[] x, int leftA, int rightB)
        {
            double[] arrayY = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] <= leftA) arrayY[i] = 0;
                if (leftA < x[i] && x[i] <= (leftA + rightB) / 2) arrayY[i] = (2 * Math.Pow(x[i] - leftA, 2)) / Math.Pow(rightB - leftA, 2);
                if ((leftA + rightB) / 2 < x[i] && x[i] < rightB) arrayY[i] = 1 - (2 * Math.Pow(x[i] - leftA, 2)) / Math.Pow(rightB - leftA, 2);
                if (x[i] >= rightB) arrayY[i] = 1;
            }
            return arrayY;
        }
    }
    public class QuadraticZsplineFunction
    {
        int[] x;
        int leftA;
        int rightB;
        public QuadraticZsplineFunction(int[] x, int leftA, int rightB)
        {
            this.x = x;
            this.leftA = leftA;
            this.rightB = rightB;
        }
        public double[] GetQuadraticZsplineFunctionValues(int[] x, int leftA, int rightB)
        {
            double[] arrayY = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] <= leftA) arrayY[i] = 1;
                if (leftA < x[i] && x[i] <= (leftA + rightB) / 2) arrayY[i] = 1 - (2 * Math.Pow(x[i] - leftA, 2)) / Math.Pow(rightB - leftA, 2);
                if ((leftA + rightB) / 2 < x[i] && x[i] < rightB) arrayY[i] = (2 * Math.Pow(x[i] - leftA, 2)) / Math.Pow(rightB - leftA, 2);
                if (x[i] >= rightB) arrayY[i] = 0;
            }
            return arrayY;
        }
    }
    public class ExponentialFunction
    {
        int[] x;
        double maximaA;
        double concentrationB;
        public ExponentialFunction(int[] x, double maximaA, double concentrationB)
        {
            this.x = x;
            this.maximaA = maximaA;
            this.concentrationB = concentrationB;
        }
        public double[] GetExponentialFunctionValues(int[] x, double maximaA, double concentrationB)
        {
            double[] arrayY = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                arrayY[i] = Math.Exp((-Math.Pow(x[i] - maximaA, 2)) / (2 * concentrationB * concentrationB));
            }
            return arrayY;
        }
    }
    public class BellShapedFunction
    {
        int[] x;
        double concentrationA;
        double coefB;
        double maximaC;
        public BellShapedFunction(int[] x, double concentrationA, double coefB, double maximaC)
        {
            this.x = x;
            this.concentrationA = concentrationA;
            this.coefB = coefB;
            this.maximaC = maximaC;
        }

        public double[] GetBellShapedFunctionValues(int[] x, double concentrationA, double coefB, double maximaC)
        {
            double[] arrayY = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                arrayY[i] = 1 / (1 + Math.Pow(Math.Abs((x[i] - maximaC) / concentrationA), 2 * coefB));
            }
            return arrayY;
        }
    }
}
