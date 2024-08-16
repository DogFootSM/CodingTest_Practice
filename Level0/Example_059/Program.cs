namespace Example_059
{

    /// <summary>
    /// 날짜 : 2024-08-16
    /// 문제 : 공 던지기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120843
    /// </summary>
    public class Solution
    {
        public int solution(int[] numbers, int k)
        {
            int answer = 0;
            int count = 1;
            int index = 0;

            do
            {
                index += 2;     //우측으로 한칸 건너뜀

                //현재 인덱스가 배열의 길이를 벗어났다면 다시 앞으로 돌아가면서 순서를 건너뜀
                if (index > numbers.Length - 1) 
                {
                    index = index - numbers.Length;
                }

                answer = numbers[index];   
                ++count;

            } while (count < k);

            return answer;
        }
    }
}
