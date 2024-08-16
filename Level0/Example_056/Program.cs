namespace Example_056
{

    /// <summary>
    /// 날짜 : 2024-08-16
    /// 문제 : 소인수분해
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120852
    /// </summary>
    public class Solution
    {
        public int[] solution(int n)
        {

            HashSet<int> set = new HashSet<int>();
            int[] arr;

            for (int i = 2; i <= n; i++)
            {
                //i를 n과 나눴을 때 나머지가 0인 것을 저장
                if (n % i == 0)
                {
                    n /= i;         //한 번 나눈 후 몫으로 n 값을 변환
                    set.Add(i);     //hashset 에 i 값을 저장
                    i--;            //i의 값으로 한 번더 나눌 수 있는지 확인하기 위해 i값 감소
                }
            }

            arr = set.ToArray();     
            return arr;

        }
    }
}
