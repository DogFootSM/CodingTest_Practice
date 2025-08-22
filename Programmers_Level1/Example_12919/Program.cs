namespace Example_12919
{

    /// <summary>
    /// 날짜 : 2024-10-13
    /// 문제 : 서울에서 김서방 찾기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12919
    /// </summary>
    public class Solution
    {
        public string solution(string[] seoul)
        {
            string answer = "";

            for (int i = 0; i < seoul.Length; i++)
            {

                if (seoul[i] == "Kim")
                {
                    answer = "김서방은 " + i.ToString() + "에 있다";
                }
            }

            return answer;
        }
    }
}
