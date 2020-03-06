using System;

namespace RobbersOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            double vault = 1000;
            RobberGang gang = new RobberGang();
            Robber robber1 = new Robber("John Wick", 100, false);
            Robber robber2 = new Robber("Jason Statham", 245, false);
            Robber robber3 = new Robber("Jason Bourne", 145, false);
            Robber robber4 = new Robber("Arthur Bishop", 321, false);
            Robber robber5 = new Robber("Slade Wilson", 234, false);



            gang.AddRobber(robber1);
            

            gang.Robbery(vault);
            gang.GoToJail();
            gang.AddRobber(robber2);
            gang.Robbery(vault);
            gang.GoToJail();
            gang.AddRobber(robber3);
            gang.Robbery(vault);
            gang.GoToJail();
            gang.AddRobber(robber4);
            gang.Robbery(vault);
            gang.GoToJail();
            gang.AddRobber(robber5);
            gang.PrintRobbersInJail();
            Console.WriteLine($"The robbers have stolen a total of: {gang.GetStolenSum()}$");
            Console.WriteLine($"Remaining money in the vault: {gang.MoneyAfterRobberies(vault):F2}$");






        }
    }
}
