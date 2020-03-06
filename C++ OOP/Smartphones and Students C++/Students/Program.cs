using System;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {

            group gr = new group();

            
            gr.setGroup();
            gr.avgMark();
            gr.getMaxMark();
            gr.sortByFNum();
            gr.printAll();

        }
    }
}
