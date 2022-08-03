using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections;

/* 날짜 : 22.08.03
 * 내용 : reflection - class & txt파일로 Binary로 변환해서 저장
 */

namespace Private
{
    internal class _11_reflection
    {
        class Apple
        {
            public int price;
            public string city;

            public Apple(string city, int price)
            {
                this.price = price;
                this.city = city;
            }

            public void Show()
            {
                Console.WriteLine(this.price);
                Console.WriteLine(this.city);
            }
        }

        static void Main11(string[] args)
        {
            Type type = typeof(Apple);

            MemberInfo[] meminfo = type.GetMembers();

            MethodInfo[] mtdinfo = type.GetMethods();

            // filestream으로 Apple의 정보를 Apple.txt에 담는다
            string file_path = @"C:\Users\502\Desktop\CSStudy\Private\Apple.txt";
            string str;
            try
            {
                using (FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        foreach (var info in mtdinfo)
                        {
                            sw.WriteLine(info);
                            Console.WriteLine(info);
                        }
                    }
                }
                
                    


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
