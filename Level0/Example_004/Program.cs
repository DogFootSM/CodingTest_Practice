namespace Example_004
{
    /// <summary>
    /// 날짜 : 2024-08-05
    /// 문제 : 배열 뒤집기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120821
    /// </summary>
    public class Solution
    {
        public int[] solution(int[] num_list)
        {

            int[] answer = new int[num_list.Length];

            int reverse = num_list.Length - 1;

            for (int i = 0; i < num_list.Length; i++)
            {
                answer[i] = num_list[reverse--];
                 
            } 

            return answer;
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                int[] numList = { 1, 1, 1, 1, 1, 2 };

                Solution sol = new Solution();


                sol.solution(numList);
 



            }
        }
    }
}
