using System;
using System.Linq;

namespace AtCoder.AtCoder_Beginner_Contest_199
{
    public class B
    {
        
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int[] A = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            int[] B = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            int Amax = Int32.MinValue;
            int Bmin = Int32.MaxValue;
            for (int i = 0; i < A.Length; i++)
            {
                if (Amax < A[i])
                {
                    Amax = A[i];
                }
                if (B[i] < Bmin)
                {
                    Bmin = B[i];
                }
            }

            int cnt = Bmin -Amax + 1;
            if (cnt < 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(cnt);
            }
        }
    }
}