using System;
using System.Linq;

namespace AtCoder.AtCoder_Regular_Contest_117
{
    /*
// 文字列の入力
string s = Console.ReadLine();

// 整数の入力
long n = long.Parse(Console.ReadLine());

// 少数の入力
double n = double.Parse(Console.ReadLine());

// 文字列配列の入力
string[] inputStrArray = Console.ReadLine().Split(' ');

// 整数配列の入力
long[] inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
     */
    public class A
    {
        public static void Main(string[] args)
        {
            long[] inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            int[] god = new int[inputLongArray[0]+inputLongArray[1]];
            god[0] = 1000000;
            
            for (int i = 1; i < inputLongArray[0]; i++)
            {
                god[i] = i;
            }
            
            for (int i = (int)inputLongArray[0]; i < god.Length; i++)
            {
                god[i] = -i;
            }

            int sum = 0;
            foreach (var g in god)
            {
                sum += g;
            }

            god[god.Length - 1] = -sum + god[god.Length - 1];
            sum = 0;
            foreach (var g in god)
            {
                Console.Write(g+" ");
                sum += g;
            }
        }
    }
}