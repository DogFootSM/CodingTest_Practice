using System.Text;

namespace Example_019
{
    internal class Program
    {
        /// <summary>
        /// 날짜 : 2024-08-06
        /// 문제 : 문자열 인덱스 바꾸기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120895
        /// </summary>
        static void Main(string[] args)
        {
            string my_string = "I love you";
            int num1 = 3;
            int num2 = 6;

            char[] charArray = my_string.ToCharArray();

            string answer = string.Create(my_string.Length, charArray, (Span<char> strArr, char[] charArr) =>
            {
                 
                for(int i =0; i < charArr.Length; i++)
                {
                    strArr[i] = charArr[i];
                }

                strArr[num1] = charArray[num2];
                strArr[num2] = charArray[num1];
            });

        }
    }
}
