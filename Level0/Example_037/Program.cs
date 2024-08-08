namespace Example_037
{
    /// <summary>
    /// 날짜 : 2024-08-08
    /// 문제 : 숫자 찾기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120904
    /// </summary> 
    public class Solution
    {
        public int solution(int num, int k)
        {

            char[] crr = num.ToString().ToCharArray();
            int answer = 0;

            for (int i = 0; i < crr.Length; i++)
            {

                if ((int)(crr[i] - 48) == k)
                {

                    answer = i + 1;
                    break;
                }

                else
                {
                    answer = -1;

                } 
            } 
            return answer;
        }
    }
}
