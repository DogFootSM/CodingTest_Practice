namespace Level2;

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