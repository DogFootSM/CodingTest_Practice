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

            

            /*
             * 다른 사람의 풀이를 참고한 결과 시프트 연산자를 활용하면 간단하게 구할 수 있음
             */

            int num = 15;       //1 ~ num 사이의 홀수
            int count = (num + 1) / 2;      //배열의 크기
            int[] arr = new int[count];     

            for(int i = 0; i < count; i++)
            {
                arr[i] = (i << 1) + 1;      // 1 왼쪽 시프트 연산 시 기존 값에 2배가 커지는 것을 이용하여 홀수를 구함

                Console.WriteLine(arr[i]);
            }




        }



    }
}
