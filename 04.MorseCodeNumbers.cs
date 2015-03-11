using System;
using System.Globalization;
using System.Linq;
using System.Threading;
class MorseCodeNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int sum = n.ToString().Sum(c => c - '0');
        bool answer = false;
        for (int a = 0; a < 6; a++)
        {
            for (int b = 0; b < 6; b++)
            {
                for (int c = 0; c < 6; c++)
                {
                    for (int d = 0; d < 6; d++)
                    {
                        for (int e = 0; e < 6; e++)
                        {
                            for (int f = 0; f < 6; f++)
                            {
                                if (a * b * c * d * e * f == sum)
                                {
                                    Console.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|", morseCode(a), morseCode(b), morseCode(c), morseCode(d), morseCode(e), morseCode(f));
                                    answer = true;
                                }
                            }
                        }
                    }
                }
            }
        }
        if (!answer)
        {
            Console.WriteLine("No");
        }
    }
    private static string morseCode(int num)
    {
        string morseProduct = "";
        switch (num)
        {
            case 0: morseProduct = ("-----"); break;
            case 1: morseProduct = (".----"); break;
            case 2: morseProduct = ("..---"); break;
            case 3: morseProduct = ("...--"); break;
            case 4: morseProduct = ("....-"); break;
            case 5: morseProduct = ("....."); break;
        }
        return morseProduct;
    }
}
