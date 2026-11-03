using System;
using System.Threading;

class Program
{
    static void T0(int[] nums)
    {
        int sum = 0;

        foreach (int num in nums)
        {
            sum += num;
        }

        Console.WriteLine("Sum of the array elements: " + sum);
    }

    static void T1(int[] nums)
    {
        int count = 0;
        
        foreach (int num in nums)
        {
            if (num % 2 != 0)
            {
                count++;
            }
        }

        Console.WriteLine("Count of odd numbers: " + count);
    }

    static void Main(string[] args)
    {
        Random random = new Random();
        int[] nums = new int[8];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = random.Next(0, 15);
        }

        Console.WriteLine("Array elements: " + string.Join(", ", nums));

        Thread thread0 = new Thread(() => T0(nums));
        Thread thread1 = new Thread(() => T1(nums));

        thread0.Start();
        thread1.Start();

        thread0.Join();
        thread1.Join();
    }
}