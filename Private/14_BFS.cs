using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.08.05
 * 내용 : Breadth-First Search(BFS) :  너비 우선 탐색 즉 시작 지점에서 가장 가까운 것부터 탐색
 *
 */

namespace Private
{
    internal class _14_BFS
    {
        static void Main(string[] args)
        {
            MapController mapController = new MapController();

            mapController.BFS(0, 0, 4, 3);
        }

        public class MapController
        {
            // 탐색할 맵
            public int[,] maps = new int[,]
            {
                {0, 0, 0, 0, 0, 0 },
                {0, 0, 1, 0, 0, 0 },
                {0, 0, 1, 0, 0, 0 },
                {0, 0, 1, 0, 0, 0 },
                {0, 0, 0, 0, 0, 0 }
            };

            public int[,] direction = new int[,]
            {
                { -1, 0 },
                { 1, 0 },
                { 0, -1 },
                { 0, 1 }
            };

            public bool[,] chkRoad = null;

            private void ClearChkRoad()
            {
                chkRoad = new bool[maps.GetLength(0), maps.GetLength(1) ];
                for (int i = 0; i < chkRoad.GetLength(0); i++)
                {
                    for(int j = 0; j < chkRoad.GetLength(1); j++)
                    {
                        chkRoad[i, j] = false;
                    }
                }
            }

            private bool ChkMapWay(int y, int x)
            {
                return maps[y, x] == 0;
            }

            private bool ChkMapRange(int y, int x)
            {
                return (y >= 0 && y < maps.GetLength(0)) && 
                    (x >= 0 && x < maps.GetLength(1));
            }
            
            public void BFS(int y, int x, int targetY, int targetX)
            {
                // 길 체크 플래그 초기화
                ClearChkRoad();

                // 가장빠른 길을 담을 노드를 선언
                BFSNode bestNode = null;

                // 탐색하기 위한 BFSNode형 Queue를 만든다
                // 시작지점을 가리키는 Node를 만들어서 담는다
                // 시작지점은 한번 들른 길로서 체크한다.
                Queue<BFSNode> queue = new Queue<BFSNode>();
                queue.Enqueue(new BFSNode(y, x, null));
                chkRoad[y, x] = true;

                // 더이상 탐색할게 없을 때까지 루프
                while(queue.Count > 0)
                {
                    // 노드를 가져오기
                    BFSNode node = queue.Dequeue();

                    // 현재 노드가 목표지점일 경우
                    if (node.Y == targetY && node.X == targetX)
                    {
                        // 가장 빠른 길이 아직 없거나
                        // 현재 노드가 가장 빠른 길일 경우 bestNode에 담는다
                        // 이후 여기에 들어오는 Node들과 bestNode를 비교하여 가장 빠른 길을 담는다.
                        if (bestNode == null || (bestNode.PrevCount > node.PrevCount))
                        {
                            bestNode = node;
                        }
                    }

                    // 상 하 좌 우를 체크한다
                    for (int i = 0; i < direction.GetLength(0); i++)
                    {
                        // 현재 노드의 위치
                        int dy = node.Y + direction[i, 0];
                        int dx = node.X + direction[i, 1];

                        // 좌표가 맵의 범위안에 있으며
                        // 갈 수 있는 길이고
                        // 한 번도 들른적 없는 길인 경우
                        if (ChkMapRange(dy, dx) && ChkMapWay(dy, dx) && !chkRoad[dy, dx])
                        {
                            // 찾은 길은 노드를 만들어 Queue에 담는다.
                            // 현재 노드는 찾은 길의 이전 노드로서 담는다.
                            BFSNode searchNode = new BFSNode(dy, dx, node);
                            queue.Enqueue(searchNode);

                            // 이 좌표는 한 번 들른 길로 체크한다
                            chkRoad[dy, dx] = true;
                        }
                    }
                }

                if (bestNode != null)
                {
                    while (bestNode.PrevCount > 0)
                    {
                        // bestNode를 순회하며 해당 좌표를 콘솔로 찍어준다
                        Console.WriteLine(string.Format("[{0}, {1}]", bestNode.Y, bestNode.X));

                        bestNode = bestNode.PrevNode;
                    }
                }
            }
        }

        public class BFSNode
        {
            public int X { get; }
            public int Y { get; }
            // 이전 노드
            public BFSNode PrevNode { get; }
            // 이전 노드의 갯수
            public int PrevCount { get; }

            public BFSNode(int y, int x, BFSNode prevNode)
            {
                this.Y = y;
                this.X = x;
                this.PrevNode = prevNode;

                if (PrevNode == null)
                {
                    // 이전 노드가 없으면 시작지점이라 카운트 0
                    this.PrevCount = 0;
                }
                else
                {
                    // 이전 노드가 있으면 이전 노드 갯수 + 1
                    // 목표 지점에 해당하는 노드는 최종적으로
                    // 시작지점에서 목표지점까지의 노드 수가 담기게 된다.
                    PrevCount = PrevNode.PrevCount + 1;
                }
            }
        }
    }
}

// 참고 사이트 
// https://chipmunk-plump-plump.tistory.com/330