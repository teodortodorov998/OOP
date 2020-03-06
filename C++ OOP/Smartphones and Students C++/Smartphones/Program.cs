using System;

namespace Smartphones
{
    class Program
    {
        static void Main(string[] args)
        {
            smartphone[] phone = new smartphone[3];


            smartphone.Initialize(phone);
            

            smartphone.SortByPrice(phone);

            for (int i = 0; i < phone.Length; i++)
            {
                phone[i].PrintInfo();
            }


        }
    }
}
