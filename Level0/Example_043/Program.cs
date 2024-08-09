using System.Text;

namespace Example_043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //중복 문자 제거
            string my_string = "We are the world";
            string answer = string.Concat(my_string.Distinct());


            Console.WriteLine(answer);

        }
    }
}
