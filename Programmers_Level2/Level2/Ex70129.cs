namespace Level2;

/// <summary>
/// 날짜 : 2025-08-26
/// 문제 : 이진 변환 반복하기
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/70129
/// </summary>
public class Ex70129
{
    public int[] solution(string s) {
        int[] answer = new int[2];
        int temp = 0;
        int changeCount = 0;
        int numCount = 0;
        int sNum = 0;
        
        while(s.Length > 1)
        {
            numCount = s.Where(x => x != '0').Count();
            
            if(s.Length - numCount >= 0)
            {
                temp += s.Length - numCount;
            }
            
            changeCount++;
            sNum = numCount;
            s = "";
            
            while(sNum >= 1)
            {
                s += sNum % 2;
                sNum /= 2;
            } 
        }
        
        answer[0] = changeCount;
        answer[1] = temp;
         
        return answer;
    }
}