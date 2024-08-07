namespace Example_023
{

    /// <summary>
    /// 날짜 : 2024-08-07
    /// 문제 : 세균 증식
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120910
    /// </summary>

    public class Solution
    {
        public int solution(int n, int t)
        {

            for (int i = 0; i < t; i++) n *= 2;
            //int answer = n << t;
            //정확히 2배씩 증가하기 때문에 부호 비트 사용해서 풀이도 가능

            return n;
        }
    }
}
