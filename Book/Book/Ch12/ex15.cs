using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/* 날짜 : 2022.07.28
 * 내용 : 코드 12-15
 * 
 * 익명 객체 사용
 */

namespace Book.Ch12
{
    internal class ex15
    {
        static void Main15(string[] args)
        {
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            XElement xElement = XElement.Load(url);

            var xmlQuery = from item in xElement.Descendants("data")
                           select new 
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
