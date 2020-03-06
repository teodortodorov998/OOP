using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    public class student
    {
        private int facNum;
        private string name;
        private double mark;
        

        public student() { facNum = 0; name = ""; mark = 0; }
        public student(int fNum, string aName, double aMark)
        {
            facNum = fNum;
            name = aName;
            mark = aMark;
        }

        public int getFacNum()
        {
            return facNum;
        }

        public string getName()
        {
            return name;
        }

        public double getMark()
        {
            return mark;
        }

        public void changeInfo()
        {
            int input;
            

            do
            {
                Console.WriteLine("Change FacNum - 1\t Change Name - 2\t Change Mark - 3");
            input = int.Parse(Console.ReadLine());

            
                if (input == 1)
                {
                    facNum = int.Parse(Console.ReadLine());
                }
                if (input == 2)
                {
                    name = Console.ReadLine();
                }
                if (input == 3)
                {
                    mark = double.Parse(Console.ReadLine());
                }
            } while (input != 0);
                 


        }

        public void printInfo()
        {
            Console.WriteLine("FacNum: " + facNum);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Mark: " + mark);
            Console.WriteLine("");
        }

        
    }

    public class group
    {



        private student[] stud = new student[30];
        int size = 3;

        public student[] initialize()
        {
            for (int i = 0; i < size; i++)
            {
                stud[i] = new student();
            }
            return stud;
        }
        public group()
        {
            initialize();
        }
        
        public void setGroup()
        {
            int afNum;
            string nName;
            double mMark;
            for (int i = 0; i < size; i++)
            {
                Console.Write("Input a facNum: ");
                afNum = int.Parse(Console.ReadLine());
                Console.Write("Input a name: ");
                 nName = Console.ReadLine();
                Console.Write("Input a mark: ");
                mMark = Convert.ToDouble(Console.ReadLine());

                stud[i] = new student(afNum, nName, mMark);
                Console.WriteLine();
            }
            

            
             
        }
        
        public double avgMark()
        {
            double avgMark = 0;
            for (int i = 0; i < size; i++)
            {
                avgMark += stud[i].getMark();
            }

            avgMark /= size;
            return avgMark;
        }

        public double getMaxMark()
        {
            double max = double.MinValue;


            for (int i = 0; i < size; i++)
            {
                if (stud[i].getMark() > max)
                {
                    max = stud[i].getMark();

                }
            }

            return max;
        }

        public double getMinMark()
        {
            
            double min = double.MaxValue;


            for (int i = 0; i < size; i++)
            {
                if (stud[i].getMark() < min)
                {
                    min = stud[i].getMark();
                    
                }
            }

            return min;
        }

        public void printByFnum(int fNum)
        {
            int index = 0;
            for (int i = 0; i < size; i++)
            {
                if (stud[i].getFacNum() == fNum)
                {
                    index = i;
                }
            }

            stud[index].printInfo();
        }

        public void sortByFNum()
        {
            student temp;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 1; j++)
                {
                    if (stud[j].getFacNum() > stud[j + 1].getFacNum())
                    {
                        temp = stud[j];
                        stud[j] = stud[j + 1];
                        stud[j + 1] = temp;
                    }
                }
            }
        }

        public void sortByMark()
        {
            student temp;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 1; j++)
                {
                    if (stud[i].getMark() > stud[i + 1].getMark())
                    {
                        temp = stud[i];
                        stud[i] = stud[i + 1];
                        stud[i + 1] = temp;
                    }
                }
            }
        }

        public void printAll()
        {
            for (int i = 0; i < size; i++)
            {
                stud[i].printInfo();
                Console.WriteLine();
            }
        }


    }
}
