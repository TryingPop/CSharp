using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.08.08
 * 내용 : Deepth - First Search(DFS) : 깊이 우선 탐색 알고리즘
 */

namespace Private
{
    internal class _16_DFS
    {
        static void Main16(string[] args)
        {
            MapController mapController = new MapController();
            mapController.ClearChkRoad();
            mapController.DFS(0, 0, 4, 6, null);
            mapController.Log();
        }

        public class MapController
        {
            // 탐색할 맵
            public int[,] maps = new int[,]
            {
                { 0, 0, 0, 1, 0, 0, 0 },
                { 0, 1, 0, 1, 0, 1, 0 },
                { 0, 1, 1, 1, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 1, 0 },
                { 1, 0, 1, 1, 0, 1, 0 }
            };

            // 방향 좌, 우, 상, 하
            public int[,] direction = new int[,]
            {
                { -1, 0 },
                { 1, 0 },
                { 0, -1 },
                { 0, 1 }
            };

            // 이미 지나온 길 체크
            public bool[,] chkRoad = null;

            public DFSNode bestNode = null;

            public bool ChkMapRange(int y, int x)
            {
                return (y >= 0 && y < maps.GetLength(0)) && 
                    (x >= 0 && x < maps.GetLength(1));
            }

            public bool ChkMapWay(int y, int x)
            {
                return maps[y, x] == 0;
            }

            public void ClearChkRoad()
            {
                // 초기값 false로 담긴다
                chkRoad = new bool[maps.GetLength(0), maps.GetLength(1) ];
            }

            public void Log()
            {
                while (bestNode.PrevCount > 0)
                {
                    Console.WriteLine(string.Format($"[{bestNode.Y}, {bestNode.X}]"));
                    bestNode = bestNode.PrevNode;
                }
            }

            public void DFS(int y, int x, int targetY, int targetX, DFSNode prevNode)
            {
                DFSNode node = new DFSNode(y, x, prevNode);
                if (node.Y == targetY && node.X == targetX)
                {
                    if (bestNode == null || (bestNode.PrevCount > node.PrevCount))
                    {
                        bestNode = node;
                    }
                    return;
                }

                chkRoad[y, x] = true;

                for (int i = 0; i < direction.GetLength(0); i++)
                {
                    int dy = node.Y + direction[i, 0];
                    int dx = node.X + direction[i, 1];

                    if (ChkMapRange(dy, dx) && ChkMapWay(dy, dx) && !chkRoad[dy, dx])
                    {
                        DFS(dy, dx, targetY, targetX, node);
                    }
                }
                // 재귀로 순환하는 구조라 다시 안가본 길을 가게 해준다
                chkRoad[y, x] = false;
            }
        }

        public class DFSNode
        {
            public int X { get; }
            public int Y { get; }
            public DFSNode PrevNode { get; }
            public int PrevCount { get; }

            public DFSNode(int y, int x, DFSNode prevNode)
            {
                this.Y = y;
                this.X = x;
                this.PrevNode = prevNode;

                if (PrevNode == null)
                {
                    PrevCount = 0;
                }
                else
                {
                    PrevCount = PrevNode.PrevCount + 1;
                }
            }
        }
    }
}

// 재귀 호출이라 스택 오버 플로우를 조심해야한다
// 이것을 방지하기 위해 
// https://catsbi.oopy.io/dbcc8c79-4600-4655-b2e2-b76eb7309e60
// 꼬리 재귀 
// 반환부에 연산이 없어야한다
