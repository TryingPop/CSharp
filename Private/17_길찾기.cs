namespace Private
{
    internal class _17_길찾기
    {
        public static int[,] map = new int[,]
        {
            { 0, 0, 0, 1, 1, 0 },
            { 0, 1, 0, 1, 1, 1 },
            { 0, 1, 0, 0, 0, 0 },
            { 0, 1, 0, 1, 0, 1 },
            { 0, 0, 0, 1, 0, 1 },
            { 0, 1, 0, 1, 0, 0 },
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

        // jps? 
        public static void Algorithm_2(int x, int y, int targetx, int targety)
        {
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
                    int j = 1;
                    // 인덱스 구문 오류 뜬다 추후에 다시 완료하기
                    while (map[node.x + direction[i, 0] * j, node.y + direction[i, 1] * j] == 0)
                    {
                        int dx = node.x + direction[i, 0] * j;
                        int dy = node.y + direction[i, 1] * j;

                        if (direction[i, 1] == 0)
                        {
                            if (ChkIdx(dx - direction[i, 0], dy - 1) && ChkIdx(dx, dy - 1))
                            {
                                if (map[dx - direction[i, 0], dy - 1] == 0 && map[dx, dy - 1] == 1 && !chkRoad[dx, dy - 1])
                                {
                                    Node addNode = new Node(dx, dy - 1, node);
                                    nodes.Enqueue(addNode);
                                    chkRoad[dx, dy - 1] = true;
                                }
                            }
                            if (ChkIdx(dx - direction[i, 0], dy + 1) && ChkIdx(dx, dy + 1))
                            {
                                if (map[dx - direction[i, 0], dy + 1] == 0 && map[dx, dy + 1] == 1 && !chkRoad[dx, dy + 1])
                                {
                                    Node addNode = new Node(dx, dy + 1, node);
                                    nodes.Enqueue(addNode);
                                    chkRoad[dx, dy + 1] = true;
                                }
                            }
                        }
                        else
                        {
                            if (ChkIdx(dx - 1, dy - direction[i, 1]) &&ChkIdx(dx - 1, dy))
                            {
                                if (map[dx - 1, dy - direction[i, 1]] == 0 && map[dx - 1, dy] == 1 && !chkRoad[dx -1, dy])
                                {
                                    Node addNode = new Node(dx - 1, dy, node);
                                    nodes.Enqueue(addNode);
                                    chkRoad[dx - 1, dy] = true;
                                }
                            }
                            if (ChkIdx(dx + 1, dy - direction[i, 1]) && ChkIdx(dx + 1, dy))
                            {
                                if (map[dx + 1, dy - direction[i, 1]] == 0 && map[dx + 1, dy] == 1 && !chkRoad[dx + 1, dy])
                                {
                                    Node addNode = new Node(dx + 1, dy, node);
                                    nodes.Enqueue(addNode);
                                    chkRoad[dx + 1, dy] = true;
                                }
                            }
                        }
                        j++;
                    } 
                }
                    
            }

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

        static void Main(string[] args)
        {
            int targetx = 5;
            int targety = 5;

            // DateTime start1 = DateTime.Now;

            ClearChkRoad();
            Algorithm_1(0, 0, targetx, targety);

            ClearChkRoad();

            // Algorithm_2(0, 0, targetx, targety);
        }
    }
}
