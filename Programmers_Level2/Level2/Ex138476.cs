namespace Level2;

/// <summary>
/// 날짜 : 2026.03.21
/// 문제 : 귤 고르기
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/138476
/// </summary>
public class Ex138476 
{
    public int Solution(int k, int[] tangerine) {
        
        int answer = 0;
        var groups = tangerine.GroupBy(x => x);
        
        int[] arr = groups.Select(x => x.Count()).ToArray();
        
        Array.Sort(arr, (a, b) => b.CompareTo(a));
        
        for(int i = 0; i < arr.Length; i++)
        {
            k -= arr[i];
            answer++;
            if(k <= 0) return answer;
        }
        
        
        return -1;
    }
}