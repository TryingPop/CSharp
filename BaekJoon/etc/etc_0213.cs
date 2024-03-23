using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 3. -
이름 : 배성훈
내용 : 모자이크
    문제번호 : 2539번
*/

namespace BaekJoon.etc
{
    internal class etc_0213
    {


    }

    struct Pos : IComparable<Pos>
    {

        public int x;
        public int y;
        public bool chk;

        public int CompareTo(Pos other)
        {

            int ret = x.CompareTo(other.x);
            if (ret != 0) return ret;

            ret = y.CompareTo(other.y);
            return ret;
        }

        public void Set(int _x, int _y)
        {

            x = _x;
            y = _y;
        }

        public bool ChkArea(int _x, int _y, int _size)
        {

            if (chk) return true;
            if (x < _x || _x + _size < x) return false;
            if (y < _y || _y + _size < y) return false;

            return true;
        }
    }
}
