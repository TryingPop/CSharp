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
        public static byte count = 0;

        // 뿌요 제거 판별할 판
        // 판에 놓여 있는 돌
        // 0 : 없음, 1 : 빨강, 2 : 노랑, 3 : 초록, 4 : 파랑, 5 : 보라
        public static byte[,] map = new byte[mapSizeX, mapSizeY];
        // 계산 확인용 판
        public static byte[,] bmap = map.Clone() as byte[,];
        // 연결된 갯수 표기 판
        public static byte[,] cmap = map.Clone() as byte[,];
        

        // 4개 이상이 뭉친게 있는지 확인! << 잘못되었다.
        public static void chkPyuo(int posX, int posY)
        {
            Pyuo.count = 1;
            if (map[posX, posY] == 0)
            {

                return;
            }
            byte range = 1;
            bool chk = true;

            while (chk)
            {
                chk = ChkConnected(posX, posY, range, ref count);
                range++;
            }

            if (count >= 4)
            {
                cmap[posX, posY] = 0;
                map = cmap.Clone() as byte[,];
                Pyuo.count = 1;
            }
            
        }

        // 특정 좌표에서 시작하여 뭉친 갯수 찾는 메서드 << 잘못되었다.
        public static bool ChkConnected(int posX, int posY, byte range, ref byte count)
        {
            bool result = false;
            int resX = posX - range;
            int resY = posY;

            for (byte dir = 0; dir < 4; dir++)
            {
                for (byte n = 0; n < range; n++)
                {
                    GetPos(resX, resY, dir, out resX, out resY);

                    if (!SafeIdx(resX, resY))
                    {
                        continue;
                    }

                    if (map[posX, posY] == map[resX, resY])
                    {
                        count++;
                        cmap[resX, resY] = 0;
                        result = true;
                    }
                }
            }


            return result;
        }

        // 뭉친 갯수 찾는 보조함수 << 잘못 되었다.
        public static void GetPos(int posX, int posY, byte dir, out int resX, out int resY)
        {
            switch (dir)
            {
                case 0:
                    posX += 1;
                    posY += 1;
                    break;
                case 1:
                    posX += 1;
                    posY -= 1;
                    break;
                case 2:
                    posX -= 1;
                    posY -= 1;
                    break;
                case 3:
                    posX -= 1;
                    posY += 1;
                    break;
                default:
                    break;
            }
            resX = posX;
            resY = posY;
            return;
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

        // 돌 아래로 내리기
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

        // map이 같은지 확인
        public static bool ChkMaps()
        {
            for (int posX = 0; posX < mapSizeX; posX++)
            {
                for (int posY = 0; posY < mapSizeY; posY++)
                {
                    if (bmap[posX, posY] != map[posX, posY])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
