namespace Level2;

/// <summary>
/// 날짜 : 2026.04.02
/// 문제 : 할인 행사
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/131127
/// </summary>
public class Ex131127
{
    public int solution(string[] want, int[] number, string[] discount) {
        int answer = 0;
        bool canJoin = false;        
        
        Dictionary<string, int> wants = new Dictionary<string, int>();
        int [][] weeks = new int[discount.Length - 9][];
        
        for(int i = 0; i < want.Length; i++)
        {
            wants.TryAdd(want[i], i);
        }
        
        for(int i = 0; i < discount.Length - 9; i++)
        {
            weeks[i] = new int[want.Length];
            
            for(int j = i; j < (i + 10) && j < discount.Length; j++)
            { 
                canJoin = false;
                if(!wants.ContainsKey(discount[j])) break;
                if(weeks[i][wants[discount[j]]] >= number[wants[discount[j]]]) break;
                canJoin = true;
                weeks[i][wants[discount[j]]]++;
            }
            
            if(canJoin) answer++;
        }
        
        return answer;
    }
}