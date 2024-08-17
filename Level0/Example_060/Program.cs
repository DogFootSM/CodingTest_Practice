namespace Example_060
{


    /// <summary>
    /// 날짜 : 2024-08-18
    /// 문제 : 문자열 계산하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120902
    /// </summary>

    public class Solution
    {
        public int solution(string my_string)
        {

            int answer = 0;
            bool check = false;

            string[] arr = my_string.Split(" ").ToArray();

            for (int i = 0; i < arr.Length; i++)
            {

                if (i == 0)
                {
                    answer += int.Parse(arr[0]);
                }
                else
                {

                    check = int.TryParse(arr[i], out int temp);

                    if (check && arr[i - 1] == "+")
                    {
                        answer += temp;
                    }
                    else
                    {
                        answer -= temp;
                    }
                }
            } 
            return answer;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {


            string my_string = "-20 - 15 + 4";

            int answer = 0;
             
            string[] arr = my_string.Split(" ").ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    answer += int.Parse(arr[0]);
                }
                else
                { 
                    if (arr[i - 1] == "+")
                    {
                        answer += int.Parse(arr[i]);
                    }
                    else if (arr[i - 1] == "-")
                    {
                        answer -= int.Parse(arr[i]);
                    }
                }
            } 
        }
    }
}
