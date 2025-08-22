namespace Example_022
{
    public class Solution
    {
        /// <summary>
        /// 날짜 : 2024-08-06
        /// 문제 : 최댓값 만들기(2)
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120862#
        /// </summary>
        public int solution(int[] numbers)
        {

            int max = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    //요소가 2개일 때
                    //Max의 초기값 0이 변하지 않는 것을 방지
                    if (numbers.Count() < 3)
                    {
                        max = numbers.Where(x => x < 0).Count() <= 1 ? numbers[i] * numbers[j] : -1;
                    }

                    if (numbers[i] * numbers[j] > max)
                    {
                        max = numbers[i] * numbers[j];
                    }
                } 
            } 
            return max; 
        }
    }
}
