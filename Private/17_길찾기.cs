/* 날짜 : 22.08.09
 * 내용 : 길찾기 알고리즘 - JPS(?) 반정도 적용
 */

namespace Privates
{
    internal class _17_길찾기
    {
        public static int[,] map = new int[,]
        {
            { 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 0 },
            { 0, 1, 0, 1, 1, 1, 0, 0, 1, 0, 1, 0 },
            { 0, 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 0 },
            { 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0 },
            { 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 1, 0 },
            { 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 1, 0 },
            { 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0 },
            { 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0 },
            { 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0 },
            { 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0 }
        };

        public static int[,] direction = new int[,]
        {
            { -1, 0 },
            { 1, 0 },
            { 0, -1 },
            { 0, 1 }
        };

        public static bool[,] chkRoad = new bool[map.GetLength(0), map.GetLength(1)];

        public static void ClearChkRoad()
        {
            chkRoad = new bool[map.GetLength(0), map.GetLength(1)];
        }

        class Node
        {
            public int x { get; }
            public int y { get; }
            public Node PrevNode;
            public int PrevCount;

            public Node(int x, int y, Node prevNode)
            {
                this.x = x;
                this.y = y;
                this.PrevNode = prevNode;

                if (PrevNode == null)
                {
                    this.PrevCount = 0;
                }
                else
                {
                    this.PrevCount = prevNode.PrevCount + 1;
                }
            }
        }

        public static bool ChkIdx(int x, int y)
        {
            if ((x >= 0 && x < map.GetLength(0)) &&
                    (y >= 0 && y < map.GetLength(1)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // BFS로
        public static void Algorithm_1(int x, int y, int targetX, int targetY)
        {
            DateTime start = DateTime.Now;
            Queue<Node> nodes = new Queue<Node>();
            Node startNode = new Node(x, y, null);
            nodes.Enqueue(startNode);
            Node bestNode = null;
            chkRoad[x, y] = true;

            while (nodes.Count > 0)
            {
                Node node = nodes.Dequeue();

                if (node.x == targetX && node.y == targetY)
                {
                    if (bestNode == null || bestNode.PrevCount > node.PrevCount)
                    {
                        bestNode = node;
                    }
                    // queue의 특성으로 바로 탈출하는게 가장 짧은 경로
                    break;
                }

                for (int i = 0; i < direction.GetLength(0); i++)
                {
                    int dx = node.x + direction[i, 0];
                    int dy = node.y + direction[i, 1];

                    if (ChkIdx(dx, dy) && !chkRoad[dx, dy] && map[dx, dy] == 0)
                    {
                        Node addNode = new Node(dx, dy, node);
                        nodes.Enqueue(addNode);
                        chkRoad[dx, dy] = true;
                    }
                }
            }
            DateTime end = DateTime.Now;
            Console.WriteLine($"{(end - start).TotalSeconds:F5}");
            if (bestNode != null)
            {
                while (bestNode.PrevCount > 0)
                {
                    Console.WriteLine(string.Format("{0}, {1}", bestNode.x, bestNode.y));
                    bestNode = bestNode.PrevNode;
                }
            }
            else
            {
                Console.WriteLine("경로가 없습니다.");
            }
            return;
        }

        // 단순 비교용 큐에 저장하는 양이 많다
        public static void Algorithm_2(int x, int y, int targetx, int targety)
        {
            DateTime start = DateTime.Now;
            Queue<Node> nodes = new Queue<Node> ();
            Node startNode = new Node(x, y, null);
            nodes.Enqueue(startNode);
            chkRoad[x, y] = true;
            Node bestNode = null;

            while(nodes.Count > 0)
            {
                Node node = nodes.Dequeue();

                if (node.x == targetx && node.y == targety)
                {
                    if (bestNode == null || bestNode.PrevCount > node.PrevCount)
                    {
                        bestNode = node;
                    }
                }
                
                for (int i = 0; i < direction.GetLength(0); i++)
                {
                    int j = 0;
                    while (true)
                    {
                        int dx = node.x + direction[i, 0] * j;
                        int dy = node.y + direction[i, 1] * j;

                        if (!ChkIdx(dx, dy))
                        {
                            break;
                        }

                        if (direction[i,0] != 0)
                        {
                            if (ChkIdx(dx, node.y + 1))
                            {
                                if (map[dx, node.y + 1] == 0 && !chkRoad[dx, dy])
                                {
                                    Node addNode = new Node(dx, dy, node);
                                    nodes.Enqueue(addNode);
                                    chkRoad[dx, dy] = true;
                                }
                            }
                            
                            if (ChkIdx(dx, node.y - 1))
                            {
                                if (map[dx, node.y - 1] == 0 && !chkRoad[dx, dy])
                                {
                                    Node addNode = new Node(dx, dy, node);
                                    nodes.Enqueue(addNode);
                                    chkRoad[dx, dy] = true;
                                }
                            }
                        }
                        else
                        {
                            if (ChkIdx(node.x - 1, dy))
                            {
                                if (map[node.x - 1, dy] == 0 && !chkRoad[dx, dy])
                                {
                                    Node addNode = new Node(dx, dy, node);
                                    nodes.Enqueue(addNode);
                                    chkRoad[dx, dy] = true;
                                }
                            }

                            if (ChkIdx(node.x + 1, dy))
                            {
                                if (map[node.x + 1, dy] == 0 && !chkRoad[dx, dy])
                                {
                                    Node addNode = new Node(dx, dy, node);
                                    nodes.Enqueue(addNode);
                                    chkRoad[dx, dy] = true;
                                }
                            }
                        }
                        
                        if (ChkIdx(node.x + direction[i, 0] * (j + 1), node.y + direction[i, 1] * (j + 1)))
                        {
                            if (map[node.x + direction[i, 0] * (j + 1), node.y + direction[i, 1] * (j + 1)] != 0)
                            {
                                if (!chkRoad[dx, dy])
                                {
                                    Node addNode = new Node(dx, dy, node);
                                    nodes.Enqueue(addNode);
                                    chkRoad[dx, dy] = true;
                                }
                                break;
                            }
                        }
                        else
                        {
                            if (!chkRoad[dx, dy])
                            {
                                Node addNode = new Node(dx, dy, node);
                                nodes.Enqueue(addNode);
                                chkRoad[dx, dy] = true;
                            }
                            break;
                        }

                        j++;
                    } 
                }
                    
            }
            DateTime end = DateTime.Now;
            Console.WriteLine($"{(end - start).TotalSeconds:F5}");
            if (bestNode != null)
            {
                while (bestNode.PrevCount > 0)
                {
                    Console.WriteLine(string.Format("{0}, {1}", bestNode.x, bestNode.y));
                    bestNode = bestNode.PrevNode;
                }
            }
            else
            {
                Console.WriteLine("경로가 없습니다.");
            }
            return;
        }

        // 가로 세로로만 이동 가능할 때 jps 알고리즘을 직접 구현 해본 메서드
        public static void Algorithm_3(int x, int y, int targetx, int targety)
        {
            DateTime start = DateTime.Now;
            Queue<Node> nodes = new Queue<Node>();
            Node startNode = new Node(x, y, null);
            nodes.Enqueue(startNode);
            chkRoad[x, y] = true;
            Node bestNode = null;

            while (nodes.Count > 0)
            {
                Node node = nodes.Dequeue();

                if (node.x == targetx && node.y == targety)
                {
                    if (bestNode == null || bestNode.PrevCount > node.PrevCount)
                    {
                        bestNode = node;
                    }
                }

                for (int i = 0; i < direction.GetLength(0); i++)
                {
                    int j = 0;
                    while (true)
                    {
                        int dx = node.x + direction[i, 0] * j;
                        int dy = node.y + direction[i, 1] * j;

                        if (!ChkIdx(dx, dy))
                        {
                            break;
                        }

                        if (direction[i, 0] != 0)
                        {
                            if (ChkIdx(dx, node.y + 1) && ChkIdx(dx - 1, node.y + 1))
                            {
                                if (map[dx, node.y + 1] == 0 && !chkRoad[dx, dy] && map[dx -1, node.y + 1] != 0)
                                {
                                    Node addNode = new Node(dx, dy, node);
                                    nodes.Enqueue(addNode);
                                    chkRoad[dx, dy] = true;
                                }
                            }
                            else if (ChkIdx(dx, node.y + 1))
                            {
                                if (map[dx, node.y + 1] == 0 && !chkRoad[dx, dy])
                                {
                                    Node addNode = new Node(dx, dy, node);
                                    nodes.Enqueue(addNode);
                                    chkRoad[dx, dy] = true;
                                }
                            }

                            if (ChkIdx(dx, node.y - 1) && ChkIdx(dx - 1, node.y - 1))
                            {
                                if (map[dx, node.y - 1] == 0 && !chkRoad[dx, dy] && map[dx - 1, node.y - 1] != 0)
                                {
                                    Node addNode = new Node(dx, dy, node);
                                    nodes.Enqueue(addNode);
                                    chkRoad[dx, dy] = true;
                                }
                            }
                            else if (ChkIdx(dx, node.y - 1))
                            {
                                if (map[dx, node.y - 1] == 0 && !chkRoad[dx, dy])
                                {
                                    Node addNode = new Node(dx, dy, node);
                                    nodes.Enqueue(addNode);
                                    chkRoad[dx, dy] = true;
                                }
                            }
                        }
                        else
                        {
                            if (ChkIdx(node.x - 1, dy) && ChkIdx(node.x - 1, dy - 1))
                            {
                                if (map[node.x - 1, dy] == 0 && !chkRoad[dx, dy] && map[node.x - 1, dy - 1] != 0)
                                {
                                    Node addNode = new Node(dx, dy, node);
                                    nodes.Enqueue(addNode);
                                    chkRoad[dx, dy] = true;
                                }
                            }
                            else if (ChkIdx(node.x - 1, dy))
                            {
                                if (map[node.x - 1, dy] == 0 && !chkRoad[dx, dy])
                                {
                                    Node addNode = new Node(dx, dy, node);
                                    nodes.Enqueue(addNode);
                                    chkRoad[dx, dy] = true;
                                }
                            }


                            if (ChkIdx(node.x + 1, dy) && ChkIdx(node.x + 1, dy - 1))
                            {
                                if (map[node.x + 1, dy] == 0 && !chkRoad[dx, dy] && map[node.x + 1, dy - 1] != 0)
                                {
                                    Node addNode = new Node(dx, dy, node);
                                    nodes.Enqueue(addNode);
                                    chkRoad[dx, dy] = true;
                                }
                            }
                            else if (ChkIdx(node.x + 1, dy))
                            {
                                if (map[node.x + 1, dy] == 0 && !chkRoad[dx, dy])
                                {
                                    Node addNode = new Node(dx, dy, node);
                                    nodes.Enqueue(addNode);
                                    chkRoad[dx, dy] = true;
                                }
                            }
                        }

                        if (ChkIdx(node.x + direction[i, 0] * (j + 1), node.y + direction[i, 1] * (j + 1)))
                        {
                            if (map[node.x + direction[i, 0] * (j + 1), node.y + direction[i, 1] * (j + 1)] != 0)
                            {
                                if (!chkRoad[dx, dy])
                                {
                                    Node addNode = new Node(dx, dy, node);
                                    nodes.Enqueue(addNode);
                                    chkRoad[dx, dy] = true;
                                }
                                break;
                            }
                        }
                        else
                        {
                            if (!chkRoad[dx, dy])
                            {
                                Node addNode = new Node(dx, dy, node);
                                nodes.Enqueue(addNode);
                                chkRoad[dx, dy] = true;
                            }
                            break;
                        }

                        j++;
                    }
                }
            }

            DateTime end = DateTime.Now;
            Console.WriteLine($"{(end - start).TotalSeconds:F5}");
            if (bestNode != null)
            {
                while (bestNode.PrevCount > 0)
                {
                    Console.WriteLine(string.Format("{0}, {1}", bestNode.x, bestNode.y));
                    bestNode = bestNode.PrevNode;
                }
            }
            else
            {
                Console.WriteLine("경로가 없습니다.");
            }
            return;

        }


        // Algorithm1과 Algorithm2, 3과 시간차이는 10배 이상 차이난다
        static void Main17(string[] args)
        {
        int targetx = map.GetLength(0) - 1;
            int targety = map.GetLength(1) - 1;

/*  
// 맵이 다음과 같을 때
// 0 : 지나갈 수 있는 길, 1 : 못지나가는 벽, 2 : 시작지점, 3 : 도착지점

    { 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 0 },
    { 0, 1, 2, 1, 1, 1, 0, 0, 1, 0, 1, 0 },
    { 0, 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 0 },
    { 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0 },
    { 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 1, 0 },
    { 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 1, 0 },
    { 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0 },
    { 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0 },
    { 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0 },
    { 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 3 }
*/

            Console.WriteLine("Algorithm 1");
            ClearChkRoad();
            Algorithm_1(1, 2, targetx, targety); // 0.00405s 
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Algorithm 2");
            ClearChkRoad();

            Algorithm_2(1, 2, targetx, targety); // 0.00005s

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Algorithm 3");
            ClearChkRoad();

            Algorithm_3(1, 2, targetx, targety); // 0.00006s
        }
    }
}

// 참고 사이트
// https://joonleestudio.tistory.com/28
// https://game-dev.tistory.com/13
// https://m.blog.naver.com/PostView.naver?isHttpsRedirect=true&blogId=gg9494&logNo=221523868892
// 추후에 코드를 짤 때는
// 유닛 단위로 넓혀가면서 도착하는지 체크 
// 중간에 오브젝트가 있는 경우 jps 처럼 좌표만 찝어서 이전 경로들과 함께 넣어주면 될거 같다

