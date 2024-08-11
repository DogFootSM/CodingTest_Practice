namespace Example_048
{

    /// <summary>
    /// 날짜 : 2024-08-11
    /// 문제 : 숨어있는 숫자의 덧셈 (2)
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120864
    /// </summary>
    public class Solution
    {
        public int solution(string my_string)
        {
            int answer = 0;
            string temp = "0";
            List<int> list = new List<int>();

            for (int i = 0; i < my_string.Length; i++)
            {

                if (char.IsNumber(my_string[i]) && i != my_string.Length)
                {
                    temp += string.Concat(my_string[i]);
                }

                if (!char.IsNumber(my_string[i]) || i == my_string.Length - 1)
                {
                    list.Add(int.Parse(temp));
                    temp = "0";
                }
            }

            foreach (int i in list)
            {
                answer += i;
            }


            return answer;
        }
    }
}
