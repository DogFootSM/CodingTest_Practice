

using System.Collections;

namespace Example_136798
{
    /// <summary>
    /// 날짜 : 2026.02.11
    /// 문제 : 기사단원의 무기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/136798
    /// </summary>
    public class Example_136798
    {
        public void solution(int number, int limit, int power)
        {
            int div = 0;
            int iron = 0;
            
            for (int i = 1; i <= number; i++)
            {
                div = GetDivNumber(i);

                if (div > limit)
                {
                    iron += limit;
                }
                else
                {
                    iron += div;
                }
            } 
        }

        private int GetDivNumber(int number)
        {
            int count = 0;

            for (int i = 1; i * i <= number; i++)
            {
                if (i * i == number)
                {
                    count++;
                }
                else if (number % i == 0)
                {
                    count += 2;
                }
            }

            return count;
        }
        
    }
}
