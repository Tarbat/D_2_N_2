using System;
using System.Xml.Linq;

class HelloWorld
{
    static void Main()
    {
        int inter1, inter2;

        int[] num = new int[2] {0, 1};
        Console.WriteLine("N - Array Size = ");
        int N = Convert.ToInt32(Console.ReadLine());
        Array.Resize(ref num, N);
        int Len = num.Length;
        Console.WriteLine("Len - Quantity: " + Len);

        for (int i = 0; i != Len; i++)
        {
            num[i] = i;
            Console.Write(num[i].ToString() + " ");
        }

        for (int i = 0; i != Len/2; i++)
        {
            inter1 = num[i];
            inter2 = num[i+Len/2];
            num[i] = inter2;
            num[i + Len / 2] = inter1;
        }

        Console.WriteLine(" ");
        Console.WriteLine("Result of redistribution: ");

        for (int i = 0; i != Len; i++)
        {
            Console.Write(num[i].ToString() + " ");
        }
    }
}