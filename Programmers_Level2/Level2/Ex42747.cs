namespace Level2;

/// <summary>
/// 날짜 : 2026-04-13
/// 문제 : H-Index
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/42747
/// </summary>
public class Ex42747
{
    public int solution(int[] citations) {
        int answer = 0;
        Array.Sort(citations, (a, b) => b.CompareTo(a));
    
        for(int i = 0; i < citations.Length; i++)
        {
            if(citations[i] > i)
            {
                answer = i + 1;
            }
        }
        
        
        return answer;
    }
}