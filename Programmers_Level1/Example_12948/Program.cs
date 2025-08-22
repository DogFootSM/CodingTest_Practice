namespace Example_12948
{
    /// <summary>
    /// 날짜 : 2024-10-14
    /// 문제 : 핸드폰 번호 가리기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12948
    /// </summary>
    public class Solution
    {
        public string solution(string phone_number)
        {
            string answer = "";

            for (int i = 0; i < phone_number.Length; i++)
            {
                answer += i < phone_number.Length - 4 ? string.Concat('*') : string.Concat(phone_number[i]);

            }


            return answer;
        }
    }
}
