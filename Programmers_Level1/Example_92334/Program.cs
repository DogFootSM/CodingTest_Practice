using System;
using System.Collections.Generic;

/// <summary>
/// 날짜 : 2026.03.03
/// 문제 : 신고 결과 받기
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/92334
/// </summary>
public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int[] answer = new int[id_list.Length];
        Dictionary<string, HashSet<string>> reportCheck = new Dictionary<string, HashSet<string>>();
        
        Dictionary<string, int> myReportCount = new Dictionary<string, int>();
        
        for(int i = 0; i < id_list.Length; i++)
        {
            reportCheck.TryAdd(id_list[i], new HashSet<string>());
            myReportCount.TryAdd(id_list[i], 0);
        }
        
        for(int i = 0; i < report.Length; i++)
        {
            //각 유저가 다른 유저를 신고한 내역
            reportCheck[report[i].Split(" ")[0]].Add(report[i].Split(" ")[1]);
        }
        
        foreach(var rp in reportCheck)
        {
            foreach(var hash in rp.Value)
            {
                myReportCount[hash] += 1;
            }
        }
        
        foreach(var rp in myReportCount)
        {
            if(rp.Value >= k)
            {
                var key = rp.Key;
                
                for(int i = 0; i < id_list.Length; i++)
                {
                    if(reportCheck[id_list[i]].Contains(key))
                    {
                        answer[i] += 1;
                    } 
                }
            }
        }
        
        
        return answer;
    }
}