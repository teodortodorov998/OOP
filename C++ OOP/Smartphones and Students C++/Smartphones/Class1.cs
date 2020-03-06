using System;
using System.Collections.Generic;
using System.Text;

namespace Smartphones
{
     class smartphone
    {
        private string model;
        private double price;
        private string OS;
        private static int phoneCount = 0;

        smartphone() { model = ""; price = 0; OS = ""; }
        public smartphone(string Model, double Price, string os) {
            model = Model;
            price = Price;
            OS = os;
            
        }

        public smartphone(smartphone p)
        {
            model = p.model;
            price = p.price;
            OS = p.OS;
        }

        public static void Initialize(smartphone[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                Console.Write("Input a model: ");
                string aModel = Console.ReadLine();
                Console.Write("Input a price: ");
                double aPrice = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input an OS: ");
                string aOs = Console.ReadLine();

                p[i] = new smartphone(aModel, aPrice, aOs);

                Console.WriteLine("");
            }
        }

        public double getPrice()
        {
            return price;
        }

        public string getModel()
        {
            return model;
        }

        public string getOS()
        {
            return OS;
        }

        public void printInfo()
        {
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("OS: " + OS);
        }

        public static void sortByPrice(smartphone[] p)
        {
            smartphone temp;
            for (int i = 0; i < p.Length; i++)
            {
                for (int  j = 0;  j < p.Length - 1;  j++)
                {
                    if (p[j].getPrice() > p[j+1].getPrice())
                    {
                        temp = p[j];
                        p[j] = p[j + 1];
                        p[j + 1] = temp;
                    }
                }
            }
        }

    }
}
