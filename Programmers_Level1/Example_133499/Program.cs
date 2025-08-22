
/// <summary>
/// 날짜 : 2025-02-10
/// 문제 : 옹알이 (2)
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/133499
/// </summary>
public class Babbling_2
{
    public static void Main(string[] args)
    {
        int answer = 0;
        string[] canBabbling = { "aya", "ye", "woo", "ma" };
        
        string[] babbling = {"aya", "yee", "u", "maa"};
        
        string beforeTemp;
        string temp = "";
        
        for (int i = 0; i < babbling.Length; i++)
        {
            beforeTemp = " ";
            for (int j = 0; j < babbling[i].Length; j++)
            {
                if (!babbling[i][0].Equals('a') && !babbling[i][0].Equals('y') && !babbling[i][0].Equals('w') &&
                    !babbling[i][0].Equals('m')) break;

                if (beforeTemp[0].Equals(babbling[i][0])) break;
                
                temp += babbling[i][j].ToString();

                if (canBabbling.Contains(temp))
                {
                    babbling[i] = babbling[i].Remove(0,j + 1);
                    beforeTemp = temp;
                    temp = "";
                    j = -1; 
                }

            }
            
            temp = "";
        }

        answer = babbling.Where(x => x.Equals("")).Count();
        
        Console.WriteLine(answer);
        
    }
    
}