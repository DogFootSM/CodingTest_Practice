namespace Example_031
{

    /// <summary>
    /// 날짜 : 2024-08-07
    /// 문제 : 최대값 만들기(1)
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120847
    /// </summary>
    public class Solution
    {
        public int solution(int[] numbers)
        {
            int max = numbers.Max();
            int two = 0;
            int index = Array.IndexOf(numbers, max);


            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] > two && i != index)
                {
                    two = numbers[i];
                }

            }


            return max * two;
        }
    }
}
