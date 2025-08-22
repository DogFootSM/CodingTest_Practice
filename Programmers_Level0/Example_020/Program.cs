namespace Example_020
{

    public class Solution
    {

        /// <summary>
        /// 날짜 : 2024-08-06
        /// 문제 : 주사위 개수 구하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120845
        /// </summary> 
        public int solution(int[] box, int n)
        {
            int answer = 1;

            for (int i = 0; i < box.Length; i++)
            {

                answer *= (box[i] / n);
            } 
            return answer;
        }
    }
}
