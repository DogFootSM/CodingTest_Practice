using System.Diagnostics;
using System.Text;

/// <summary>
/// 날짜 : 2026.02.23
/// 문제 : 숫자 짝꿍
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/131128
/// </summary>
public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        StringBuilder sb = new StringBuilder();
        
        int[] xNumbers = new int[10];
        int[] yNumbers = new int[10]; 
        
        for(int i = 0; i < X.Length; i++)
        {
            xNumbers[(int)X[i] - 48]++;
        }
        
        for(int i = 0; i < Y.Length; i++)
        {
            yNumbers[(int)Y[i] - 48]++;
        }
        
        for(int i = 9; i >= 0; i--)
        {
            for(int j = 0; xNumbers[i] > 0 && yNumbers[i] > 0; j++)
            {
                sb.Append(i);
                xNumbers[i]--;
                yNumbers[i]--;
            }
        }
        
        answer = sb.ToString();
         
        if(answer.Equals(""))
        {
            answer = "-1";
        }
        else if(answer[0].Equals('0'))
        {
            answer = "0";
        }
        
        return answer;
    }
    
}