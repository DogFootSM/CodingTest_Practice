namespace Example_052
{

    /// <summary>
    /// 날짜 : 2024-08-11
    /// 문제 : k의 개수
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120887 
    /// </summary>
    public class Solution
    {
        public int solution(int i, int j, int k)
        {
            int answer = 0; 
            string temp = "";


            //i ~ j 까지 반복
            for (; i <= j; i++)
            {
                //i의 수를 문자열로 변경하여 저장
                temp = i.ToString();

                
                for (int c = 0; c < temp.Length; c++)
                {   
                    //저장된 문자열을 자릿수 하나씩 k랑 같은지 확인
                    if (int.Parse(temp[c].ToString()) == k)
                    {   
                        //같으면 카운트 증가
                        answer++;
                    }
                }
            }
            return answer;
        }
    }
}
