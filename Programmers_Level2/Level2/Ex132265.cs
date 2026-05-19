namespace Level2;

/// <summary>
/// 날짜 : 2026-05-19
/// 문제 : 롤 케이크 자르기
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/132265
/// </summary>
public class Ex132265
{
    public class Solution {
        public int solution(int[] topping) {
            int answer = 0;
            Dictionary<int, int> csTake = new Dictionary<int, int>();
            HashSet<int> csSet = new HashSet<int>();
            HashSet<int> broSet = new HashSet<int>();
            
            //형이 가지고 있을 전체 토핑과 토핑 종류 초기화
            for(int i = 0; i < topping.Length; i++)
            {
                if(!csTake.ContainsKey(topping[i]))
                {
                    csTake.Add(topping[i], 0);
                }
            
                csTake[topping[i]]++;
                csSet.Add(topping[i]);
            }
        
            for(int i = 0; i < topping.Length; i++)
            {
                broSet.Add(topping[i]);
                csTake[topping[i]]--;
                
                //형이 해당 토핑 종류를 전부 뺏김
                if(csTake[topping[i]] == 0 && csSet.Contains(topping[i]))
                {
                    csSet.Remove(topping[i]);
                }
            
                //가지고 있는 토핑 개수가 같은지?
                if(broSet.Count == csSet.Count)
                {
                    answer++;
                } 
            }
        
        
            return answer;
        }
    }
}