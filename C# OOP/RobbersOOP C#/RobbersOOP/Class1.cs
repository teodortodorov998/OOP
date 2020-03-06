using System;
using System.Collections.Generic;
using System.Text;



namespace RobbersOOP
{
    public struct Robber
    {
        public string name;
        public double rating;
        public bool isInJail;

        public Robber(string aName, double aRating, bool isInJail) {
            this.name = aName;
            this.rating = aRating;
            this.isInJail = isInJail;
        }
    }
    class RobberGang
    {
        private Robber[] gang = new Robber[10];
        private Robber[] jail = new Robber[10];

        private static double stealableSum = 0;
        private static int numberOfRobbers = 0;
        private static int numberOfPrisoners = 0;
        private static double stolenSum = 0;
        
        
        

        public RobberGang() {
            
            

        }

        public double SetStealableSum()
        {
            double sumOfRatings = 0;
            
            for (int i = 0; i < numberOfRobbers; i++)
            {
                sumOfRatings += gang[i].rating;
            }
            stealableSum = sumOfRatings * 0.8;
            return stealableSum;
        }

        public void AddRobber(Robber robber)
        {
            this.gang[numberOfRobbers].name = robber.name;
            this.gang[numberOfRobbers].rating = robber.rating;
            this.gang[numberOfRobbers].isInJail = robber.isInJail;
            numberOfRobbers++;
        }

        public void GoToJail()
        {
            double max = double.MinValue;
            int indexKeeper = 0;
            for (int i = 0; i < numberOfRobbers; i++)
            {
                if (gang[i].rating > max)
                {
                    max = gang[i].rating;
                    indexKeeper = i;

                }
                
            }
            gang[indexKeeper].isInJail = true;
            jail[numberOfPrisoners] = gang[indexKeeper];
            
            numberOfPrisoners++;

            for (int i = indexKeeper; i <= numberOfRobbers - 1; i++)
            {
                gang[i++] = gang[i + 1];
                numberOfRobbers--;
            }

            

        }

        public void Robbery(double Safe)
        {
            
            double stolenMoney = 0;

            SetStealableSum();

            Console.WriteLine("A robbery is going down...");

            stolenMoney = stealableSum;
                stolenSum += stolenMoney;
        }

        public void PrintRobbersInJail()
        {
            for (int i = 0; i < numberOfPrisoners; i++)
            {
                Console.WriteLine(jail[i].name);
                
                Console.WriteLine("");
            }
        }

        public double MoneyAfterRobberies(double Safe)
        {
            Safe -= stolenSum;
            return Safe;
        }

        public double GetStolenSum()
        {
            return stolenSum;
        }
        

    }
}
