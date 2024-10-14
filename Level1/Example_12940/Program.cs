namespace Example_12940
{

    /// <summary>
    /// 날짜 : 2024-10-14
    /// 문제 : 최대공약수와 최소공배수
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12940
    /// </summary>
    public class Solution
    {
        public int[] solution(int n, int m)
        {
            int[] answer = new int[2]; 

            //최대공약수
            int gcd = 1;

            //최소공배수
            int lcm = 1;
            int x = 2;

            while (true)
            {
                //나누어 떨어지지 않을 떄 까지 나누기 진행
                if (n % x == 0 && m % x == 0)
                {
                    n /= x;
                    m /= x;

                    //공약수들을 누적
                    gcd *= x;
                    lcm *= x;
                }
                else
                {
                    x++;
                    
                    //더 이상 나눌 수 없을 때
                    if (n / x < 1 && m / x < 1)
                    {
                        //누적된 공약수 값에 나머지 값을 곱셈
                        lcm *= (n * m); 
                        break;
                    }
                }
            }
            answer[0] = gcd;
            answer[1] = lcm;

            return answer;
        }
    }
}
