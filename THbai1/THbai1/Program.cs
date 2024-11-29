using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THbai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Doan So Trung Thuong ==");

            Random rand = new Random();
            int targetNum = rand.Next(100, 999);
            string targetString = targetNum.ToString();

            int attempt = 1, max_guess = 10;
            string guess, feedback = "";

            while (feedback != "+++" && attempt <= max_guess)
            {
                Console.WriteLine($"Lan doan thu {attempt}");
                guess = Console.ReadLine();
                feedback = GetFeedback(targetString, guess);
                Console.WriteLine($"Phan hoi tu may tinh: {feedback}");
                attempt++;
            }
            Console.WriteLine($"Nguoi choi da doan {attempt - 1} lan. Tro choi ket thuc!");
            if (attempt > max_guess)
            {
                Console.WriteLine($"Game Over. Result: {targetNum}");
            }
            else
            {
                Console.WriteLine("Victory!");
            }
            Console.ReadLine();
        }

        private static string GetFeedback(string targetString, string guess)
        {
            string feedback = "";
            for (int i = 0; i < targetString.Length; i++)
            {
                if (targetString[i] == guess[i])
                    feedback += "+";
                else if (targetString.Contains(guess[i].ToString()))
                    feedback += "?";
            }
            return feedback;
        }
    }
}
