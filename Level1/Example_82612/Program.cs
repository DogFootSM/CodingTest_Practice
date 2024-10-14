namespace Example_82612
{

    /// <summary>
    /// 날짜 : 2024-10-14
    /// 문제 : 부족한 금액 계산하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/82612
    /// </summary>
    class Solution
    {
        public long solution(int price, int money, int count)
        { 
            long lMoney = money;
            long temp = price;
            long answer = 0;

            for (int i = 0; i < count; i++)
            { 
                lMoney -= temp;
                temp += price; 
            }

            if (lMoney >= 0)
            {
                return 0;
            }
            else
            { 
                answer = Math.Abs(lMoney);
            }

            return answer;

        }
    }
}
