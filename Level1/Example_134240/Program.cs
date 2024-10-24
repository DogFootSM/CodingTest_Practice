using System.Collections;

namespace Example_134240
{

    /// <summary>
    /// 날짜 : 2024-10-25
    /// 문제 : 푸드 파이트 대회
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/134240
    /// </summary> 
    public class Solution
    {
        public string solution(int[] food)
        {
            string answer = "";

            //food 요소의 절반 만큼 i + 1 값을 붙임
            for (int i = 0; i < food.Length - 1; i++)
            {
                for (int j = 0; j < food[i + 1] / 2; j++)
                {
                    answer += (i + 1).ToString();
                }
            }

            //문자열을 char 배열에 할당 후 뒤집음
            char[] crr = answer.ToCharArray();
            Array.Reverse(crr);
            answer += "0";

            //뒤집은 문자를 문자열에 이어붙임
            for (int i = 0; i < crr.Length; i++)
            { 
                answer += crr[i].ToString();
            }

            return answer;
        }

    }
}