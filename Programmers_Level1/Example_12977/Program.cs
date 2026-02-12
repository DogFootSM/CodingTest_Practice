namespace Example_12977
{
    /// <summary>
    /// 날짜 : 2026.02.11
    /// 문제 : 소수 만들기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12977
    /// </summary>
    class Solution
    {
        public int solution(int[] nums)
        {
            int answer = 0;
        
            for(int i = 0; i < nums.Length - 2; i++)
            {
                for(int j = i + 1; j < nums.Length - 1; j++)
                {
                    for(int k = j + 1; k < nums.Length; k++)
                    {
                        int number = nums[i] + nums[j] + nums[k];
                    
                        if(IsPrimeNumber(number))
                        {
                            answer++;
                        }
                    }
            
                }
            
            }
        

            return answer;
        }
    
        public bool IsPrimeNumber(int number)
        {
            for(int i = 2; i * i <= number; i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }
        
            return true;
        }
    }
}
