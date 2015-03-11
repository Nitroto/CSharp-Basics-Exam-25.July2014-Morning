using System;
using System.Globalization;
using System.Threading;
class MelonsAndWatermelons
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        byte dayOfWeek = byte.Parse(Console.ReadLine());
        int numberOfDays = int.Parse(Console.ReadLine());
        int sumOfMelons = 0;
        int sumOfWater = 0;
        for (int i = 1; i <= numberOfDays; i++)
        {
            if (dayOfWeek > 7)
            {
                dayOfWeek = 1;
            }
            switch (dayOfWeek)
            {
                case 1: sumOfMelons += 0; sumOfWater += 1; break;
                case 2: sumOfMelons += 2; sumOfWater += 0; break;
                case 3: sumOfMelons += 1; sumOfWater += 1; break;
                case 4: sumOfMelons += 0; sumOfWater += 2; break;
                case 5: sumOfMelons += 2; sumOfWater += 2; break;
                case 6: sumOfMelons += 2; sumOfWater += 1; break;
                case 7: sumOfMelons += 0; sumOfWater += 0; break;
            }
            dayOfWeek++;
        }
        if (sumOfWater == sumOfMelons)
        {
            Console.WriteLine("Equal amount: {0}", sumOfMelons);
        }
        else if (sumOfMelons < sumOfWater)
        {
            Console.WriteLine("{0} more watermelons", Math.Abs(sumOfWater - sumOfMelons));
        }
        else if (sumOfMelons > sumOfWater)
        {
            Console.WriteLine("{0} more melons", Math.Abs(sumOfWater - sumOfMelons));
        }
    }
}
