namespace Example_055
{
    /// <summary>
    /// 날짜 : 2024-08-16
    /// 문제 : 컨트롤 제트
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120853
    /// </summary>
    public class Solution
    {
        public int solution(string s)
        {

            string[] arr = s.Split(" ");
            int answer = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                //정수로 변환이 된 값들만 누적 합산
                if (int.TryParse(arr[i], out int temp))    
                {
                    answer += temp;

                }
                else
                {
                    //정수로 변환되지 못한 것을 만났을 때 이전 값을 뺌
                    answer += (-int.Parse(arr[i - 1]));
                } 
            } 
            return answer;

        }
    }
}
