using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProject1
{
    public class Dol
    {
        // 고정된 돌의 좌표
        public int x = (Game.mapSizeX / 2); 
        public int y = 0;
        // 고정된 돌의색
        public int color = 0;

        public Dol()
        {
            Random rd = new Random();
            this.color = rd.Next(1, Game.colorNum);
        }
    }

    internal class Game
    {
        // 맵 사이즈 X, Y
        public static Random rd = new Random();
        public const int mapSizeX = 8;
        public const int mapSizeY = 15;
        public static int count = 0;
        public static int dirNum = 0;
        // 방향 0 : 상, 1 : 우, 2 : 하, 3 : 좌
        public static int[,] direction = { {0, -1},
                                      {1, 0}, 
                                      { 0, 1}, 
                                      { -1, 0 } };

        // 돌 아래로 내리는데 사용할 변수 
        private const byte turnNumber = 10;
        public static byte turnCount = 0;

        // 판에 놓여 있는 돌의 색상 갯수
        // public static string[] colors = { "없음", "빨강", "노랑", "초록", "파랑", "보라" };
        public static string[] colors = { "없음", "빨강", "노랑", "초록" };
        // 0 : 없음, 1 : 빨강, 2 : 노랑, 3 : 초록, 4 : 파랑, 5 : 보라
        public static int colorNum = colors.Length;

        public static Dol[] Dols;
        public static Dol[] nextDols = {new Dol(), new Dol()};

        // 돌 제거 판별할 판
        public static int[,] map = new int[mapSizeX, mapSizeY + 1];
        
        // 돌이 다 내려왔는지 판별용
        public static int[,] bmap = (int[,])map.Clone();
        
        // 4개 이상 연결된거 있는지 판별
        public static void ChkLink(int posX, int posY)
        {
            if (map[posX, posY] == 0)
            {
                return;
            }
            bool[,] cmap = new bool[mapSizeX, mapSizeY + 1];
            int count = 1;

            int[] pos = new int[2] { posX, posY };
            Queue<int[]> queue = new Queue<int[]>();
            
            queue.Enqueue(pos);
            cmap[posX, posY] = true;

            while (queue.Count > 0)
            {
                int[] chkpos = queue.Dequeue();
                int X = chkpos[0];
                int Y = chkpos[1];
                for (int i = 0; i < direction.GetLength(0); i++)
                {
                    int dx = (X + direction[i, 0]);
                    int dy = (Y + direction[i, 1]);

                    if (SafeIdx(dx, dy) && !cmap[dx, dy] && map[dx, dy] == map[posX, posY])
                    {
                        int[] newpos = { dx, dy };
                        queue.Enqueue(newpos);
                        cmap[dx, dy] = true;
                        count++;
                    }
                }
            }

            if (count >= 4)
            {
                for (int x = 0; x < mapSizeX; x++)
                {
                    for (int y = 0; y < mapSizeY + 1; y++)
                    {
                        if (cmap[x, y] == true)
                        {
                            map[x, y] = 0;
                        }
                    }
                }
            }
            return;
        }

        // 맵 인덱스 범위 넘어가는지 체크
        public static bool SafeIdx(int posX, int posY)
        {
            if (posX < 0 || posX >= mapSizeX || posY < 0 || posY >= mapSizeY + 1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        // 전체 돌 아래로 내리기
        public static void OrderDol()
        {
            bmap = (int[,])map.Clone();
            for (int posX = 0; posX < mapSizeX; posX++)
            {
                for (int posY = mapSizeY; posY >= 1; posY--)
                {
                    if (map[posX, posY] != 0)
                    {
                        if (SafeIdx(posX, (int)(posY + 1)))
                        {
                            if (map[posX, posY + 1] == 0)
                            {
                                map[posX, posY + 1] = map[posX, posY];
                                map[posX, posY] = 0;
                            }
                        }
                    }
                }
            }
        }

        // 연산 여부 확인
        public static bool ChkMaps()
        {
            for (int posX = 0; posX < mapSizeX; posX++)
            {
                for (int posY = 1; posY < mapSizeY + 1; posY++)
                {
                    if (bmap[posX, posY] != map[posX, posY])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        
        // 돌 생성
        public static void GenerateDols()
        {
            nextDols[0].y = 1;
            Dols = nextDols;
            nextDols = new Dol[] { new Dol(), new Dol() };
        }

        // 돌 회전
        public static void RotationDols()
        {
            dirNum++;
            dirNum %= 4;
            int X = Dols[0].x + direction[dirNum, 0];
            int Y = Dols[0].y + direction[dirNum, 1];

            if (SafeIdx(X, Y))
            {
                Dols[1].x = X;
                Dols[1].y = Y;
            }
        }

        // 돌의 충돌 체크
        public static bool ChkCollision()
        {
            if (SafeIdx(Dols[0].x, Dols[0].y) && SafeIdx(Dols[1].x, Dols[1].y))
            {
                if (map[Dols[0].x, Dols[0].y] == 0 && map[Dols[1].x, Dols[1].y] == 0)
                {
                    return false;
                }
            }
            return true;
        }

        // 돌 맵에 넣기
        public static bool AddDols()
        {
            if (ChkCollision())
            {
                map[Dols[0].x, Dols[0].y - 1] = Dols[0].color;
                map[Dols[1].x, Dols[1].y - 1] = Dols[1].color;
                return false;
            }

            return true;
        }

        // 턴 체크!
        public static bool turnChk(byte n)
        {
            turnCount += n;
            if (turnCount >= turnNumber)
            {
                turnCount = 0;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}