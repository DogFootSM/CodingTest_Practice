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

            double dou = (double)my_str.Length / n;     //문자열의 길이를 n개의 크기만큼 나눈 몫을 저장
            int index = (int)Math.Ceiling(dou);         //몫을 올림처리하여 배열의 인덱스 확보

            string[] answer = new string[index];

            for (int i = 0; i < index; i++)
            {

                if (my_str.Length < n)
                {
                    answer[i] = my_str.Substring(0, my_str.Length);     //남은 문자개수가 잘라야 할 크기보다 작을 경우 마지막까지 저장
                }
                else
                {
                    answer[i] = my_str.Substring(0, n);             //0 ~ n개까지 문자열 잘라서 저장
                    my_str = string.Concat(my_str.Remove(0, n));    //자른 문자열을 삭제
                } 
            } 
            return answer;
        }
    }
}
