
/// <summary>
/// 날짜 : 2026.02.27
/// 문제 : 유연근무제
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/388351
/// </summary>
public class Solution {
    public int solution(int[] schedules, int[,] timelogs, int startday) {
        int answer = 0;
        int deadline = 0;
        
        for(int i = 0; i < schedules.Length; i++)
        {
            deadline = startday - 1;
            
            int schedule = schedules[i] + 10;
            
            int hour = ((schedule / 100) + (schedule % 100) / 60) * 100;
            int minute = (schedule % 100) % 60; 
            
            schedule = hour + minute;
            
            for(int j = 0; j < timelogs.GetLength(1); j++)
            {
                if(timelogs[i,j] > schedule)
                {
                    if(deadline < 5)
                    {
                        answer++;
                        break;
                    } 
                } 
                
                deadline = ++deadline % 7;
            }   
        }   
        
        return schedules.Length - answer;
    }
}