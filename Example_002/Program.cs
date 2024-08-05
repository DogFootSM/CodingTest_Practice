namespace Example_002
{
    /// <summary>
    /// 날짜 : 2024-08-05
    /// 문제 : Lv.0 양꼬치 가격 구하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120830
    /// </summary>
    public class Solution
    {
        public int solution(int n, int k)
        {
            int answer = 0;
            int service = n / 10;
            k -= service;

            answer = (n * 12000) + (k * 2000);

            return answer;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
             
        }
    }
}
