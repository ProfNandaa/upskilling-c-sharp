using System;

class Solution
{
    // for testing
    static void Main(string[] args)
    {
        int[] a = {10, 5, 2, 4, 6};
        Console.WriteLine(SumEven(a));
    }
    
    static int SumEven(int[] a)
    {
        int sum = 0;
        for (var i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }
        return sum;
    }
}