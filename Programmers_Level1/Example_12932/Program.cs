namespace Example_12932
{
    /// <summary>
    /// 날짜 : 2024-10-06
    /// 문제 : 자연수 뒤집어 배열로 만들기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12932
    /// </summary>
    public class Solution
    {
        public long[] solution(long n)
        {

            long[] answer;
            List<long> arr = new List<long>();

            while (n > 0)
            {

                arr.Add(n % 10);
                n /= 10;
            }

            answer = arr.ToArray();

            return answer;
        }
    }
}
