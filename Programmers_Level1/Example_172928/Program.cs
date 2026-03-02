using System;
using System.Collections.Generic;


/// <summary>
/// 날짜 : 2026.03.22
/// 문제 : 공원 산책
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/172928#
/// </summary>
public class Solution {
    public int[] solution(string[] park, string[] routes) {
        Dictionary<string, int> directionDict = new Dictionary<string, int>()
        {
            {"E", 1},
            {"W", -1},
            {"N", -1},
            {"S", 1},
        };
        
        int[] answer = new int[] {};
        
        int xPos = 0;
        int yPos = 0;
        
        //시작 위치
        for(int i = 0; i < park.Length; i++)
        {
            for(int j = 0; j < park[i].Length; j++)
            {
                if(park[i][j] == 'S')
                {
                    yPos = i;
                    xPos = j;
                    break;
                }
            }
        }
         
        for(int i = 0; i < routes.Length; i++)
        {
            bool canMove = true;

            string[] route = routes[i].Split(" ");
            int count = int.Parse(route[1]);
            int move = directionDict[route[0]] * count; 
            
            if(route[0].Equals("W") || route[0].Equals("E"))
            {
                int moveX = xPos;
                 
                if(park[0].Length <= xPos + move || xPos + move < 0) continue;
                 
                for(int j = 0; j < count; j++)
                {
                    moveX += directionDict[route[0]];
                    
                    if(park[yPos][moveX].Equals('X'))
                    {
                        canMove = false;
                        break;
                    } 
                }
                
                if(canMove)
                {
                    xPos = moveX;
                }
            }
            else
            {
                int moveY = yPos;
                
                if(park.Length <= yPos + move || yPos + move < 0) continue;
                
                for(int j = 0; j < count; j++)
                {
                    moveY += directionDict[route[0]];

                    if(park[moveY][xPos].Equals('X'))
                    { 
                        canMove = false;
                        break;
                    }
                } 
                
                if(canMove)
                {
                    yPos = moveY;
                }
            } 
            
        }
    
        answer = new int[]{yPos, xPos};
        
        return answer;
    }
}