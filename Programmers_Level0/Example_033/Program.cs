namespace Example_033
{


    /// <summary>
    /// 날짜 : 2024-08-08
    /// 문제 : 점의 위치 구하기 
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120841
    /// </summary>
    public class Solution
    {
        public int solution(int[] dot)
        {
            int x = dot[0];
            int y = dot[1];


            if (x > 0)
            {
                if (y > 0)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }

            else
            {
                if (y > 0)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
