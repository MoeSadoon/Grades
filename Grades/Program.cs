using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook(); /* the first 'GradeBook' implies class type GradeBook, this object is now garbage because of the new book object below */
            book.AddGrade(91f);
            book.AddGrade(89.5f); /* the 'f' tells the compiler 89.5 is a float otherwise you get an error since it assumes its a double */
            book.AddGrade(75f);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.HighestGrade);
        }
    }
}
