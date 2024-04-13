using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

/*
날짜 : 2024. 4. 14
이름 : 배성훈
내용 : 이중 우선순위 큐
    문제번호 : 7662번

    
    AVL 트리 참고한 사이트
    해당 기능을 보고 문제에 맞춰 구현하고 있다
    https://walbatrossw.github.io/data-structure/2018/10/26/ds-avl-tree.html
*/

namespace BaekJoon.etc
{
    internal class etc_0527
    {

        static void Main527(string[] args)
        {

#if Wrong

            // 어느 사이트에서 우선순위 큐를 구현하는 코드를 봤는데,
            // 해당 코드는 좋지 않다!
            int MAX = 1_000_001;

            int INSERT = 'I' - '0';
            int DELETE = 'D' - '0';

            string EMPTY = "EMPTY\n";
            int[] myArr = new int[2 * MAX];

            int head;
            int count;

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int test = ReadInt();

            while(test-- > 0)
            {

                int n = ReadInt();
                head = MAX;
                count = 0;

                for (int i = 0; i < n; i++)
                {

                    int f = ReadInt();
                    int b = ReadInt();

                    if (f == INSERT) Insert(b);
                    else
                    {

                        if (b == 1) Delete(false);
                        else Delete(true);
                    }
                }

                if (count == 0) sw.Write(EMPTY);
                else sw.Write($"{myArr[head + count - 1]} {myArr[head]}\n");
            }

            sr.Close();
            sw.Close();

            void Delete(bool _isFront = true)
            {

                if (count == 0) return;
                count--;
                if (_isFront) head++;
            }

            void Insert(int _x)
            {

                // 시간초과 뜨는 코드다!
                // 순차적으로 큰 값을 넣으면 N^2의 시간이 된다!
                int l = head;
                int r = head + count - 1;

                while(l <= r)
                {

                    int mid = (l + r) / 2;
                    if (myArr[mid] < _x) l = mid + 1;
                    else r = mid - 1;
                }

                int s = r + 1;
                int tail = head + count - 1;
                for (int i = tail; i >= s; i--)
                {

                    myArr[i + 1] = myArr[i];
                }
                myArr[s] = _x;
                count++;
            }

            int ReadInt()
            {

                int c, ret = 0;
                bool plus = true;
                while((c = sr.Read()) != -1 && c != ' ' && c != '\n')
                {

                    if (c == '\r') continue;
                    else if (c == '-')
                    {

                        plus = false;
                        continue;
                    }
                    ret = ret * 10 + c - '0';
                }

                return plus ? ret : -ret;
            }
#else

            StreamReader sr = new(Console.OpenStandardInput());

            int ReadInt()
            {

                int c, ret = 0;
                bool plus = true;
                while ((c = sr.Read()) != -1 && c != ' ' && c != '\n')
                {

                    if (c == '\r') continue;
                    else if (c == '-')
                    {

                        plus = false;
                        continue;
                    }
                    ret = ret * 10 + c - '0';
                }

                return plus ? ret : -ret;
            }
#endif
        }


        class MyData
        {

            private Node root;

            private Node RotR(Node _parent)
            {

                Node newParent = _parent.left;
                Node nullNode = newParent.right;

                newParent.right = _parent;
                _parent.left = nullNode;

                _parent.height = Math.Max(Height(_parent.left), Height(_parent.right)) + 1;
                newParent.height = Math.Max(Height(newParent.left), Height(newParent.right)) + 1;

                return newParent;
            }

            private Node RotL(Node _parent)
            {

                Node newParent = _parent.right;
                Node nullNode = newParent.left;

                newParent.left = _parent;
                _parent.right = nullNode;

                _parent.height = Math.Max(Height(_parent.left), Height(_parent.right)) + 1;
                newParent.height = Math.Max(Height(newParent.left), Height(newParent.right)) + 1;

                return newParent;
            }

            public void Insert(int _val)
            {

                root = InsertNode(root, _val);
            }

            private Node InsertNode(Node _node, int _val)
            {

                if (_node == null)
                {

                    Node ret = new Node();
                    ret.val = _val;
                    return ret;
                }

                if (_val < _node.val) _node.left = InsertNode(_node.left, _val);
                else _node.right = InsertNode(_node.right, _val);

                _node.height = Math.Max(Height(_node.left), Height(_node.right));

                _node = SetBalance(_val, _node);

                return _node;
            }

            private Node SetBalance(int _val, Node _node)
            {

                int balance = GetBalance(_node);

                if (balance > 1 && _val < _node.val) return RotR(_node);
                if (balance < -1 && _val > _node.val) return RotL(_node);

                if (balance > 1 && _val > _node.val)
                {

                    _node.left = RotL(_node.left);
                    return RotR(_node);
                }

                if (balance < -1 && _val < _node.val)
                {

                    _node.right = RotR(_node.right);
                    return RotL(_node);
                }

                return _node;
            }

            private int GetBalance(Node _node)
            {

                if (_node == null) return 0;

                return Height(_node.left) - Height(_node.right);
            }

            private int Height(Node _node)
            {

                if (_node == null) return -1;
                return _node.height;
            }


            public class Node 
            {

                public Node left;
                public Node right;

                public int val;
                public int height;
            }
        }
    }
}
