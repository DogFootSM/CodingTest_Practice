using System;
using System.Text;
using System.Collections.Generic;

/// <summary>
/// 날짜 : 2026.02.26
/// 문제 : 개인정보 수집 유효기간
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/150370
/// </summary>
public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        Dictionary<string, int> termsDict = new Dictionary<string, int>();
        List<int> temps = new List<int>();
        
        for(int i = 0; i < terms.Length; i++)
        {
            termsDict.TryAdd(terms[i].Split(" ")[0], int.Parse(terms[i].Split(" ")[1]));
        }
        
        DateTime todayDate = DateTime.Parse(today);
        todayDate = todayDate.AddDays(-DateTime.DaysInMonth(todayDate.Year, todayDate.Month) % 28);

        for(int i = 0; i < privacies.Length; i++)
        {
            int addMonth = termsDict[privacies[i][privacies[i].Length - 1].ToString()];
            
            DateTime privaciesDate = DateTime.Parse(privacies[i].Split(" ")[0]);
            privaciesDate = privaciesDate.AddMonths(addMonth);
            privaciesDate = privaciesDate.AddDays(-DateTime.DaysInMonth(privaciesDate.Year, privaciesDate.Month) % 28);
          
            TimeSpan cal = todayDate - privaciesDate;

            if (cal.Days >= 0)
            {
                temps.Add(i + 1);
            }
        }
         
        return temps.ToArray();
    }
}