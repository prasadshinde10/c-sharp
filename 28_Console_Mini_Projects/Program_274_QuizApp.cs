// ============================================
// Program #274 — QuizApp
// Category  : 28_Console_Mini_Projects
// Difficulty: [Intermediate]
// Description: 10-question C# quiz with score and grade.
// ============================================

using System;

namespace CSharp30Programs.ConsoleMiniProjects
{
    class Program_274_QuizApp
    {
        static void Main(string[] args)
        {
            string[] questions =
            {
                "C# is developed by?
A) Microsoft B) Google C) Apple D) IBM",
                "Keyword for inheritance?
A) inherit B) extends C) : D) baseclass",
                "Entry method in C# console app?
A) Start B) Main C) Run D) Init",
                "Collection for key-value pairs?
A) List B) Array C) Dictionary D) Queue",
                "Type that allows null for value types?
A) dynamic B) object C) nullable D) var",
                "Exception handling keyword?
A) try B) lock C) using D) async",
                "String interpolation symbol?
A) # B) @ C) $ D) %",
                "LINQ stands for?
A) Language Integrated Query B) Linked Query C) Logical IN Query D) None",
                "Access modifier for all classes?
A) local B) private C) public D) internalonly",
                "Method to write line to console?
A) Console.Print B) Console.WriteLine C) Console.Echo D) Console.Line"
            };
            char[] answers = { 'A', 'C', 'B', 'C', 'C', 'A', 'C', 'A', 'C', 'B' };
            int score = 0;
            Console.WriteLine("C# Quiz (10 questions)");
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"
Q{i + 1}: {questions[i]}");
                Console.Write("Answer (A/B/C/D): ");
                char input = char.ToUpper(((Console.ReadLine() ?? " ").Trim() + " ")[0]);
                if (input == answers[i])
                {
                    score++;
                    Console.WriteLine("Correct!");
                }
                else Console.WriteLine($"Wrong. Correct: {answers[i]}");
            }
            double percent = score * 10;
            string grade = percent >= 90 ? "A" : percent >= 75 ? "B" : percent >= 60 ? "C" : percent >= 40 ? "D" : "F";
            Console.WriteLine($"
Score: {score}/10 ({percent}%). Grade: {grade}");
        }
    }
}
