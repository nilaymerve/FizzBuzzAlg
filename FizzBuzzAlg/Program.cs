using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FızzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 150; // Burada n'yi istediğiniz değere göre değiştirebilirsiniz
            string result = FizzBuzz(n);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        static string FizzBuzz(int n)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.AppendLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.AppendLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.AppendLine("Buzz");
                }
                else
                {
                    result.AppendLine(i.ToString());
                }
            }

            return result.ToString();
        }
    }
}