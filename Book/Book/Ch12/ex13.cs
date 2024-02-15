using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/* 날짜 : 2022.07.28
 * 내용 : 코드 12-13
 * 
 * data 태그 추출
 */

namespace Book.Ch12
{
    internal class ex13
    {
        static void Main13(string[] args)
        {
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            XElement xElement = XElement.Load(url);

            var xmlQuery = from item in xElement.Descendants("data")
                           select item;

            foreach (var item in xmlQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
}
