using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    internal class DisplayResults

    {
        public static void DisplayReport(string name, int id, int incorrect, int correct, int totalScore, int maxScore)
        {
            Console.WriteLine("\n📄 ---- Result Report ----");
            Console.WriteLine($"Student Name: {name}");
            Console.WriteLine($"Student ID: {id}");
            Console.WriteLine($"Correct Answers: {correct}");
            Console.WriteLine($"Incorrect Answers: {incorrect}");
            Console.WriteLine($"Total Score: {totalScore} / {maxScore}");
            Console.WriteLine("-------------------------\n");
        }
    }
}
