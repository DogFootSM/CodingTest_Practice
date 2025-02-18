
using System;
using System.Linq;

/// <summary>
/// 날짜 : 2025.02.19
/// 문제 : 체육복
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/42862#
/// </summary>
public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = n - lost.Length;
        
        Array.Sort(lost);
        Array.Sort(reserve);
        
        for(int i = 0; i < reserve.Length; i++)
        {
            for(int j = 0; j < lost.Length; j++)
            {
                //잃어버린 학생이면서 여벌을 가지고 있는 학생 처리
                if(reserve[i] == lost[j])
                {
                    reserve[i] = 0;
                    lost[j] = 0;
                    answer++;
                    break;
                } 
            }
        }
         
        for(int i = 0; i < reserve.Length; i++)
        {
            for(int j = 0; j < lost.Length; j++)
            {
                if(lost[j] == 0 || reserve[i] == 0) continue;
                  
                //현재 학생 기준 -1, +1 값일 경우 빌려줌
                if(((reserve[i] == lost[j] - 1) || (reserve[i] == lost[j] + 1)))
                {
                    answer++;
                    lost[j] = 0;
                    reserve[i] = 0;
                    break;
                }
                
            }
        }
         
        return answer;
    }
}