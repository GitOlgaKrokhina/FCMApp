using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using FCMApp.Models.Library;

namespace FCMApp.Models
{
    public class fuzzyCognitiveMap
    {

        
        public static XDocument task1 = new XDocument(new XDeclaration(null, "us-ascii", null));

        
        public static void LoadScheme()
        {
            task1.Add(new XElement("FCM"));
            task1.Root.Add(new XElement("graph", new XElement("nodes"), new XElement("edges")));
        }
        public static void addParametersToScheme(string activationFunct, string activationVector, string numIteration, string inferenceEq)
        {
            task1.Root.Add(new XElement("activationFunction", activationFunct));
            task1.Root.Add(new XElement("numberOfIterations", numIteration));
            task1.Root.Add(new XElement("activationVector", activationVector));
            task1.Root.Add(new XElement("inferenceEquation", inferenceEq));
        }
        public static void addFactorToScheme(int id, string name, string membershipFunctName, string parameters, string domain, string defuzzMethod)
        {
            XElement factor = new XElement("factor", 
                new XElement("id",id), 
                new XElement("name", name),
                new XElement("membershipFunction",
                    new XElement("type", membershipFunctName),
                    new XElement("parameters", parameters),
                    new XElement("domain", domain),
                    new XElement("defuzzificationMethod", defuzzMethod))
                );
            XElement xRoot = task1.Root;
            xRoot.Element("graph").Element("nodes").Add(factor);
        }

        public static void addEdgesToScheme(double[,] matrix, int numberOfFactors)
        {
            for (int i = 0; i < numberOfFactors; i++)
                for (int j = 0; j < numberOfFactors; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        XElement edge = new XElement("edge", new XAttribute("sourceNodeID",i+1), new XAttribute("targetNodeID",j+1), new XAttribute("weight", Convert.ToDouble(matrix[i, j])));
                        XElement xRoot = task1.Root;
                        xRoot.Element("graph").Element("edges").Add(edge);
                    }
                }

            saveScheme();
        }
        public static void saveScheme()
        {
            task1.Save("D:\\Desktop\\Desktop\\Курсовая\\FCMApp\\Data\\fcm1.xml");
        }
        public static XDocument returnScheme()
        {
            return task1;
        }


    }
}
