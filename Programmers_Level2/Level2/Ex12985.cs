namespace Level2;

/// <summary>
/// 날짜 : 2026.04.01
/// 문제 : 예상 대진표
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12985
/// </summary>
public class Ex12985
{
    public int solution(int n, int a, int b)
    {
        int answer = 0;
        
        while(true) 
        { 
            answer++;
          
            if(a % 2 == 0 && a - 1 == b)
            {
                return answer;
            }
            else if(a % 2 != 0 && a + 1 == b)
            {
                return answer;
            }
            
            a = a % 2 == 0 ? a / 2 : (a + 1) / 2;
            b = b % 2 == 0 ? b / 2 : (b + 1) / 2;
        } 
        return answer;
    }
}