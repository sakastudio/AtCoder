using System;
using System.Linq;

namespace AtCoder.AtCoder_Regular_Contest_117
{
    public class B
    {
        
        public static void _Main(string[] args)
        {
            
            long n = long.Parse(Console.ReadLine());
            int[] A = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            
            int max = Int32.MinValue;
            foreach (var a in A)
            {
                if (max <= a)
                {
                    max = a;
                }
            }

            int sum = 1;
            for (int i = 0; i <= max; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}