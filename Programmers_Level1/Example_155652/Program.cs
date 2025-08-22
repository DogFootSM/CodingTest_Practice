// See https://aka.ms/new-console-template for more information

/// <summary>
/// 날짜 : 2025.02.25
/// 문제 : 둘만의 암호
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/155652#
/// </summary>
public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        
        char[] sToCharArr = s.ToCharArray();
        char[] skipToCharArr = skip.ToCharArray();
        List<char> charList = new List<char>();

        for (int i = 0; i < 26; i++)
        {
            if (skipToCharArr.Contains((char)(97 + i))) continue;
            
            charList.Add((char)(97 + i)); 
        }

        for (int i = 0; i < sToCharArr.Length; i++)
        {
            int skipIndex = charList.IndexOf(sToCharArr[i]);

            if (skipIndex + index >= charList.Count)
            {
                skipIndex =  (skipIndex + index) % charList.Count;
            }
            else
            {
                skipIndex = skipIndex + index;
            }
            sToCharArr[i] = charList[skipIndex]; 
        }
        
        answer = string.Join("", sToCharArr);
        
        return answer;
    }
}