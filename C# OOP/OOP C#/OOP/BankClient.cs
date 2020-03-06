using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public struct account
    {
        public string bankAccType;
        public string IBAN;
        public double sum;

        
        public account(string Type, string iBAN, double Sum)
        {
            bankAccType = Type;
            IBAN = iBAN;
            sum = Sum;
        } 
    }
    class BankClient
    {
        
        private string fname;
        private string lname;
        private int numOfBankAccs;
        private int clientNum;
        private account[] bankAccountInfo = new account[10];
        
        public BankClient() { fname = ""; lname = ""; numOfBankAccs = 0; clientNum = 0; }
        public BankClient(string fName, string lName, int clNum, account info) {
            fname = fName;
            lname = lName;
            numOfBankAccs = 0;
            clientNum = clNum;

            bankAccountInfo[numOfBankAccs].bankAccType = info.bankAccType;
            bankAccountInfo[numOfBankAccs].IBAN = info.IBAN;
            bankAccountInfo[numOfBankAccs].sum = info.sum;
            numOfBankAccs++;
        }
        public BankClient(BankClient p) {
            fname = p.fname;
            lname = p.lname;
            clientNum = p.clientNum;
            numOfBankAccs = p.numOfBankAccs;

            for (int i = 0; i < numOfBankAccs; i++)
            {
                bankAccountInfo[i].bankAccType = p.bankAccountInfo[i].bankAccType;
                bankAccountInfo[i].IBAN = p.bankAccountInfo[i].IBAN;
                bankAccountInfo[i].sum = p.bankAccountInfo[i].sum;
            }
        }

        public int newBankAcount(account info)
        {
            bankAccountInfo[numOfBankAccs].bankAccType = info.bankAccType;
            bankAccountInfo[numOfBankAccs].IBAN = info.IBAN;
            bankAccountInfo[numOfBankAccs].sum = info.sum;
            numOfBankAccs++;
            return 1;
        }

        public int getNumOfBankAccs()
        {
            return numOfBankAccs;
        }

         public account searchByIBAN(string  iBAN)
        {
            int index = 0;
            
            for (int i = 0; i < numOfBankAccs; i++)
            {
                if (bankAccountInfo[i].IBAN == iBAN)
                {
                    index = i;
                    
                }
            }
            return bankAccountInfo[index];
        }

        public int deleteBankAccount(string iBAN)
        {
            account p = searchByIBAN(iBAN);
            
            for (int i = 0; i < numOfBankAccs; i++)
            {
                if (bankAccountInfo[i].IBAN == p.IBAN)
                {
                    if (p.sum < 0)
                    {
                        return 0;
                    }
                    while (i <= numOfBankAccs - 1)
                    {
                        bankAccountInfo[i++] = bankAccountInfo[i + 1];
                        numOfBankAccs--;
                    }
                    
                }
                
            }
            return 1;
        }

        public int addSumToAcc(string iBAN, double Sum)
        {
            account p = searchByIBAN(iBAN);
            p.sum += Sum;
            return 1;
        }

        public double allMoney()
        {
            double allSum = 0;
            for (int i = 0; i < numOfBankAccs; i++)
            {
                allSum += bankAccountInfo[i].sum;
            }
            return allSum;
        }

        public int printAll()
        {
            Console.Write("Name\t" + fname + "\n" + "Fam\t" + lname + "\n");
            Console.Write("Number of accounts " + numOfBankAccs + "\n");
            for (int i = 0; i < numOfBankAccs; i++)
            {
                Console.WriteLine("Account " + i + "\n");
                Console.WriteLine("\tType: " + bankAccountInfo[i].bankAccType + "\n");
                Console.WriteLine("\tIBAN: " + bankAccountInfo[i].IBAN + "\n");
                Console.WriteLine("\tSum: " + bankAccountInfo[i].sum + "\n");
            }
            Console.WriteLine("");
            return 1;
        }

        public int getClientNum()
        {
            return clientNum;
        }
        
    }

    

}
