using System;
using System.Globalization;
using System.Threading;
class PandaScotlandFlag
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int midPoint = n / 2;
        int spacesBefore = 0;
        int filling = n - 2;
        int border = 0;
        for (int i=0;i<n;i++)
        {
            if (i < midPoint)
            {
                Console.Write(new string('~', spacesBefore));
                Console.Write((char)('A' + border));
                border = BoarderIncreaser(border);
                Console.Write(new string('#', filling));
                Console.Write((char)('A' + border));
                border = BoarderIncreaser(border);
                Console.Write(new string('~', spacesBefore));
                spacesBefore++;
                filling -= 2;
                Console.WriteLine();
            }
            else if (i == midPoint)
            {
                Console.Write(new string('-', n / 2));
                Console.Write((char)('A' + border));
                border = BoarderIncreaser(border);
                Console.Write(new string('-', n / 2));
                Console.WriteLine();
                filling += 2;
                spacesBefore--;
            }
            else
            {
                Console.Write(new string('~', spacesBefore));
                Console.Write((char)('A' + border));
                border = BoarderIncreaser(border);
                Console.Write(new string('#', filling));
                Console.Write((char)('A' + border));
                border = BoarderIncreaser(border);
                Console.Write(new string('~', spacesBefore));
                spacesBefore--;
                filling += 2;
                Console.WriteLine();
            }
        }
    }

    private static int BoarderIncreaser(int border)
    {
        if (border < 25)
        {
            border++;
        }
        else
        {
            border -= 25;
        }

        return border;
    }
}
