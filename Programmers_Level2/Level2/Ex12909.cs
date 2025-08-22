namespace Level2;


/// <summary>
/// 날짜 : 2025-08-22
/// 문제 : 올바른 괄호
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12909
/// </summary>
public class Ex12909
{
    public bool solution(string s)
    {
        bool answer = true;

        Stack<char> bracketStack = new Stack<char>();

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i].Equals(')'))
            {
                bracketStack.Push(s[i]);
            }
            else
            {
                if (bracketStack.Count > 0)
                {
                    bracketStack.Pop();
                }
                else
                {
                    return false;
                }
            }
        }

        return bracketStack.Count == 0;
    }
}