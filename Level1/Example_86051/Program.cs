namespace Example_86051
{

    /// <summary>
    /// 날짜 : 2024-10-14
    /// 문제 : 없는 숫자 더하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/86051
    /// </summary>
    public class Solution
    {
        public int solution(int[] numbers)
        {
            int answer = 45;
             
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (numbers[i] == j)
                    {
                        answer -= numbers[i];
                    }
                }
            }

            return answer;
        }
    }
}
