using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeStatistics
    {

        public GradeStatistics()
        {
            HighestGrade = 0; //we only need to specifiy variable name here
            LowestGrade = float.MaxValue; // You cant lowest grade to be really high value, so when the lowest grade comes in it came override that, hence we use max value which is a static member
        }
        // Remember these are class fields:

        public float AverageGrade; // These are made public because they need to be accessed
        public float HighestGrade;
        public float LowestGrade;
    }
}
