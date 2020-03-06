using System;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {

            group gr = new group();

            
            gr.SetGroup();
            gr.AvgMark();
            gr.GetMaxMark();
            gr.SortByFNum();
            gr.PrintAll();

        }
    }
}
