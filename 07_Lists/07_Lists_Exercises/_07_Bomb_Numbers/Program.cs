using System;
using System.Linq;
using System.Collections;


class BombNumbers
{
    static void Main()
    {
        var listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        var detonationData = Console.ReadLine().Split().Select(int.Parse).ToList();
        int bombNumber = detonationData[0];
        int blastPower = detonationData[1];

        while (listOfNumbers.Contains(bombNumber))
        {
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i] == bombNumber)
                {
                    int bombIndex = i;

                    int front = bombIndex - blastPower;

                    if (front < 0)
                        front = 0;

                    int back = bombIndex + blastPower;

                    if (back >= listOfNumbers.Count)
                        back = listOfNumbers.Count - 1;

                    for (int j = front; j <= back; j++)
                        listOfNumbers.RemoveAt(front);
                }
            }
        }

        var sum = 0;

        foreach (var numbers in listOfNumbers)
            sum += numbers;

        Console.WriteLine(sum);
 
    }
}