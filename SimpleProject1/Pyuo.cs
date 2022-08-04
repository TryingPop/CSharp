using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProject1
{
    internal class Pyuo
    {
        // 맵 사이즈 X, Y
        public const byte mapSizeX = 8;
        public const byte mapSizeY = 15;


        // 뿌요 제거 판별할 판
        // 판에 놓여 있는 돌
        // 0 : 없음, 1 : 빨강, 2 : 노랑, 3 : 초록, 4 : 파랑, 5 : 보라
        public static byte[,] map = new byte[mapSizeX, mapSizeY];
        public static byte[,] chkmap = map.Clone() as byte[,];
        public static byte[,] bchkmap = map.Clone() as byte[,]; 


        public int chkPyuo()
        {
            int score = 1;
            int result = 0;
            while (chkmap != map)
            {
                for (int posX = 0; posX < mapSizeX; posX++)
                {
                    for (int posY = mapSizeY - 1; posY >= 0; posY--)
                    {
                        if (map[posX, posY] != chkmap[posX, posY])
                        {
                            int range = 0;
                            int count = 0;

                            while (ChkConnected(posX, posY, range, ref count))
                            {
                                range++;
                            }

                            if (count >= 4)
                            {
                                OrderPyuo(bchkmap);
                                // bchkmap에 블록 내리는거 먼저 실행
                                map = chkmap.Clone() as byte[,];
                                chkmap = bchkmap.Clone() as byte[,];
                                score++;
                                result += score * count;
                            }
                            else
                            {
                                bchkmap = chkmap.Clone() as byte[,];
                            }
                        }
                    }
                }
                if (bchkmap == chkmap)
                {
                    map = chkmap.Clone() as byte[,];
                }
            }
            return result;
        }

        // 맵 인덱스 범위 넘어가는지 체크
        public static bool SafeIdx(int posX, int posY)
        {
            if (posX < 0 || posX >= mapSizeX || posY < 0 || posY >= mapSizeY)
            {
                return false;
            }
            else 
            { 
                return true; 
            }
            
        }

        // ChkConnected의 보조 함수
        public static void ResPos(int posX, int posY, int range,int dNum, out int resX, out int resY)
        {
            switch (dNum)
            {
                case 0:
                    posX += range;
                    break;
                case 1:
                    posX -= range;
                    break;
                case 2:
                    posY += range;
                    break;
                case 3:
                    posY -= range;
                    break;
                default:
                    break;
            }
            resX = posX;
            resY = posY;
            return;
        }

        // 특정 좌표에서 시작하여 연결된 뿌요 갯수 찾는 함수
        public static bool ChkConnected(int posX, int posY, int range, ref int count)
        {
            bool result = false;
            for (int dNum = 0; dNum < 4; dNum++)
            {
                int resX;
                int resY;
                ResPos(posX, posY, range, dNum, out resX, out resY);
                
                if (SafeIdx(resX, resY) || chkmap[posX, posY] == 0)
                {
                    continue;
                }

                if (chkmap[posX, posY] == chkmap[resX, resY])
                {
                    count++;
                    bchkmap[resX, resY] = 0;
                    result = true;
                }
            }
            return result;
        }

        // 뿌요 아래로 내리기
        public static void OrderPyuo(byte[,] map)
        {
            for (int posX = 0; posX < mapSizeX; posX++)
            {
                for (int posY = mapSizeY-1; posY >= 0; posY--)
                {
                    if (map[posX, posY] != 0)
                    {
                        if (SafeIdx(posX, posY + 1)) 
                        {
                            if (map[posX, posY +1] == 0)
                            {
                                map[posX, posY + 1] = map[posX, posY];
                                map[posX, posY] = 0;
                            }
                        }
                    }
                }
            }
        }


    }
}
