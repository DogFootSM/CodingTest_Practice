
/// <summary>
/// 날짜 : 2026.02.24
/// 문제 : 바탕화면 정리
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/161990#
/// </summary>
public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[4];
        int lux = int.MaxValue;
        int luy = int.MaxValue;
        int rdx = int.MinValue;
        int rdy = int.MinValue;
        
        for(int i = 0; i < wallpaper.Length; i++)
        {
            if(wallpaper[i].Contains("#"))
            {
                if(i < luy)
                {
                    luy = i;
                }
                
                rdy = i + 1;
            }
            for(int j = 0; j < wallpaper[i].Length; j++)
            {
                if(wallpaper[i][j] == '#')
                {
                    if(j < lux)
                    {
                        lux = j;
                    }
                    
                    if(j >= rdx){
                        rdx = j + 1;
                    }
                }
            } 
        } 
        
        answer[0] = luy;
        answer[1] = lux;
        answer[2] = rdy;
        answer[3] = rdx;

        return answer;
    }
}