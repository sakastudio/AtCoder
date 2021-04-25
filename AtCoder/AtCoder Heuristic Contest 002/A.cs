using System;
using System.Collections.Generic;
using System.Linq;

namespace AtCoder.AtCoder_Heuristic_Contest_002
{
    public class A
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
    int[] inputLongArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
    
    // 整数配列の入力
    long[] inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
         */            
        static int[][] t = new int[50][];
        static int[][] p = new int[50][];
        static Stack<int> direction = new Stack<int>();
        static Dictionary<int, bool> alreadyT = new Dictionary<int, bool>();
        public static void Main(string[] args)
        {
            for (int i = 0; i < 3000; i++)
            {
                alreadyT[i] = false;
            }
            
            int[] sPos = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();


            for (int i = 0; i < 50; i++)
            {
                t[i] = new int[50];
                t[i] = Console.ReadLine().Split(' ').Select(j => int.Parse(j)).ToArray();
            }
            for (int i = 0; i < 50; i++)
            {
                p[i] = new int[50];
                p[i] = Console.ReadLine().Split(' ').Select(j => int.Parse(j)).ToArray();
            }

            
            //TODO 終了するまでのループを作る
            //TODO 進めるかどうか判定する
            //TODO 進めない失敗が100回起こったら終了
            //TODO 進めなかったら50回戻る
            //TODO 戻ったら2番目に大きな値に行く
            //TODO 進める先の中で最も高い値に進む

            int faildCnt = 0;
            int nowX=sPos[0], nowY = sPos[1];
            alreadyT[t[nowX][nowY]] = true;
            while (faildCnt < 100)
            {
                int direct = 0;
                if (MoveMaxCell(out nowX,out nowY,out direct,nowX,nowY))
                {
                    direction.Push(direct);
                    alreadyT[t[nowX][nowY]] = true;
                    faildCnt++;
                }
                else
                {
                    break;
                }
            }

            string output = string.Empty;
            //出力
            while (0 < direction.Count)
            {
                switch (direction.Pop())
                {
                    case 0:
                        output += "D";
                        break;
                    case 1:
                        output += "U";
                        break;
                    case 2:
                        output += "R";
                        break;
                    case 3:
                        output += "L";
                        break;
                }
            }
            Console.WriteLine(string.Concat(output.Reverse()));
            
        }

        static bool CanMove(int x,int y)
        {
            Console.WriteLine();
            return !alreadyT[t[x][y]];
        }

        static bool MoveMaxCell(out int x, out int y,out int direct,int nowx,int nowy)
        {
            int tmpX = nowx;
            int tmpY = nowy;
            List<TInfo> TInfo = new List<TInfo>();

            if (in0And50(nowx+1))
            {
                TInfo.Add(new TInfo(nowx+1,nowy,0));
            }
            if (in0And50(nowx-1))
            {
                TInfo.Add(new TInfo(nowx-1,nowy,1));
            }
            if (in0And50(nowy+1))
            {
                TInfo.Add(new TInfo(nowx,nowy+1,2));
            }
            if (in0And50(nowy+1))
            {
                TInfo.Add(new TInfo(nowx,nowy+1,3));
            }
            
            TInfo.Sort((a,b) =>  a.P-b.P);

            for (int i = 0; i < TInfo.Count; i++)
            {
                if (CanMove(TInfo[i].X,TInfo[i].Y))
                {
                    direct = TInfo[i].direct;
                    x = TInfo[i].X;
                    y = TInfo[i].Y;
                    return true;
                }
            }

            x = nowx;
            y = nowy;
            direct = -1;
            return false;
        }

        static bool in0And50(int a)
        {
            return 0 <= a && a <= 49;
        }

        class TInfo
        {
            public int X;
            public int Y;
            public int direct;
            public int TID;
            public int P;

            public TInfo(int x, int y,int direct)
            {
                this.direct = direct;
                X = x;
                Y = y;
                TID = t[x][y];
                P = p[x][y];
            }
        }
        
    }
}