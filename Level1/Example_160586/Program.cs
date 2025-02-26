

/// <summary>
/// 날짜 : 2025.02.26
/// 문제 : 대충 만든 자판
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/160586
/// </summary>
public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        
        int tempIndex = 9999;
        
        for(int i = 0; i < targets.Length; i++)
        {
            int count = 0;
            for(int j = 0; j < targets[i].Length; j++)
            {
                for(int k = 0; k < keymap.Length; k++)
                {
                    int indexOf = keymap[k].IndexOf(targets[i][j]);

                    if (indexOf > -1 && tempIndex > indexOf)
                    {
                        tempIndex = (keymap[k].IndexOf(targets[i][j]) + 1); 
                    } 
                }
                
                count += tempIndex;
                if(count >= 9999) break;
                
                tempIndex = 9999;
            }
            
            answer[i] = count >= 9999 ? -1 : count;
        }
         
        return answer;
    }
}