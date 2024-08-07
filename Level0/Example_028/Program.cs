namespace Example_028
{


    public class Solution
    {
        /// <summary>
        /// 날짜 : 2024-08-07
        /// 문제 : 배열 원소의 길이
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120854
        /// </summary>
        public int[] solution(string[] strlist)
        {
            int[] answer = new int[strlist.Length];

            for (int i = 0; i < strlist.Length; i++)
            {
                answer[i] = strlist[i].Count();

            }

            return answer;
        }
    }
}
