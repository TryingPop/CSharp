using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class OmokAi
    {
        public bool isBlack = false;
        public int x = 0;
        public int y = 0;

        public void GetPos()
        {
            // Ai가 놓을 위치 알고리즘! 
            // 4줄짜리 부터 >> 3줄 >> 2줄순서!
        }
    }

    internal class Omok
    {
        public enum STONE { none, white, black }
        public static STONE[,] dataSet = new STONE[19, 19];
        public static void Set_dataSet()
        {
            Omok.dataSet = new STONE[19, 19];
        }

        // 바둑돌 특정 길이 체크
        public static bool chkNum(int x, int y, int len = 5)
        {
            int count = 1;
            int x_1, y_1, x_2, y_2;
            
            // case for문
            for (int k = 0; k < 4; k++)
            {
                // chk 시작 위치 
                for (int i = -len; i <= 0; i++)
                {
                    count = 1;
                    chkdir(x, y, i, k, out x_1, out y_1);

                    if (!chkidx(x_1, y_1))
                    {
                        continue;
                    }

                    if (Omok.dataSet[x_1, y_1] == Omok.dataSet[x, y] && Omok.dataSet[x,y] != Omok.STONE.none)
                    {
                        // chk
                        for (int j = 1; j < len+1; j++)
                        {
                            chkdir(x_1, y_1, j, k, out x_2, out y_2);
                            if (!chkidx(x_2, y_2))
                            {
                                continue;
                            }

                            if (Omok.dataSet[x_2, y_2] == Omok.dataSet[x_1, y_1])
                            {
                                count++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine(count);
                        Console.WriteLine();
                        if (count == len) { return true; }
                        else if (count > len) { break; }
                    }
                }
            }
            return false;
        }

        // 인덱스 범위 체크
        public static bool chkidx(int x, int y = 1, int min = 0, int max = 18)
        {
            if (x <= max && x >= min && y <= max && y >= min)
            {
                return true;
            }
            else { return false; }
        }

        // 판별 방향 설정
        static void chkdir(int x, int y, int i, int cnum, out int set_x, out int set_y)
        {
            // 0 : 가로, 1 : 세로 , 2 : y = -x, 3 : y = x
            switch (cnum)
            {
                case 0: // 가로
                    x += i;
                    break;
                case 1: // 세로
                    y += i;
                    break;
                case 2: // y = -x
                    x += i;
                    y += i;
                    break;
                case 3: // y = x
                    x += i;
                    y -= i;
                    break;
                default:
                    break;
            }
            set_x = x;
            set_y = y;
        }

    }
}
