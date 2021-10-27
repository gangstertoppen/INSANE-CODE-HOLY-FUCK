using System;

public class Program
{
    public static void Main()
    {
        int temp;
        int count = 0;
        int[] num = { 89, 76, 45, 92, 67, 12, 99 };
        for (int i = 1; i < (num.Length - 1); i++)
        {
            for (int j = 0; j < (num.Length - 1); j++)
            {
                count++; //teller antall runder.
                if (num[j + 1] < num[j])
                {
                    //Counter 
                    temp = num[j + 1];
                    num[j + 1] = num[j];
                    num[j] = temp;
                }
            }
        }

        Console.WriteLine("Rounds: " + count + "and" + num.LongLength);
        Console.WriteLine(String.Join(", ", num));
    }
}