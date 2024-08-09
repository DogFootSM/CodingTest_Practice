using System.Text;

namespace Example_039
{


    /// <summary>
    /// 날짜 : 2024-08-09
    /// 문제 : 문자열 정렬하기 (1)
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120850
    /// </summary>
    public class Solution
    {
        public int[] solution(string my_string)
        {

            int[] answer;

            List<int> list = new List<int>();

            for (int i = 0; i < my_string.Length; i++)
            {

                if (char.IsNumber(my_string[i]))
                {
                    list.Add(int.Parse(my_string[i].ToString()));

                }

            }
            list.Sort();
            answer = list.ToArray();


            return answer;
        }

        static void Main(string[] args)
        {
             
        }

    }
}
