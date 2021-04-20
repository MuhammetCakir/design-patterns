using System;
using System.Text;

namespace BuilderPatterString
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder("BAHCESEHIR UNIVERSITY");

            builder.Replace("BAHCESEHIR", "BAU"); // BAU UNIVERSITY

            builder.Append("AI"); // BAU UNIVERSITYAI

            builder.Remove(4, 12); // BAU

            String result = builder.ToString();

            System.Console.WriteLine(result);
        }
    }
}
