
/// <summary>
/// 날짜 : 2026.02.23 
/// 문제 : 성격 유형 검사하기
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/118666
/// </summary>
public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        char[] keys = new char[8]{'R', 'T', 'C', 'F', 'J', 'M', 'A', 'N'};
        
        Dictionary<int, int> scoreDict = new Dictionary<int, int>()
        {
            {1, 3},
            {2, 2},
            {3, 1},
            {4, 0},
            {5, 1},
            {6, 2},
            {7, 3}
        };
        
        Dictionary<char, int> surveyDict = new Dictionary<char, int>()
        {
            {'R', 0},
            {'T', 0},
            {'C', 0},
            {'F', 0},
            {'J', 0},
            {'M', 0},
            {'A', 0},
            {'N', 0},
        };
        
        for(int i = 0; i < survey.Length; i++)
        {
            if(choices[i] < 4)
            {
                surveyDict[survey[i][0]] += scoreDict[choices[i]];
            }
            else if(choices[i] > 4)
            {
                surveyDict[survey[i][1]] += scoreDict[choices[i]];
            }
        }
        
        for(int i = 0; i < 8; i += 2)
        {
            if(surveyDict[keys[i]] > surveyDict[keys[i + 1]] || surveyDict[keys[i]] == surveyDict[keys[i + 1]])
            {
                answer += keys[i];
            }
            else if(surveyDict[keys[i]] < surveyDict[keys[i + 1]])
            {
                answer += keys[i + 1];
            }
        } 
        return answer;
    }
}