using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            School[] allSchools = new School[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter school name");
                string schoolname = Console.ReadLine();

                Console.WriteLine("Enter enrollment");
                int numstudents = int.Parse(Console.ReadLine());

                //create a new school obj
                School s1 = new School();
                s1.SchoolName = schoolname;
                s1.Enrollment = numstudents;

                allSchools[i] = s1;

            }

            Array.Sort(allSchools);
            allSchools.Reverse();


            for (int i = 0; i < allSchools.Length; i++)
            {
                Console.WriteLine($"{allSchools[i].SchoolName} - {allSchools[i].Enrollment}");
            }
            

            

           
            

        }

        //static void Display(params School[] schools)
        //{
        //    Console.WriteLine("{0, -24}{1, -12}", "School name", "Enrollment" );
        //    foreach (School school in schools)
        //    {
        //        Console.WriteLine("{0, -24}{1, -12}{2, -10}", school.SchoolName, school.enrollment);
        //    }
        //}
    }
}
