using System.Diagnostics;

namespace Example_003
{

    /// <summary>
    /// 날짜 : 2024-08-29
    /// 문제 : 콜라츠 추측
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12943
    /// </summary>
    public class Solution
    {
        public int solution(int num)
        {
            int count = 0;
            long temp = num;


            while (temp != 1)
            {
                temp = temp % 2 == 0 ? temp / 2 : temp * 3 + 1;
                count++;

                if (count == 500)
                    return -1;
            }
            return count;
        }
    }
}

