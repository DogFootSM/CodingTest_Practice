namespace Level2;

/// <summary>
/// 날짜 : 2026.03.11
/// 문제 : 피보나치 수
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12945#
/// </summary>
public class Ex12945
{
    public static int[] fib;
        
    public int solution(int n) {
        fib = new int[n + 1];
        fib[0] = 0;
        fib[1] = 1;
        fib[2] = 1;
        
        int answer = Fibonachi(n);
         
        //다른 풀이
        //for (int i = 3; i <= n; i++)
        //{
        //    fib[i] = (fib[i - 1] + fib[i - 2]) % 1234567;
        //}
        
        //return fib[i];
        return answer;
    }
     
    public int Fibonachi(int n)
    {
        if(n <= 0) return 0;
        if(n <= 2) return 1;  
        
        if(fib[n] != 0)
        {
            return fib[n];
        }
             
        fib[n] = (Fibonachi(n - 1) + Fibonachi(n - 2)) % 1234567;
        
        return fib[n];
    }
}