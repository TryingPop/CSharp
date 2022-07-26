/* 날짜 : 2022.07.26
 * 내용 : 코드 9-1
 * 
 * 기본 클래스와 자료 생성
 */

namespace Book.Ch09
{
    internal class ex01
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return String.Format("{0} : {1}원", this.Name, this.Price);
            }
        }

        static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product() { Name = "고구마", Price = 1500 },
                new Product() { Name = "사과", Price = 2400 },
                new Product() { Name = "바나나", Price = 1000 },
                new Product() { Name = "배", Price = 3000 }
            };
            // 정렬 기준이 없어 에러뜬다
            // list.Sort();

            foreach (Product item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
