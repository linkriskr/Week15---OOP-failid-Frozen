using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {

        class SecretSanta
        {
            string name;
            string gift;

            public SecretSanta(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
            }

            //getters for SecretSanta

            public string Name
            {
                get { return name; }
            }

            public string Gift
            {
                get { return gift; }
            }

        }
        static void Main(string[] args)
        {
            List<SecretSanta> mySecretSanta = new List<SecretSanta>();
            string[] secretsantaFromFile = GetDataFromFile();

            foreach (string line in secretsantaFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                SecretSanta newSecretSanta = new SecretSanta(tempArray[0], tempArray[1]);
                mySecretSanta.Add(newSecretSanta);
            }

            foreach (SecretSanta secretsantaFromList in mySecretSanta)
            {
                Console.WriteLine($"{secretsantaFromList.Name} wants {secretsantaFromList.Gift} for christmas.");
            }
        }

        public static void DisplayElementFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\...\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}