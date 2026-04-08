namespace Level2;

/// <summary>
/// 날짜 : 2026.03.31
/// 문제 : 멀리뛰기
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12914
/// </summary>
public class Ex12914 {
    
    public long[] arr;
    
    public long solution(int n) {
        long answer = 0;
        arr = new long[n + 2];
        arr[1] = 1;
        arr[2] = 2;
        
        answer = T(n);        
        
        return answer;
    }
    
    public long T(long a)
    {
        if(a <= 1) return 1 % 1234567;
        if(a <= 2) return 2 % 1234567;
        
        if(arr[a] == 0)
        {
            arr[a] = T(a - 1) % 1234567 + T(a - 2) % 1234567;    
        }
        
        return arr[a] % 1234567;
    }
    
}