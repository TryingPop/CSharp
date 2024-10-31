using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 중첩 클래스
    교재 p 271 ~ 

    중첩 클래스(Nested Class)는 클래스 안에 선언되어 있는 클래스를 말한다.
    클래스 안에 클래스를 선언하는 것이 전부다.
    다른 클래스와 다른 점이 있따면, 자신이 소속된 클래스의 멤버에 자유롭게 접근할 수 있다.

    중첩 클래스는 클래스 외부에 공개하고 싶지 않은 형식을 만들고자 할 때나
    클래스의 일부분처럼 표현할 수 있는 클래스를 만들고자 할 때 사용한다.

    중첩 클래스는 은닉성은 무너뜨리지만 유연한 표현력을 가져다준다는 장점이 있다.
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _14_NestedClass
    {

        class Configuration
        {

            List<ItemValue> listConfig = new List<ItemValue>();

            public void SetConfig(string item, string value)
            {

                ItemValue iv = new ItemValue();
                iv.SetValue(this, item, value);
            }

            public string GetConfig(string item)
            {

                foreach(ItemValue iv in listConfig)
                {

                    if (iv.GetItem() == item)
                        return iv.GetValue();
                }

                return "";
            }

            private class ItemValue
            {

                private string item;
                private string value;

                public void SetValue(Configuration config, string item, string value)
                {

                    this.item = item;
                    this.value = value;

                    bool found = false;
                    for (int i = 0; i < config.listConfig.Count; i++)
                    {

                        if (config.listConfig[i].item == item)
                        {

                            config.listConfig[i] = this;
                            found = true;
                            break;
                        }
                    }

                    if (found == false)
                        config.listConfig.Add(this);
                }

                public string GetItem() { return item; }
                public string GetValue() { return value; }
            }
        }

        static void Main(string[] args)
        {

            Configuration config = new Configuration();
            config.SetConfig("Version", "V 5.0");
            config.SetConfig("Size", "655,324 KB");

            Console.WriteLine(config.GetConfig("Version")); // V 5.0
            Console.WriteLine(config.GetConfig("Size"));    // 655,324 KB

            config.SetConfig("Version", "V 5.0.1");
            Console.WriteLine(config.GetConfig("Version")); // V 5.0.1
        }
    }
}
