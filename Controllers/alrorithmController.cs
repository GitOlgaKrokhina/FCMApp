using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using FCMApp.Models;
using FCMApp.Models.Library;

namespace FCMApp.Controllers
{
    public class alrorithmController
    {
        public static int numberOfFactors = 0;
        public static int numberOfIterations = 0;
        public static List<string> namesForChart;
        public static ArrayList listOfWeigthsForGraph;
        public static void getNamesOfFactors(XDocument xDoc)
        {
            List<string> names = new List<string>();
            var factorsWithDecription = xDoc.Root
                .Element("graph")
                .Element("nodes")
                .Elements()
                .Select(p => new
                {
                    name = p.Element("name").Value
                });
            foreach(var nameFactor in factorsWithDecription)
            {
                names.Add(nameFactor.name);
            }
            namesForChart = names;
        }
        public static double[,] loadSchemeAndDoAlgorithm(XDocument xDoc)
        {
            double[,] matrixOfConcepts = null;
            graphFCM newFcmGraph = new graphFCM(
                getActivationFunction(xDoc), 
                getActivationVector(xDoc), 
                getNumberOfIterations(xDoc), 
                getInferenceEquation(xDoc),
                getFactors(xDoc),
                getWeigths(xDoc));
            
            //doVectroOnFactors(newFcmGraph);
            if (newFcmGraph.INFERENCE_EQUATION_FCM == "coscoOutputCircuit")
            {
                matrixOfConcepts = doInferenceEquationCosco(newFcmGraph);
            }
            if (newFcmGraph.INFERENCE_EQUATION_FCM == "modifiedCoscoOutputCircuit")
            {
                matrixOfConcepts = doInferenceEquationModCosco(newFcmGraph);
            }
            if (newFcmGraph.INFERENCE_EQUATION_FCM == "scaledOutputCircuit")
            {
                matrixOfConcepts = doScaledOutputCircuit(newFcmGraph);
            }
            getNamesOfFactors(xDoc);
            return matrixOfConcepts;

        }
        public static string getInferenceEquation(XDocument xDoc)
        {
            return xDoc.Root.Element("inferenceEquation").Value.ToString();
        }
        public static int getNumberOfIterations(XDocument xDoc)
        {
            numberOfIterations = int.Parse(xDoc.Root.Element("numberOfIterations").Value);
            return int.Parse(xDoc.Root.Element("numberOfIterations").Value);
        }
        public static string getActivationFunction(XDocument xDoc)
        {
            return xDoc.Root.Element("activationFunction").Value.ToString();
        }
        public static string getActivationVector(XDocument xDoc)
        {
            return xDoc.Root.Element("activationVector").Value.ToString();
        }
        public static Dictionary<string, double> getFactors(XDocument xDoc)
        {
            Dictionary<string, double> valuesOfFactors = new Dictionary<string, double>();
            var factorsWithDecription = xDoc.Root
                .Element("graph")
                .Element("nodes")
                .Elements()
                .Select(p => new
                {
                    id = p.Element("id").Value,
                    name = p.Element("name").Value,
                    typeFunction = p.Element("membershipFunction").Element("type").Value,
                    parameters = p.Element("membershipFunction").Element("parameters").Value,
                    domain = p.Element("membershipFunction").Element("domain").Value,
                    defuzzificationMethod = p.Element("membershipFunction").Element("defuzzificationMethod").Value
                });

            if (factorsWithDecription != null)
            {
                foreach (var factor in factorsWithDecription)
                {
                    double valueAfterDefuzzification = 0;

                    List<int> domain = factor.domain.Split(';').Select(x => Convert.ToInt32(x)).ToList();
                    int[] valuesForDomain = new int[domain[1] - domain[0] + 1];
                    int newValue = domain[0];
                    int firstValue = domain[0];
                    int lastValue = domain[1];
                    for (int i = 0; i< lastValue - firstValue +  1; i++)
                    {
                        valuesForDomain[i] = newValue;
                        newValue += 1;
                    }

                    List<int> listOfParameters = factor.parameters.Split(';').Select(x => Convert.ToInt32(x)).ToList();

                    double[] valuesAfterFunction = new double[valuesForDomain.Length];
                    
                    if (factor.typeFunction == "TriangularFunction") {
                        TriangularFunction function = new TriangularFunction(valuesForDomain, listOfParameters[0], listOfParameters[1], listOfParameters[2]);
                        valuesAfterFunction = function.GetTriangularFunctionValues(valuesForDomain, listOfParameters[0], listOfParameters[1], listOfParameters[2]);
                    }
                    if (factor.typeFunction == "TrapezoidalFunction") {
                        TrapezoidalFunction function = new TrapezoidalFunction(valuesForDomain, listOfParameters[0], listOfParameters[1], listOfParameters[2], listOfParameters[3]);
                        valuesAfterFunction = function.GetTrapezoidalFunctionValues(valuesForDomain, listOfParameters[0], listOfParameters[1], listOfParameters[2], listOfParameters[3]);
                    }
                    if (factor.typeFunction == "QuadraticSsplineFunction") {
                        QuadraticSsplineFunction function = new QuadraticSsplineFunction(valuesForDomain, listOfParameters[0], listOfParameters[1]);
                        valuesAfterFunction = function.GetQuadraticSsplineFunctionValues(valuesForDomain, listOfParameters[0], listOfParameters[1]);
                    }
                    if (factor.typeFunction == "QuadraticZsplineFunction") {
                        QuadraticZsplineFunction function = new QuadraticZsplineFunction(valuesForDomain, listOfParameters[0], listOfParameters[1]);
                        valuesAfterFunction = function.GetQuadraticZsplineFunctionValues(valuesForDomain, listOfParameters[0], listOfParameters[1]);
                    }
                    if (factor.typeFunction == "ExponentialFunction") {
                        ExponentialFunction function = new ExponentialFunction(valuesForDomain, listOfParameters[0], listOfParameters[1]);
                        valuesAfterFunction = function.GetExponentialFunctionValues(valuesForDomain, listOfParameters[0], listOfParameters[1]);
                    }
                    if (factor.typeFunction == "BellShapedFunction") {
                        BellShapedFunction function = new BellShapedFunction(valuesForDomain, listOfParameters[0], listOfParameters[1], listOfParameters[2]);
                        valuesAfterFunction = function.GetBellShapedFunctionValues(valuesForDomain, listOfParameters[0], listOfParameters[1], listOfParameters[2]);
                    }

                    if (factor.defuzzificationMethod == "centerOfGravityMethod") {
                        defuzzificationMethod newMethod = new defuzzificationMethod(valuesAfterFunction, valuesForDomain, new centerOfGravityMethod());
                        valueAfterDefuzzification = newMethod.Defuzzify(valuesAfterFunction, valuesForDomain);
                    }
                    if (factor.defuzzificationMethod == "middleOfMaximaMethod") {
                        defuzzificationMethod newMethod = new defuzzificationMethod(valuesAfterFunction, valuesForDomain, new middleOfMaximaMethod());
                        valueAfterDefuzzification = newMethod.Defuzzify(valuesAfterFunction, valuesForDomain);
                    }

                    valuesOfFactors.Add($"F{factor.id}", valueAfterDefuzzification);
                }
            }
            numberOfFactors = valuesOfFactors.Count();
            return valuesOfFactors;

        }
        public static ArrayList getWeigths(XDocument xDoc)
        {
            ArrayList listOfWeigths = new ArrayList();

            var weigthsAndNodes = xDoc.Root
                .Element("graph")
                .Element("edges")
                .Elements()
                .Select(p => new
                {
                    targetNodeID = Convert.ToDouble(p.Attribute("targetNodeID").Value.Replace('.', ',')),
                    sourceNodeID = Convert.ToDouble(p.Attribute("sourceNodeID").Value.Replace('.', ',')),
                    weight = Convert.ToDouble(p.Attribute("weight").Value.Replace('.', ','))
                });

            if (weigthsAndNodes != null)
            {
                foreach (var edge in weigthsAndNodes)
                {
                    listOfWeigths.Add(new List<double> { 
                        edge.sourceNodeID, 
                        edge.targetNodeID,
                        edge.weight} );
                }
            }
            listOfWeigthsForGraph = listOfWeigths;
            return listOfWeigths;
        }
        public static void doVectroOnFactors(graphFCM newFcmGraph)
        {
            Dictionary<string, double> values = newFcmGraph.VALUES_NODES;
            List<int> listOfParameters = newFcmGraph.ACTIVATION_VECTOR_FCM.Split(';').Select(x => Convert.ToInt32(x)).ToList();
            for(int i = 0; i< listOfParameters.Count; i++)
            {
                values[$"F{i + 1}"] *= listOfParameters[i];
            }
        }
        public static double[,] doInferenceEquationCosco(graphFCM newFcmGraph)
        {
            int numOfFactors = newFcmGraph.VALUES_NODES.Count;
            int numOfUterations = newFcmGraph.NUMBER_OF_ITERATIONS_FCM;
            double[,] matrixOfConcepts = new double[ numOfUterations+1, numOfFactors];
            Dictionary<string, double> values = newFcmGraph.VALUES_NODES;
            ArrayList edgesWeigths = newFcmGraph.VALUES_EDGES;

            for (int i = 0; i < numOfFactors; i++)
            {
                matrixOfConcepts[0, i] = values[$"F{i + 1}"];
            }

            for(int iter = 1; iter < numOfUterations+1; iter++)
            {
                for (int i = 0; i < numOfFactors; i++)
                {
                    double tempValue = 0;
                    foreach (List<double> weight in edgesWeigths)
                    {
                        if (weight[1] == i + 1)
                        {
                            tempValue += weight[2] * matrixOfConcepts[iter - 1, Convert.ToInt32(weight[0])-1];
                        }
                    }

                    if (newFcmGraph.ACTIVATION_FUNCTION_FCM == "bivalentFunction")
                    {
                        activationFunction function = new activationFunction(tempValue, new bivalentFunction());
                        matrixOfConcepts[iter, i] = function.SetActivationFunction(tempValue);
                    }
                    if (newFcmGraph.ACTIVATION_FUNCTION_FCM == "trivalentFunction")
                    {
                        activationFunction function = new activationFunction(tempValue, new trivalentFunction());
                        matrixOfConcepts[iter, i] = function.SetActivationFunction(tempValue);
                    }
                    if (newFcmGraph.ACTIVATION_FUNCTION_FCM == "sigmoidFunction")
                    {
                        activationFunction function = new activationFunction(tempValue, new sigmoidFunction());
                        matrixOfConcepts[iter, i] = function.SetActivationFunction(tempValue);
                    }
                    if (newFcmGraph.ACTIVATION_FUNCTION_FCM == "hyperbolicTangentFunction")
                    {
                        activationFunction function = new activationFunction(tempValue, new hyperbolicTangentFunction());
                        matrixOfConcepts[iter, i] = function.SetActivationFunction(tempValue);
                    }
                }
            }
            return matrixOfConcepts;
        }
        public static double[,] doInferenceEquationModCosco(graphFCM newFcmGraph)
        {
            
            int numOfFactors = newFcmGraph.VALUES_NODES.Count;
            int numOfUterations = newFcmGraph.NUMBER_OF_ITERATIONS_FCM;
            double[,] matrixOfConcepts = new double[numOfUterations + 1, numOfFactors];
            Dictionary<string, double> values = newFcmGraph.VALUES_NODES;
            ArrayList edgesWeigths = newFcmGraph.VALUES_EDGES;

            for (int i = 0; i < numOfFactors; i++)
            {
                matrixOfConcepts[0, i] = values[$"F{i + 1}"];
            }

            for (int iter = 1; iter < numOfUterations + 1; iter++)
            {
                for (int i = 0; i < numOfFactors; i++)
                {
                    double tempValue = 0;
                    foreach (List<double> weight in edgesWeigths)
                    {
                        if (weight[1] == i + 1)
                        {
                            tempValue += weight[2] * matrixOfConcepts[iter - 1, Convert.ToInt32(weight[0]) - 1];
                        }
                    }
                    tempValue += matrixOfConcepts[iter - 1, i];
                    if (newFcmGraph.ACTIVATION_FUNCTION_FCM == "bivalentFunction")
                    {
                        activationFunction function = new activationFunction(tempValue, new bivalentFunction());
                        matrixOfConcepts[iter, i] = function.SetActivationFunction(tempValue);
                    }
                    if (newFcmGraph.ACTIVATION_FUNCTION_FCM == "trivalentFunction")
                    {
                        activationFunction function = new activationFunction(tempValue, new trivalentFunction());
                        matrixOfConcepts[iter, i] = function.SetActivationFunction(tempValue);
                    }
                    if (newFcmGraph.ACTIVATION_FUNCTION_FCM == "sigmoidFunction")
                    {
                        activationFunction function = new activationFunction(tempValue, new sigmoidFunction());
                        matrixOfConcepts[iter, i] = function.SetActivationFunction(tempValue);
                    }
                    if (newFcmGraph.ACTIVATION_FUNCTION_FCM == "hyperbolicTangentFunction")
                    {
                        activationFunction function = new activationFunction(tempValue, new hyperbolicTangentFunction());
                        matrixOfConcepts[iter, i] = function.SetActivationFunction(tempValue);
                    }
                }
            }
            return matrixOfConcepts;
        }
        public static double[,] doScaledOutputCircuit(graphFCM newFcmGraph)
        {
            
            int numOfFactors = newFcmGraph.VALUES_NODES.Count;
            int numOfUterations = newFcmGraph.NUMBER_OF_ITERATIONS_FCM;
            double[,] matrixOfConcepts = new double[numOfUterations + 1, numOfFactors];
            Dictionary<string, double> values = newFcmGraph.VALUES_NODES;
            ArrayList edgesWeigths = newFcmGraph.VALUES_EDGES;

            for (int i = 0; i < numOfFactors; i++)
            {
                matrixOfConcepts[0, i] = values[$"F{i + 1}"];
            }

            for (int iter = 1; iter < numOfUterations + 1; iter++)
            {
                for (int i = 0; i < numOfFactors; i++)
                {
                    double tempValue = 0;
                    foreach (List<double> weight in edgesWeigths)
                    {
                        if (weight[1] == i + 1)
                        {
                            tempValue += weight[2] * (matrixOfConcepts[iter - 1, Convert.ToInt32(weight[0])-1] * 2 - 1);
                        }
                    }
                    tempValue += 2 * matrixOfConcepts[iter - 1,i] - 1;
                    if (newFcmGraph.ACTIVATION_FUNCTION_FCM == "bivalentFunction")
                    {
                        activationFunction function = new activationFunction(tempValue, new bivalentFunction());
                        matrixOfConcepts[iter, i] = function.SetActivationFunction(tempValue);
                    }
                    if (newFcmGraph.ACTIVATION_FUNCTION_FCM == "trivalentFunction")
                    {
                        activationFunction function = new activationFunction(tempValue, new trivalentFunction());
                        matrixOfConcepts[iter, i] = function.SetActivationFunction(tempValue);
                    }
                    if (newFcmGraph.ACTIVATION_FUNCTION_FCM == "sigmoidFunction")
                    {
                        activationFunction function = new activationFunction(tempValue, new sigmoidFunction());
                        matrixOfConcepts[iter, i] = function.SetActivationFunction(tempValue);
                    }
                    if (newFcmGraph.ACTIVATION_FUNCTION_FCM == "hyperbolicTangentFunction")
                    {
                        activationFunction function = new activationFunction(tempValue, new hyperbolicTangentFunction());
                        matrixOfConcepts[iter, i] = function.SetActivationFunction(tempValue);
                    }
                }
            }
            return matrixOfConcepts;
        }
    }
}
