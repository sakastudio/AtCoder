using System;
using System.Linq;

namespace AtCoder.AtCoder_Beginner_Contest_199
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
        public static void _Main(string[] args)
        {
            int[] ABC = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            if (Math.Pow(ABC[0], 2) +Math.Pow(ABC[1], 2) < Math.Pow(ABC[2], 2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}