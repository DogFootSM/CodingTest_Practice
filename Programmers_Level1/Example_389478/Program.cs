using System;
using System.Collections.Generic;

/// <summary>
/// 날짜 : 2026.03.09
/// 문제 : 택배 상자 꺼내기
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/389478
/// </summary>
public class Solution {
    public int solution(int n, int w, int num) {
        Dictionary<int, Stack<int>> dicts = new Dictionary<int, Stack<int>>();
        int answer = 0;
        
        for(int i = 0; i < w; i++)
        {
            dicts.TryAdd(i, new Stack<int>());
        }
        
        for(int i = 0; i < n; i++)
        {
            //몫이 홀수이면 방향이 바뀜
            if((i / w) % 2 != 0)
            {
                dicts[w - (i % w) - 1].Push(i + 1);  
            }
            else
            {
                dicts[i % w].Push(i + 1);
            }            
        }
        
        int key = (num - 1) / w % 2 == 0 ? (num - 1) % w : w - ((num - 1) % w) - 1;
        
        foreach(var box in dicts[key])
        {
            answer++;
            if(box == num)
            {
                break;
            } 
        }
        
        
        return answer;
    }
}