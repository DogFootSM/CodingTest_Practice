

/// <summary>
/// 날짜 : 2026.02.20
/// 문제 : 소수찾기
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12921
/// </summary>
public class Example_12921
{
    public int solution(int n)
    {
        int answer = 0;
        
        bool[] primes = new bool[n + 1];

        for (int i = 2; i * i <= n; i++)
        {
            if (!primes[i])
            {
                for (int j = i * i; j <= n; j += i)
                {
                    primes[j] = true;
                }
            } 
        }

        for (int i = 2; i <= n; i++)
        {
            if (!primes[i]) answer++;
        }

        return answer;
    }
    
    // public int solution(int n)
    // {
    //     int answer = 0;
    //     
    //     for (int i = 2; i <= n; i++)
    //     {
    //         if (IsPrimeNumber(i)) answer++;
    //     }
    //
    //     return answer;
    // }
    //
    // public bool IsPrimeNumber(int number)
    // {
    //     for (int i = 2; i * i <= number; i++)
    //     {
    //         if (number % i == 0) return false;
    //     }
    //
    //     return true;
    // }
}