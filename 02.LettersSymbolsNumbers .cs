using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        long sumOfLetters = 0;
        long sumOfNumbers = 0;
        long sumOfSymbols = 0;
        for (int i = 0; i < n; i++)
        {
            string inputString = Console.ReadLine().ToUpper();
            inputString = Regex.Replace(inputString, "\\s+", "");
            foreach (char character in inputString)
            {
                if (character >= 'A' && character <= 'Z')
                {
                    sumOfLetters += 10 * (character - 'A' + 1);
                }
                else if (character >= '0' && character <= '9')
                {
                    sumOfNumbers += 20 * (character - '0');
                }
                else
                {
                    sumOfSymbols += 200;
                }
            }
        }
        Console.WriteLine(sumOfLetters);
        Console.WriteLine(sumOfNumbers);
        Console.WriteLine(sumOfSymbols);
    }
}
