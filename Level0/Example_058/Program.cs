namespace Example_058
{

    /// <summary>
    /// 날짜 : 2024-08-16
    /// 문제 : 문자열 잘라서 배열로 저장하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120913
    /// </summary>
    public class Solution
    {
        public string[] solution(string my_str, int n)
        {

            double dou = (double)my_str.Length / n;
            int index = (int)Math.Ceiling(dou);

            string[] answer = new string[index];

            for (int i = 0; i < index; i++)
            {

                if (my_str.Length < n)
                {
                    answer[i] = my_str.Substring(0, my_str.Length);
                }
                else
                {
                    answer[i] = my_str.Substring(0, n);
                    my_str = string.Concat(my_str.Remove(0, n));
                } 
            } 
            return answer;
        }
    }
}
