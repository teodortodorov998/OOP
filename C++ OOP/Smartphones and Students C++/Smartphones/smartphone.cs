using System;
using System.Collections.Generic;
using System.Text;

namespace Smartphones
{
     class smartphone
    {
        private string model;
        private double price;
        private string os;
        private static int phoneCount = 0;

        smartphone() { model = ""; price = 0; os = ""; }
        public smartphone(string Model, double Price, string Os) {
            model = Model;
            price = Price;
            os = Os;
            
        }

        public smartphone(smartphone p)
        {
            model = p.model;
            price = p.price;
            os = p.os;
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

        public double GetPrice()
        {
            return price;
        }

        public string GetModel()
        {
            return model;
        }

        public string GetOS()
        {
            return os;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("OS: " + os);
            Console.WriteLine();
        }

        public static void SortByPrice(smartphone[] p)
        {
            smartphone temp;
            for (int i = 0; i < p.Length; i++)
            {
                for (int  j = 0;  j < p.Length - 1;  j++)
                {
                    if (p[j].GetPrice() > p[j+1].GetPrice())
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
