using System.Text;

namespace Example_032
{

    /// <summary>
    /// 날짜 : 2024-08-08
    /// 문제 : 가위 바위 보
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120839
    /// </summary>
    public class Solution
    {
        public string solution(string rsp)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in rsp)
            {

                switch (c)
                {

                    case '2':
                        sb.Append("0");
                        break;

                    case '0':
                        sb.Append("5");
                        break;

                    case '5':
                        sb.Append("2");
                        break;
                }
            }

            string answer = sb.ToString();

            return answer;
        }
    }
}
