﻿using System.Text;

namespace Example_029
{
    /// <summary>
    /// 날짜 : 2024-08-07
    /// 문제 : 문자 반복 출력하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120825
    /// </summary>
    public class Solution
    {
        public string solution(string my_string, int n)
        {
            string answer = "";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    sb.Append(my_string[i]);
                }
            }
            answer = sb.ToString();


            return answer;
        }
    }
}
