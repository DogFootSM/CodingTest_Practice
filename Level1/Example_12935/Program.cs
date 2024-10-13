namespace Example_12935
{

    /// <summary>
    /// 날짜 : 2024-10-14
    /// 문제 : 제일 작은 수 제거하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12935
    /// </summary>
    public class Solution
    {
        public int[] solution(int[] arr)
        {

            int[] answer;

            //배열에 들어있는 값이 1개이면 -1 반환
            if (arr.Length == 1)
            {
                answer = new int[1];
                answer[0] = -1;
                return answer;
            }

            List<int> list = new List<int>();

            //arr 배열을 list로 변환
            list = arr.ToList();

            //list에서 가장 작은 값 제거
            list.Remove(list.Min());

            //list > int 배열로 변환
            answer = list.ToArray();
             
            return answer;
        }
    }
}
