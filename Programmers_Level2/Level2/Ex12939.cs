namespace Level2;

/// <summary>
/// 날짜 : 2025-08-22
/// 문제 : 최대값과 최솟값
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12939
/// </summary>
public class Ex12939
{
    public string solution(string s)
    {
        string[] sArr = s.Split(' ');

        int min = int.MaxValue;
        int max = int.MinValue;

        for (int i = 0; i < sArr.Length; i++)
        {
            int sNum = int.Parse(sArr[i]);
            if (sNum > max) max = sNum;
            if (sNum < min) min = sNum;
        }

        return $"{min} {max}";
    }
}