namespace Level2;

/// <summary>
/// 날짜 : 2026.03.12
/// 문제 : 카펫
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/42842
/// </summary>
public class Ex42842
{
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        
        int size = brown + yellow;
        
        for(int i = 3; i * i <= size; i++)
        {
            //w 전체 가로 길이
            int w = size / i;
            
            //yHeight 전체 높이
            int yWidth = w - 2;
            int yHeight = (yellow / yWidth) + 2;
             
            if(yellow % yWidth == 0 && i == yHeight)
            {
                answer[0] = w; 
                answer[1] = yHeight;
                break;
            } 
        } 
        return answer;
    }
}