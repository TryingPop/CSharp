using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/* 날짜 : 2022.07.28
 * 내용 : 코드 12-12
 * 
 * 클래스를 활용한 Linq
 */

namespace Book.Ch12
{
    internal class ex12
    {
        static void Main12(string[] args)
        {
            // xml 크롤링
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            XElement xElement = XElement.Load(url);
            Console.WriteLine(xElement);
        }
    }
}
