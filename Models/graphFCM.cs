using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCMApp.Models
{
    public class graphFCM
    {
        public string NAME_FCM;
        public string ID_FCM;


        public string ACTIVATION_FUNCTION_FCM;
        public int NUMBER_OF_ITERATIONS_FCM;
        public string ACTIVATION_VECTOR_FCM;
        public string INFERENCE_EQUATION_FCM;
        public Dictionary<string, double> VALUES_NODES;
        public ArrayList VALUES_EDGES;


        public graphFCM(string activationFunct, string activationVector, int numIteration, string inferenceEq, 
            Dictionary<string, double> valuesOfFactorsAfterDefuzzification, ArrayList edges)
        {
            NAME_FCM = "fcm1";
            ID_FCM = "id1";
            ACTIVATION_FUNCTION_FCM = activationFunct;
            NUMBER_OF_ITERATIONS_FCM = numIteration;
            ACTIVATION_VECTOR_FCM = activationVector;
            INFERENCE_EQUATION_FCM = inferenceEq;
            VALUES_NODES = valuesOfFactorsAfterDefuzzification;
            VALUES_EDGES = edges;
        }
    }
}
