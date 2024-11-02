using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 2
이름 : 배성훈
내용 : 형식 매개변수 제약 지키기
    교재 p 414 ~ 

    형식 매개변수 T는 모든 데이터 형식을 대신할 수 있다.
    특정 조건을 갖춘 형식에만 대응하는 형식 매개변수가 필요할 때도 있다.
    where 절을 이용해 제약을 줄 수 있다.

    제약은 제네릭 메소드도 가능하다.
    제약 조건에 int나 기본 자료형은 사용이 불가능하다.
*/

namespace Study._2024.Ch11_일반화.코드
{
    internal class _03_ConstraintsOnTypeParameters
    {

        class StructArray<T> where T : struct
        {

            public T[] Array { get; set; }
            public StructArray(int size)
            {

                Array = new T[size];
            }
        }

        class RefArray<T> where T : class
        {

            public T[] Array { get; set; }
            public RefArray(int size)
            {

                Array = new T[size];
            }
        }

        class Base { }
        class Derived : Base { }
        class BaseArray<U> where U : Base
        {

            public U[] Array { get; set; }
            public BaseArray(int size)
            {

                Array = new U[size];
            }

            public void CopyArray<T>(T[] Source) where T : U
            {

                Source.CopyTo(Array, 0);
            }
        }

        public static T CreateInstance<T>() where T : new()
        {

            return new T();
        }

        static void Main3(string[] args)
        {

            StructArray<int> a = new StructArray<int>(3);
            a.Array[0] = 0;
            a.Array[1] = 1;
            a.Array[2] = 2;

            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            b.Array[0] = new StructArray<double>(5);
            b.Array[1] = new StructArray<double>(10);
            b.Array[2] = new StructArray<double>(1005);

            BaseArray<Base> c = new BaseArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived();
            c.Array[2] = CreateInstance<Base>();

            BaseArray<Derived>d = new BaseArray<Derived>(3);
            d.Array[0] = new Derived();
            d.Array[1] = CreateInstance<Derived>();
            d.Array[2] = CreateInstance<Derived>();

            BaseArray<Derived> e = new BaseArray<Derived>(3);
            e.CopyArray<Derived>(d.Array);
        }
    }
}
