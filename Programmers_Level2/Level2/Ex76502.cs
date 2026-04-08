namespace Level2;
using System.Text;
using System.Collections.Generic;
/// <summary>
/// 날짜 : 2026.04.07
/// 문제 : 괄호 회전하기
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/76502
/// </summary>
public class Ex76502
{
    public int solution(string s) {
        int answer = 0;
        StringBuilder sb = new StringBuilder(s);
        StringBuilder replaceSb = new StringBuilder();
        Stack<char> brackets = new Stack<char>(); 
        
        HashSet<string> pairs = new HashSet<string>();
        pairs.Add("[]");
        pairs.Add("{}");
        pairs.Add("()"); 
       
        for(int i = 0; i < sb.Length; i++)
        {  
            replaceSb.Clear();
            
            for(int k = 0; k < sb.Length; k++)
            {
                replaceSb.Append(sb[k]);
                
                if(replaceSb.Length > 1)
                {
                    string st = $"{replaceSb[replaceSb.Length - 2]}" + $"{replaceSb[replaceSb.Length - 1]}";
                    
                    if(pairs.Contains(st))
                    { 
                        replaceSb.Remove(replaceSb.Length - 2, 2);
                    }
                    
                }
            }
            
            if(replaceSb.Length == 0) answer++;
            
            char first = sb[0];
                
            for(int j = 1; j < sb.Length; j++)
            {
                sb[j - 1] = sb[j];
            }  
                
            sb[sb.Length - 1] = first;
        }
        
        
        return answer;
    }
}