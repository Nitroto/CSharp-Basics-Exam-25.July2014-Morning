using System;
using System.Globalization;
using System.Threading;

class BitPaths
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int[,] directions = new int[n, 8];
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            string[] userInput = Console.ReadLine().Split(',');
            for (int j = 0; j < userInput.Length; j++)
            {
                directions[i, j] = int.Parse(userInput[j]);
            }
        }
        int[,] results = new int[n, 8];
        for (int i = 0; i < n; i++)
        {
            int position = 3 - directions[i, 0];
            results[i, 0] |= (1 << position);
        }
        int[] afterStep = new int[8];
        for (int j = 1; j < 8; j++)
        {
            for (int i = 0; i < n; i++)
            {
                int direction = directions[i, j];
                if (direction < 0)
                {
                    results[i, j] = results[i, j - 1] << 1;
                }
                else if (direction > 0)
                {
                    results[i, j] = results[i, j - 1] >> 1;
                }
                else
                {
                    results[i, j] = results[i, j - 1];
                }
            }
        }
        for (int j = 0; j < 8; j++)
        {
            for (int i = 0; i < n; i++)
            {
                afterStep[j] ^= results[i, j];
            }
            sum += afterStep[j];
        }
        Console.WriteLine(Convert.ToString(sum, 2));
        Console.WriteLine("{0:X}", sum);
    }
}
