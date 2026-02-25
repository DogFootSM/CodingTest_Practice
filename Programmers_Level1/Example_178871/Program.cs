using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 날짜 : 2026.02.25
/// 문제 : 달리기 경주
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/178871
/// </summary>
public class Solution {
    public string[] solution(string[] players, string[] callings) {
        
        Dictionary<string, int> playerDict = new Dictionary<string, int>();        
        int currentIndex = 0;
        
        for(int i = 0; i < players.Length; i++)
        {            
            playerDict.TryAdd(players[i], i);
        }
                
        for(int i = 0; i < callings.Length; i++)
        { 
            int changeIndex = 0;
            currentIndex = playerDict[callings[i]];
            
            var temp =  players[currentIndex];
            players[currentIndex] = players[currentIndex - 1];
            players[currentIndex - 1] = temp;
             
            playerDict[temp] = currentIndex - 1;
            playerDict[players[currentIndex]] = currentIndex;
        }
        
        return players;
    }
}