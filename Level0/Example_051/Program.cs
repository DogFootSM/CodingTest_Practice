using System.Text;

namespace Example_051
{


    /// <summary>
    /// 날짜 : 2024-08-11
    /// 문제 : 한 번만 등장한 문자
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120896
    /// </summary>
    public class Solution
    {
        public string solution(string s)
        {

            char[] arr = s.ToCharArray();   //문자열을 한 개씩 잘라서 문자 배열에 저장
            int count = 0;
            Array.Sort(arr);                //문자 배열을 한번 정렬
            string answer = "";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = 0; j < arr.Length; j++)
                {

                    //자기 자신을 제외한 동일한 문자가 있을 경우 카운트 증가
                    if (arr[i].Equals(arr[j]) && i != j)
                    {
                        count++;
                    }
                }

                //동일한 문자가 없었을 경우 sb에 해당 문자를 저장
                if (count == 0)
                {
                    sb.Append(arr[i]);
                }
                count = 0;
            }

            //중복되지 않는 문자가 없었을 경우 공백 문자 저장
            if (sb.Length == 0)
            {
                sb.Append("");
            }

            answer = sb.ToString();

            return answer;
        }
    }
}
