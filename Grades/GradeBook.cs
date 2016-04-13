using System;
using System.Collections.Generic;


namespace Grades
{
    class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade) /* Method doesn't return anything hence it is a void method*/
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
        }

        public GradeStatistics ComputeStatistics() /* if a method returns a type, you have to prefix it with the type, eg in this case it is type 'GradeStatistics', otherwise it is void */
        {
            GradeStatistics stats = new GradeStatistics();
            stats.HighestGrade = 0; 
            float sum = 0f;

            foreach(float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade); // Math class's max static method gives you the larger value of the two provided arguments, which is reassigned to lowest value
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade); // As with above but with lowest
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;
            return stats; 
        }

        private List<float> grades = new List<float>(); /* field, which is essentially a variable within a class..i.e a PROPERTY*/
        // The reason why this class is private is because you don't want people to play around with grades here, if they want they can use a public method like AddGrade which deals with this

    }
}
