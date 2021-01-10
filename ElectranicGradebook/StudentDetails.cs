using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectranicGradebook
{
   public class StudentDetails
    {
        public string StudentName { get; set; }
        public int Class { get; set; }
        public SortedList<string,marks> Subjects { get; set; }
       public float Total { get; set; }
        public int Average { get; set; }

    }
    public class marks
    {
        public float Marks { get; set; }
        public string Grade { get; set; }
    }
}
