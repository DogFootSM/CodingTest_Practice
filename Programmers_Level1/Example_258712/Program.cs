using System;
using System.Collections.Generic;


/// <summary>
/// 날짜 : 2026.03.10
/// 문제 : 가장 많이 받은 선물
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/258712
/// </summary>
public class PresentInfo
{
    public int presentIndex = 0;
    public int giftToReceive = 0;
    
    public Dictionary<string, int> toGiftList = new Dictionary<string, int>();
}

public class Solution {
    public int solution(string[] friends, string[] gifts) {
        int answer = 0;
        
        Dictionary<string, PresentInfo> friendDict = new Dictionary<string, PresentInfo>();
        
        for(int i = 0; i < friends.Length; i++)
        {
            friendDict.TryAdd(friends[i], new PresentInfo());
            
            for(int j = 0; j < friends.Length; j++)
            {
                if(i == j) continue;
                friendDict[friends[i]].toGiftList.Add(friends[j], 0);
            } 
        }
        
        for(int i = 0; i < gifts.Length; i++)
        {
            string[] temps = gifts[i].Split(" ");
            friendDict[temps[0]].toGiftList[temps[1]]++;
            friendDict[temps[0]].presentIndex++;
            friendDict[temps[1]].presentIndex--;
        } 
        
        foreach(var my in friendDict)
        {
            foreach(var to in my.Value.toGiftList)
            {
                if(to.Value > friendDict[to.Key].toGiftList[my.Key])
                {
                    my.Value.giftToReceive++;
                }
                else if(to.Value < friendDict[to.Key].toGiftList[my.Key])
                {
                    friendDict[to.Key].giftToReceive++;
                }
                else
                {
                    if(my.Value.presentIndex > friendDict[to.Key].presentIndex)
                    {
                        my.Value.giftToReceive++;
                    }
                    else if(my.Value.presentIndex < friendDict[to.Key].presentIndex)
                    {
                        friendDict[to.Key].giftToReceive++;
                    }
                }
                
                friendDict[to.Key].toGiftList.Remove(my.Key);
            } 
        }
         
        foreach(var my in friendDict)
        {
            if(my.Value.giftToReceive > answer)
            {
                answer = my.Value.giftToReceive;
            }
        }
        
        return answer;
    }
}