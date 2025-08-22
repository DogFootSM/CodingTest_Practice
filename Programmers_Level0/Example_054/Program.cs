using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Example_054
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "10 20 30 40";
            int previousNumber = 0;
            int sum = 0;
            string sNumber = "";
            s = string.Concat(s.Split(""));

            //음수 숫자 케이스 생각해보기
            //공백을 만나기 전까지 sNumber 에 누적
            //공백을 만나면 sum에 저장
            //Z를 만나면 previousNumber에 저장된 값을 sum에서 빼기

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsNumber(s[i]))
                {
                    sNumber += string.Concat(s[i].ToString());

                }
                else
                {
                    sum += int.Parse(s[i].ToString());
                    previousNumber = int.Parse(s[i].ToString());

                    sum -= previousNumber;
                }
            }

            Console.WriteLine(sum);

        }
    }
}
