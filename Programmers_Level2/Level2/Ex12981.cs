namespace Level2;

/// <summary>
/// 날짜 : 2026.03.31
/// 문제 : 영어 끝말잇기
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12981
/// </summary>
public class Ex12981
{
    public int[] solution(int n, string[] words)
    {
        int[] answer = new int[]{0, 0};
        HashSet<string> recordWord = new HashSet<string>();
        char prevWord = ' ';
        int turn = 1;
        prevWord = words[0][words[0].Length -1];
        recordWord.Add(words[0]);
        
        for(int i = 2; i <= words.Length; i++)
        {
            int talker = i % n == 0 ? n : i % n;
            
            if(recordWord.Contains(words[i - 1]) || words[i - 1][0] != prevWord)
            {
                answer[0] = talker;
                answer[1] = turn;
                
                return answer;
            }
            
            if(i % n == 0) turn++;
            recordWord.Add(words[i - 1]);
            prevWord = words[i -1][words[i -1].Length - 1];
        }
        
        return answer;
    }
}