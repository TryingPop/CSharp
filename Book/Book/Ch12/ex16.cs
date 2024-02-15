using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/* 날짜 : 2022.07.28
 * 내용 : 코드 12-16
 * 
 * 클래스 활용
 */

namespace Book.Ch12
{
    internal class ex16
    {
        class Weather
        {
            public string Hour { get; set; }
            public string Day { get; set; }
            public string Temp { get; set; }
            public string WdKor { get; set; }
            public string WfKor { get; set; }
            public string Tmn { get; set; }
            public string Tmx { get; set; }
        }

        static void Main16(string[] args)
        {
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            XElement xElement = XElement.Load(url);

            var xmlQuery = from item in xElement.Descendants("data")
                           select new Weather()
                           { Hour = item.Element("hour").Value,
                             Day = item.Element("day").Value,
                             Temp = item.Element("temp").Value,
                             WdKor = item.Element("wdKor").Value,
                             WfKor = item.Element("wfKor").Value,
                             Tmn = item.Element("tmn").Value,
                             Tmx = item.Element("tmx").Value
                           };

            foreach (var item in xmlQuery)
            {
                Console.WriteLine(item.Hour + "\t");
                Console.WriteLine(item.Day + "\t");
                Console.WriteLine(item.Temp + "\t");
                Console.WriteLine(item.WdKor + "\t");
                Console.WriteLine(item.WfKor + "\t");
                Console.WriteLine(item.Tmn + "\t");
                Console.WriteLine(item.Tmx + "\t");
                Console.WriteLine();
            }
        }
    }
}
