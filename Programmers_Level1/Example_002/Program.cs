using System.Diagnostics;

namespace Example_002
{

    /// <summary>
    /// 날짜 : 2024-08-29
    /// 문제 : 하샤드 수
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12947
    /// </summary>
    public class Solution
    {
        public bool solution(int x)
        {
            char[] arr = x.ToString().ToCharArray();

            int[] numArr = new int[arr.Length];
            int sum = 0;

            foreach (int i in arr)
            {
                sum += (i - 48);
            }

            bool answer = x % sum == 0 ? true : false;

            return answer;

        }
    }
}
