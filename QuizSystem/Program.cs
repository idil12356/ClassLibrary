
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Random Qulxin = new Random();
            string stdName;
            int stdId, choice, a, b, c = 0, answer, numQuestions = 10;
            int correctCount = 0, incorrectCount = 0, markPerQuestion = 10;

            Console.WriteLine("Enter your Name:");
            stdName = Console.ReadLine();

            Console.WriteLine("Enter your ID:");
            stdId = Convert.ToInt32(Console.ReadLine());

            do
            {
                correctCount = 0;
                incorrectCount = 0;

                MyMethods.DisplayMenu();

                Console.Write("Choose the math operation (1-5): ");
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid Input. Enter from 1 to 5:");
                }

                if (choice == 5)
                {
                    Console.WriteLine("Exiting the program. Good bye");
                    break;
                }

                Console.WriteLine($"\nYou will answer {numQuestions} questions.\n");

                for (int i = 1; i <= numQuestions; i++)
                {
                    a = Qulxin.Next(1, 51);
                    b = Qulxin.Next(1, 51);

                    Console.Write($"Question {i}: \t");

                    switch (choice)
                    {
                        case 1:
                            c = MyMethods.Add(a, b);
                            Console.Write($"{a} + {b} = ? ");
                            break;

                        case 2:
                            c = MyMethods.Subtract(a, b);
                            Console.Write($"{a} - {b} = ? ");
                            break;

                        case 3:
                            c = MyMethods.Multiply(a, b);
                            Console.Write($"{a} x {b} = ? ");
                            break;

                        case 4:
                            c = MyMethods.Divide(a, b);
                            Console.Write($"{a} ÷ {b} = ? ");
                            break;

                        default:
                            Console.WriteLine("Invalid Operation");
                            continue;
                    }

                    while (!int.TryParse(Console.ReadLine(), out answer))
                    {
                        Console.WriteLine("Invalid input. Enter a number:");
                    }

                    if (answer == c)
                    {
                        Console.WriteLine("Correct\n");
                        correctCount++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect! Correct answer is {c}\n");
                        incorrectCount++;
                    }
                }

                int totalScore = correctCount * markPerQuestion;
                int maxScore = numQuestions * markPerQuestion;

                DisplayResult.DisplayReport(
                    stdName, stdId, incorrectCount,
                    correctCount, totalScore, maxScore
                );

            } while (choice != 5);

        }
    }
}
