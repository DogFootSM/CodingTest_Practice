namespace Example_12910
{
    using System.Collections.Generic;


    /// <summary>
    /// 날짜 : 2024-10-14
    /// 문제 : 나누어 떨어지는 숫자 배열
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12910
    /// </summary>
    public class Solution
    {
        public int[] solution(int[] arr, int divisor)
        {
            int[] answer;
            List<int> list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                //나누어 떨어지는 수 검사
                if (arr[i] % divisor == 0)
                {
                    list.Add(arr[i]);
                }
            }

            //나누어 떨어지는 숫자가 없었을 경우 -1 추가
            if (list.Count == 0)
            {
                list.Add(-1);
            }

            answer = list.ToArray();

            //배열을 순회하며 오름차순 정렬
            for (int i = 0; i < answer.Length; i++)
            { 
                for (int j = 0; j < (answer.Length - 1) - i; j++)
                { 
                    if (answer[j] > answer[j + 1])
                    {
                        int temp = answer[j];
                        answer[j] = answer[j + 1];
                        answer[j + 1] = temp;

                    }
                }
            } 
            return answer;
        }
    }
}
