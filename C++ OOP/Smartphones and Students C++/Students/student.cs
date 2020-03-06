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

        public int GetFacNum()
        {
            return facNum;
        }

        public string GetName()
        {
            return name;
        }

        public double GetMark()
        {
            return mark;
        }

        public void ChangeInfo()
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

        public void PrintInfo()
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

        public student[] Initialize()
        {
            for (int i = 0; i < size; i++)
            {
                stud[i] = new student();
            }
            return stud;
        }
        public group()
        {
            Initialize();
        }
        
        public void SetGroup()
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
        
        public double AvgMark()
        {
            double avgMark = 0;
            for (int i = 0; i < size; i++)
            {
                avgMark += stud[i].GetMark();
            }

            avgMark /= size;
            return avgMark;
        }

        public double GetMaxMark()
        {
            double max = double.MinValue;


            for (int i = 0; i < size; i++)
            {
                if (stud[i].GetMark() > max)
                {
                    max = stud[i].GetMark();

                }
            }

            return max;
        }

        public double GetMinMark()
        {
            
            double min = double.MaxValue;


            for (int i = 0; i < size; i++)
            {
                if (stud[i].GetMark() < min)
                {
                    min = stud[i].GetMark();
                    
                }
            }

            return min;
        }

        public void PrintByFnum(int fNum)
        {
            int index = 0;
            for (int i = 0; i < size; i++)
            {
                if (stud[i].GetFacNum() == fNum)
                {
                    index = i;
                }
            }

            stud[index].PrintInfo();
        }

        public void SortByFNum()
        {
            student temp;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 1; j++)
                {
                    if (stud[j].GetFacNum() > stud[j + 1].GetFacNum())
                    {
                        temp = stud[j];
                        stud[j] = stud[j + 1];
                        stud[j + 1] = temp;
                    }
                }
            }
        }

        public void SortByMark()
        {
            student temp;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 1; j++)
                {
                    if (stud[i].GetMark() > stud[i + 1].GetMark())
                    {
                        temp = stud[i];
                        stud[i] = stud[i + 1];
                        stud[i + 1] = temp;
                    }
                }
            }
        }

        public void PrintAll()
        {
            for (int i = 0; i < size; i++)
            {
                stud[i].PrintInfo();
                Console.WriteLine();
            }
        }


    }
}
