using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataPath = @"Data\students.txt";

            string[] students;


            students = new string[3];
            students[0] = "sue, McWater, 34";
            students[1] = "Bill, Tompson, 23";
            students[2] = "Charlie, Velis, 22";

            WriteAllStudents(dataPath, students);

            students = ReadAllStudents(dataPath);

            DisplayAllStudents(students);

            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }

        static string[] ReadAllStudents(string dataPath)
        {
            string[] students;

            students = File.ReadAllLines(dataPath);

            return students;
        }

        static void WriteAllStudents(string dataPath, string[] students)
        {
            File.WriteAllLines(dataPath, students);
        }

        static void DisplayAllStudents(string[] students)
        {
            Console.WriteLine();
            Console.WriteLine("All Students");
            Console.WriteLine();

            //
            // table headers
            //

            Console.WriteLine(
                "First Name".PadRight(15) +
                "Last Name".PadRight(15) +
                "Age".PadRight(15)
                   );

            Console.WriteLine(
                "--------".PadRight(15) +
                "--------".PadRight(15) +
                "--------".PadRight(15)
                   );

            //
            // table of students
            //

            foreach (string student in students)
            {
                string[] studentInfo = student.Split(',');

                Console.WriteLine(
                    studentInfo[0].PadRight(15) +
                    studentInfo[1].PadRight(15) +
                    studentInfo[2].PadRight(15) 
                    );

            }

            Console.WriteLine();
            Console.WriteLine("press any key to continue");
            Console.WriteLine();




        }
    }
}
