namespace Example_004
{

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
