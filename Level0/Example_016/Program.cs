namespace Example_016
{
    public class Solution
    {

        /// <summary>
        /// 날짜 : 2024-08-06
        /// 문제 : 최고값 및 인덱스 구하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120899
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] solution(int[] array)
        {

            int[] answer = new int[2];

            answer[0] = array.Max();
            answer[1] = Array.IndexOf(array, array.Max());

            //메서드 활용 없이 계산
            //int[] arr = [1, 6, 8, 3, 2, 5];
            //int[] ans = new int[2];
            //int max = 0;
            //int index = 0;


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //        index = i;
            //    }
            //}


            return answer;
        }
    }
    
}
