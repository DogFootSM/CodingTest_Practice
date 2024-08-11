namespace Example_053
{
    /// <summary>
    /// 날짜 : 2024-08-11
    /// 문제 : 7의 개수
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120912
    /// </summary>
    public class Solution
    {
        public int solution(int[] array)
        {
            int answer = 0;
            string temp = "";

            for (int i = 0; i < array.Length; i++)
            {
                temp = array[i].ToString();
                for (int j = 0; j < temp.Length; j++)
                {
                    if (int.Parse(temp[j].ToString()) == 7)
                    {
                        answer++;
                    } 
                }
            }

            return answer;
        }
    }
}
