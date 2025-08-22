namespace Example_12912
{

    /// <summary>
    /// 날짜 : 2024-10-13
    /// 문제 : 두 정수 사이의 합
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12912
    /// </summary>
    public class Solution
    {
        public long solution(int a, int b)
        {
            long answer = 0;
            int temp = 0;

            //a의 값이 b보다 클 경우 교환
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            for (int i = a; i <= b; i++)
            { 
                answer += i; 
            } 
            return answer;
        }
    }
}
