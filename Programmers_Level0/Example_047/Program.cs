using System.Formats.Asn1;

namespace Example_047
{

    /// <summary>
    /// 날짜 : 2024-08-11
    /// 문제 : 역 팩토리얼
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120848
    /// </summary>
    public class Solution
    {
        public int solution(int n)
        { 
            int i = 2;
             
            int answer = Fact(n, i);

            return answer;
        }

        public int Fact(int n, int i)
        { 
            if (n == 1)
            {
                return 1;
            }

            if (n / i < i)
            {
                return i;
            } 
            return Fact((n / i), ++i);
        }

    }
}
