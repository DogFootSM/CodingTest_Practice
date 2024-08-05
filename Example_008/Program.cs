namespace Example_008
{

    /// <summary>
    /// 날짜 : 2024-08-05
    /// 문제 : 구매 가능한 커피와 잔돈 구하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120819
    /// </summary>
    public class Solution
    {
        public int[] solution(int money)
        {
            int[] answer = new int[2];

            answer[0] = money / 5500;
            answer[1] = money % 5500;
             
            return answer;
        }
    }
     
}
