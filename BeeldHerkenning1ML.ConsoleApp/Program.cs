using System;
using BeeldHerkening1ML.Model;
namespace BeeldHerkening1

    // aangemaakt na Machine Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine(" Object is not valid for this category.");
            // Add input data
            var input = new ModelInput();
            input.ImageSource = "C:\\Users\\pc-5\\Downloads\\Object-recognition-CIFAR-10-master\\rocva ml.NET images\\autos\\auto1.jpg";

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Debug.WriteLine(result.Prediction);
            Console.WriteLine(result.Prediction);
        }
    }
}


