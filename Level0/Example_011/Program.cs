using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Example_011
{

    /// <summary>
    /// 날짜 : 2024-08-05
    /// 문제 : 개미 군단
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120837
    /// </summary>
    public class Solution
    {
        public int solution(int hp)
        {
            int generalAnt = 5;
            int soldierAnt = 3;
            int workAnt = 1;

            int totalCount = 0;

            totalCount += hp / generalAnt;

            totalCount += ((hp % generalAnt) / soldierAnt);

            totalCount += ((hp % generalAnt) % soldierAnt) / workAnt;

            return totalCount;
        }
    }
}
