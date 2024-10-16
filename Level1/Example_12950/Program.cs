﻿namespace Example_12950
{

    /// <summary>
    /// 날짜 : 2024-10-14
    /// 문제 : 행렬의 덧셈
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12950
    /// </summary>
    public class Solution
    {
        public int[,] solution(int[,] arr1, int[,] arr2)
        {
            int[,] answer = new int[arr1.GetLength(0), arr1.GetLength(1)];

            for (int y = 0; y < arr1.GetLength(0); y++)
            {
                for (int x = 0; x < arr1.GetLength(1); x++)
                {
                    answer[y, x] = arr1[y, x] + arr2[y, x];
                }
            }
            return answer;
        }
    }
}
