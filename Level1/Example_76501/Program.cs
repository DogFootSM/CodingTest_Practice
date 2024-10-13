namespace Example_76501
{

    /// <summary>
    /// 날짜 : 2024-10-13
    /// 문제 : 음양 더하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/76501
    /// </summary>
    public class Solution
    {
        public int solution(int[] absolutes, bool[] signs)
        {
            int answer = 0;

            for (int i = 0; i < absolutes.Length; i++)
            {

                answer += signs[i] ? absolutes[i] : -absolutes[i];

            }
             
            return answer;
        }
    }
}
