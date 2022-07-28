using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/* 날짜 : 2022.07.28
 * 내용 : 코드 12-14
 * 
 * data 태그 내부에서 값 추출
 */

namespace Book.Ch12
{
    internal class ex14
    {
        static void Main14(string[] args)
        {
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            XElement xElement = XElement.Load(url);

            var xmlQuery = from item in xElement.Descendants("data")
                           select item;

            foreach (var item in xmlQuery)
            {
                Console.WriteLine(item.Element("hour").Value  + "\t");
                Console.WriteLine(item.Element("day").Value + "\t");
                Console.WriteLine(item.Element("temp").Value + "\t");
                Console.WriteLine(item.Element("wdKor").Value + "\t");
                Console.WriteLine(item.Element("wfKor").Value + "\t");
                Console.WriteLine(item.Element("tmn").Value + "\t");
                Console.WriteLine(item.Element("tmx").Value + "\t");
                Console.WriteLine();
            }

        }
    }
}
