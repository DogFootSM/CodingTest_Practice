namespace Level2;


/// <summary>
/// 날짜 : 2025-08-22
/// 문제 : JadenCase 문자열 만들기
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12951
/// </summary>
public class Ex12951
{
    public string solution(string s) {
        string answer = "";
        
        string[] sWords = s.Split(' ');
        
        for(int i = 0; i < sWords.Length; i++)
        {
            sWords[i] = sWords[i].ToLower();
            
            if(sWords[i].Length == 0) continue;
            if(int.TryParse(sWords[i][0].ToString(), out int num)) continue;
             
            string first = sWords[i][0].ToString().ToUpper();
            
            sWords[i] = first + sWords[i].Remove(0, 1);
        }
        
        for(int i = 0; i < sWords.Length; i++)
        {
            answer += sWords[i];
            
            if(i < sWords.Length - 1)
            {
                answer += " ";
            } 
        }
         
        return answer;
    }
}