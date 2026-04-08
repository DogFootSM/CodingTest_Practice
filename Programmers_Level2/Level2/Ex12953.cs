namespace Level2;

/// <summary>
/// 날짜 : 2026.03.25
/// 문제 : N개의 최소 공배수
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12953
/// </summary>
public class Ex12953
{
    public int solution(int[] arr) {
        int answer = 1;
        
        bool[] primes = new bool[101];
        
        for(int i = 2; i * i <= 101; i++)
        {
            if(!primes[i])
            {
                for(int j = i * i; j <= 101; j += i)
                {
                    primes[j] = true;
                } 
            }
        }
        
        int[] st = new int[101];
            
        for(int i = 0; i < arr.Length; i++)
        { 
            int temp = arr[i];
            int[] stTemp = new int[101];
            
            while(temp > 1)
            {
                for(int j = 2; j < primes.Length; j++)
                {
                    if(!primes[j] && temp % j == 0)
                    {
                        stTemp[j]++;
                        
                        if(st[j] < stTemp[j])
                        {
                            st[j] = stTemp[j];
                        }
                        
                        temp /= j;
                        break;
                    }  
                } 
            }
             
        }
        
        for(int i = 2; i < st.Length; i++)
        {
            if(st[i] != 0)
            {
                int temp = (int)Math.Pow(i, st[i]); 
                answer *= temp;
            }
        }
        
        
        return answer;
    } 
}