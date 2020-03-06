using System;
using System.Collections.Generic;

namespace OOP
{
    class Bank
    {
        private BankClient[] Table;
        private int Size;
        private int tableEnd;

        public Bank() { Size = 2; tableEnd = 0; }

        public Bank(int size)
        {
            Size = size;
            tableEnd = 0;
            Table = new BankClient[Size];
        }

        public void Resize()
        {
            Size *= 2;
            BankClient[] newTable = new BankClient[Size];

            for (int i = 0; i < tableEnd; i++)
            {
                newTable[i] = Table[i];
            }

            

            Table = newTable;
        }
        
        public int newClient(BankClient p)
        {
            if (tableEnd == Size)
            {
                Resize();
            }
            Table[tableEnd++] = p;
            return 1;
        }

        public int removeClient(int clNum)
        {
            for (int i = 0; i < tableEnd; i++)
            {
                if (Table[i].getClientNum() == clNum)
                {
                    while (i < tableEnd - 1)
                    {
                        Table[i] = Table[i + 1];
                        i++;
                    }
                    tableEnd--;
                    return 1;
                }
                
            }
            return 0;
        }

        public int printClients()
        {
            for (int i = 0; i < tableEnd; i++)
            {
                Table[i].printAll();
            }
            return 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();

            account[] info = new account[5];

            info[0] = new account("Debit", "LAKS2367", 867);
            info[1] = new account("Credit", "NIFW9873", 583);
            info[2] = new account("Credit", "LSKO5364", 1254);
            info[3] = new account("Credit", "MPIE9872", 234);
            info[4] = new account("Debit", "IBWM9874", 945);

            BankClient[] p = new BankClient[3];

            p[0] = new BankClient("John", "Wick", 666, info[0]);
            p[1] = new BankClient("Arthur", "Bishop", 111, info[1]);
            p[2] = new BankClient("Denzel", "Washington", 981, info[2]);

            p[0].newBankAcount(info[3]);
            p[1].newBankAcount(info[3]);

            b.printClients();

            




        }
    }
}
