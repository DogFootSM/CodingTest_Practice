namespace Example_68935
{

    /// <summary>
    /// 날짜 : 2024-10-14
    /// 문제 : 3진법 뒤집기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/68935
    /// </summary>
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            List<int> list = new List<int>();

            while (true)
            {
                //3으로 나누어 떨어지지 않을 경우 몫을 리스트에 추가
                if (n / 3 == 0)
                {
                    list.Add(n);
                    break;
                }

                //3으로 나눈 나머지를 리스트에 저장
                list.Add(n % 3);
                n /= 3;
            }

            list.Reverse();

            for (int i = 0; i < list.Count; i++)
            {
                //3의 i승 만큼 나머지 곱해서 10진수로 변환
                answer += (list[i] * (int)Math.Pow(3, i));
            }


            return answer;
        }
    }
}
