namespace Example_132267
{

    /// <summary>
    /// 날짜 : 2024-10-24
    /// 문제 : 콜라 문제
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/132267
    /// </summary> 
    public class Solution
    {
        public int solution(int a, int b, int n)
        {
            int answer = 0; 
            answer = Change(a, b, n, answer); 
            return answer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">최소 교환 개수</param>
        /// <param name="b">교환 시 돌려받을 개수</param>
        /// <param name="n">빈병의 총 개수</param>
        /// <param name="result">총 교환한 빈병 개수</param>
        /// <returns></returns>
        public int Change(int a, int b, int n, int result)
        {
            //보유한 빈병이 최소 교환 개수보다 큰 경우에 교환 진행
            if (n >= a)
            {
                result += (n / a) * b;
            }
            //보유중인 빈병이 부족하면 그동안 교환한 개수 반환
            else
            {
                return result;
            }

            return Change(a, b, ((n / a) * b) + (n % a), result);
        }

    }
}
