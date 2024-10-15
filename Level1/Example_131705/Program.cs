namespace Example_131705
{

    /// <summary>
    /// 날짜 : 2024-10-15
    /// 문제 : 삼총사
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/131705
    /// </summary>
    public class Solution
    {
        public int solution(int[] number)
        {
            int answer = 0;

            //첫 번째 수
            for (int i = 0; i < number.Length; i++)
            {
                //두 번쨰 수
                for (int j = i + 1; j < number.Length; j++)
                {
                    //세 번째 수
                    for (int k = j + 1; k < number.Length; k++)
                    {
                        //1,2,3 자리의 수를 더한 값이 0이면 개수 증가
                        if (number[i] + number[j] + number[k] == 0)
                        {
                            answer++;
                        } 
                    } 
                } 
            } 
            return answer;
        }
    }
}
