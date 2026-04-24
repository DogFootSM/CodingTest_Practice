namespace Level2;
using System.Collections.Generic;

/// <summary>
/// 날짜 : 2026.04.24
/// 문제 : 게임 맵 최단거리
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/1844
/// </summary>
public class Ex1844
{
    public int solution(int[,] maps)
    {
        int goalH = maps.GetLength(0) - 1;
        int goalW = maps.GetLength(1) - 1;
        int[] dx = new int[] { 1, -1, 0, 0 };
        int[] dy = new int[] { 0, 0, 1, -1 };
        
        bool[,] visits = new bool[goalH + 1, goalW + 1];
        Queue<(int, int, int)> node = new Queue<(int, int, int)>();
        
        node.Enqueue((0, 0, 1));

        while (node.Count != 0)
        {
            var current = node.Dequeue();
            
            int curH = current.Item1;
            int curW = current.Item2;
            int distance = current.Item3;
            
            visits[curH, curW] = true;
            
            //방문 노드 확인
            if (visits[curH, curW]) continue;

            //목표 위치 도착 확인
            if (curH == goalH && curW == goalW)
            {
                return distance;
            }
    
            for (int i = 0; i < dx.Length; i++)
            {
                int newH = curH + dy[i];
                int newW = curW + dx[i];
                
                //맵의 범위를 벗어났는지?
                if (newH < 0 || newH > goalH || newW < 0 || newW > goalW) continue;
                
                //방문을 했는지?
                if (visits[newH, newW]) continue;
                
                //다음 위치가 벽인지?
                if(maps[newH, newW] == 0) continue;
                
                node.Enqueue((newH, newW, distance));
            }
            
        }
        
        return -1;
    }
}