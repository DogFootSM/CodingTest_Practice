namespace Example_42748
{

    /// <summary>
    /// 날짜 : 2024-10-24
    /// 문제 : K 번째 수
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/42748
    /// </summary>
    public class Solution
    {
        public int[] solution(int[] array, int[,] commands)
        {

            int[] answer = new int[commands.GetLength(0)];
            List<int> temp = new List<int>();

            for (int i = 0; i < commands.GetLength(0); i++)
            {
                int f = commands[i, 0] - 1;
                int l = commands[i, 1];

                for (int j = f; j < l; j++)
                {
                    temp.Add(array[j]);
                } 

                temp.Sort();
                answer[i] = temp[commands[i, 2] - 1];
                temp.Clear(); 
            } 
            return answer;
        }
    }
}
