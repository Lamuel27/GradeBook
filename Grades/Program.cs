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

           
            GradeBook book = new GradeBook();

            book.NameChanged += OnNameChanged;


            book.Name = "Scott's Grade Book";
            book.Name = "Grade Book";
            book.Name = null; //visit this later
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            book.AddGrade(70);
            book.AddGrade(80);
            book.AddGrade(30);
            book.AddGrade(50);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult($"{description}: {result:C}", stats.LowestGrade); //{1:C}{1:F2}
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }

        static void WriteResult(string description, int result)
            {
            Console.WriteLine(description + ": " + result);
            }

        static void WriteResult(string description, float result)
            {
            Console.WriteLine(description + ": " + result);
            }
    }
}
