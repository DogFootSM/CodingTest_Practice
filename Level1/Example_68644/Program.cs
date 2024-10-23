using System.Linq;

namespace Example_68644
{

    /// <summary>
    /// 날짜 : 2024-10-23
    /// 문제 : 두 개 뽑아서 더하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/68644
    /// </summary>
    public class Solution
    {
        public int[] solution(int[] numbers)
        {
            int[] answer;
            List<int> temp = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (!temp.Contains(numbers[i] + numbers[j]))
                    {
                        temp.Add(numbers[i] + numbers[j]); 
                    } 
                } 
            }

            temp.Sort();
            answer = temp.ToArray();
             
            return answer;
        }
    }
}
