namespace Level2;


/// <summary>
/// 날짜 : 2026.03.23
/// 문제 : 점프와 순간이동
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12980
/// </summary>
class Solution
{
    public int solution(int n)
    {
        int answer = 0; 
        
        while(n >= 1)
        {
            if(n % 2 == 1) answer++;
            n /= 2;
        }
        
        return answer;
    }
}