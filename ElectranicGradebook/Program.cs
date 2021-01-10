using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectranicGradebook
{
    class Program
    {
        
        static void Main(string[] args)
        {

            StudentDetails StudentDetailslist1 = SubjectsInput();
            Console.WriteLine(StudentDetailslist1.StudentName);
            Console.WriteLine(StudentDetailslist1.Class);
           
            foreach (var s in StudentDetailslist1.Subjects)
            {
                Console.WriteLine(s.Key);
                Console.WriteLine(s.Value.Marks);
                Console.WriteLine(s.Value.Grade);
              
                
            }
            Console.WriteLine(Convert.ToString( StudentDetailslist1.Total)+"/"+"500");
            Console.WriteLine(StudentDetailslist1.Average);
            Console.ReadLine();
        }
        public static int Intinput(string Number)
        {
            bool Num= false;
            int intvalue=0;
            while (Num==false)
            { 
                Num = int.TryParse(Number, out intvalue);
            
                if (Num)
                {
                    Num = true;
                }
                else
                {
                    Console.WriteLine("Enter Correct Format Input");
                    Number=Console.ReadLine();
                }
            }
            return intvalue;

        }
        public static float Floatinput(string Number)
        {
            bool FNum = false;
            float floatvalue = 0;
            while (FNum == false)
            {
                FNum = float.TryParse(Number, out floatvalue);

                if (FNum)
                {
                    FNum = true;
                }
                else
                {
                    Console.WriteLine("Enter Correct Format Input");
                    Number = Console.ReadLine();
                }
            }
            return floatvalue;

        }
        public static string NameInput(string Name)
        {
           
            while (string.IsNullOrEmpty(Name))
                {
                    Console.WriteLine("Name can't be empty");
                Name = Console.ReadLine();
                }

            return Name;
            
        }
        public static StudentDetails SubjectsInput()
        {
            StudentDetails StudentDetailslist = new StudentDetails();

            SortedList<string, marks> empty = new SortedList<string, marks>();
            Console.WriteLine("Enter The Name :");
            StudentDetailslist.StudentName = NameInput(Console.ReadLine());
            Console.WriteLine($"Enter the Class : { StudentDetailslist.StudentName}");
            StudentDetailslist.Class= Intinput(Console.ReadLine());
            Console.WriteLine($"Enter the Nuumberofsubjects : { StudentDetailslist.StudentName}");
           int Numberofsub = Intinput(Console.ReadLine());

            for (int i= 1; i <= Numberofsub; i++)
            {
                marks markslist = new marks();
                Console.WriteLine("Enter The Subjects : ");
                string Subject = NameInput(Console.ReadLine());
                Console.WriteLine($"Enter the Mark : {Subject}");
                float Mark = Floatinput(Console.ReadLine());
                markslist.Marks = Mark;
                markslist.Grade = Mark >= 90 ? "S-Distination" : Mark>=80 ? "A-Firstclass" :Mark>70 ? "B-Firstclass" :Mark>=50 ? "D-SecondClass" :Mark <50 ? "F-Fail" :"";
                
                empty.Add(Subject, markslist);
              
              
                    StudentDetailslist.Total += Mark;
                StudentDetailslist.Average = Convert.ToInt32(StudentDetailslist.Total )/ Numberofsub;
            }


         

            return StudentDetailslist;
        }
       
    }
}
