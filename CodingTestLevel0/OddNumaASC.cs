using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestLevel0
{
    internal class OddNumaASC
    {
         
        static void Main(string[] args)
        {

            int n = 15;     // n 이하의 값을 구하기 위한 정수
            int index;      //배열의 인덱스
            int[] array;    //n이하의 정수를 오름차순으로 저장하기 위한 변수


            Queue<int> stack = new Queue<int>();    

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    stack.Enqueue(i);       //1 ~ n 사이의 홀수를 Queue 에 저장
                }
            }

            index = stack.Count;        
            array = new int[index];         //저장할 배열의 인덱스를 큐의 개수만큼 생성

            for (int i = 0; i < index; i++)
            {
                array[i] = stack.Dequeue();     //큐에 저장된 홀수를 배열에 저장
            }


        }



    }
}
