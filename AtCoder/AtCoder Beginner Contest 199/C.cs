using System;
using System.Linq;
using System.Text;

namespace AtCoder.AtCoder_Beginner_Contest_199
{
    public class C
    {
        public static void _Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            long q = long.Parse(Console.ReadLine());

            int sbNlength = sb.Length - n;
            for (int i = 0; i < q; i++)
            {
                int[] TAB = Console.ReadLine().Split(' ').Select(j => int.Parse(j)).ToArray();

                if (TAB[0] == 1)
                {
                    char w = sb[TAB[1]-1];
                    sb[TAB[1]-1] = sb[TAB[2]-1];
                    sb[TAB[2]-1] = w;
                    continue;
                }
                if (TAB[0] == 2)
                {
                    var tmp = new char[n];
                    sb.CopyTo(n,tmp,0,sbNlength);
                    string afterHalf = sb.ToString().Substring(n);
                    sb.Remove(n,sbNlength);
                    sb.Insert(0, afterHalf);
                    continue;
                }
            }
            
            Console.WriteLine(sb);
        }
    }
}