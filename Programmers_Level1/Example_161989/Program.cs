/// <summary>
/// 날짜 : 2025-02-10
/// 문제 : 덧칠하기
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/161989
/// </summary>
public class OverPainting
{
    public static void Main(string[] args)
    {
        int n = 8;  //벽의 개수
        int m = 4;  //롤러의 길이
        int paintCount = 0;     //덧칠한 횟수

        int[] section = { 2, 3, 6};
        bool[] wall = new bool[n];

        for (int i = 0; i < section.Length; i++)
        {
            wall[section[i] - 1] = true;
        }
    
        for (int i = 0; i < section.Length; i++)
        {
            if (wall[section[i] - 1])
            {
                if (((section[i] - 1) + m) > wall.Length)
                {
                    while (((section[i] - 1) + m) > wall.Length)
                    {
                        section[i] -= 1;
                    }
                }

                for (int j = section[i] - 1; j < (section[i]-1) + m; j++)
                {
                    wall[j] = false;
                }

                paintCount++;
            } 

        }

        Console.WriteLine(paintCount);
    }   
}