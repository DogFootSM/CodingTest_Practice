namespace Example_046
{

    /// <summary>
    /// 날짜 : 2024-08-10
    /// 문제 : 모스부호(1)
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120838
    /// </summary>
    public class Solution
    {
        public string solution(string letter)
        {
            string answer = "";

            string[] morse =
            { ".-", "-...", "-.-.", "-..", ".", "..-.",
            "--.", "....", "..", ".---", "-.-", ".-..",
            "--", "-.", "---", ".--.", "--.-", ".-.",
            "...", "-", "..-", "...-", ".--", "-..-",
            "-.--", "--.." };

            Dictionary<string, string> morseDic = new Dictionary<string, string>();
            int index = letter.Split(" ").Length;

            for (int i = 0; i < morse.Length; i++)
            {
                morseDic.Add(morse[i], ((char)(i + 97)).ToString());
            }

            for (int i = 0; i < index; i++)
            {
                answer += string.Concat(morseDic[letter.Split(" ")[i]]);
            }



            return answer;
        }
    }
}
