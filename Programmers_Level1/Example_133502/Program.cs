using System;
using System.Collections.Generic;

/// <summary>
/// 날짜 : 2026.02.20
/// 문제 : 햄버거만들기
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/133502?language=csharp#
/// </summary>
public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        
        Stack<int> inStack = new Stack<int>();
        List<int> indexList = new List<int>();
        
        for(int i = 0; i < ingredient.Length; i++)
        {
            inStack.Push(ingredient[i]);
            
            if(inStack.Count > 3 && inStack.Peek() == 1)
            {
                indexList.Clear();
                int prevIngredient = 3;
                int index = i - 1;
                indexList.Add(i);
                
                for(int j = index; j >= 0; j--)
                {
                    if(ingredient[j] == prevIngredient)
                    {
                        prevIngredient--;
                        indexList.Add(j);

                        if(indexList.Count == 4)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if(ingredient[j] != 0)
                        {
                            break;
                        }
                    }
                }
                
                if(indexList.Count == 4)
                {
                    for(int k = 0; k < indexList.Count; k++)
                    {
                        ingredient[indexList[k]] = 0;
                    }
                    
                    answer++;
                }
            } 
        }
         
        return answer;
    }
}