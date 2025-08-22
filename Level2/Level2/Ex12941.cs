namespace Level2;


/// <summary>
/// 날짜 : 2025-08-22
/// 문제 : 최솟값 만들기
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12941
/// </summary>
public class Ex12941
{
    private int[] tempArr;

    public void MergeSort(int[] arr, int start, int end)
    {
        if (start >= end) return;
        int middle = (start + end) / 2;
        MergeSort(arr, start, middle);
        MergeSort(arr, middle + 1, end);
        Merge(arr, start, middle, end);
    }

    public void Merge(int[] arr, int start, int middle, int end)
    {
        int i = start;
        int j = middle + 1;
        int temp = 0;

        while (i <= middle && j <= end)
        {
            if (arr[i] < arr[j])
            {
                tempArr[temp++] = arr[i++];
            }
            else
            {
                tempArr[temp++] = arr[j++];
            }
        }

        while (i <= middle)
        {
            tempArr[temp++] = arr[i++];
        }

        while (j <= end)
        {
            tempArr[temp++] = arr[j++];
        }

        i = start;
        temp = 0;

        while (i <= end)
        {
            arr[i++] = tempArr[temp++];
        }
    }
 
    public int solution(int[] A, int[] B)
    {
        int answer = 0;
        tempArr = new int[A.Length];
        MergeSort(A, 0, A.Length - 1);
        MergeSort(B, 0, B.Length - 1);

        for (int i = 0; i < A.Length; i++)
        {
            int temp = A[i] * B[B.Length - 1 - i];
            answer += temp;
        }

        return answer;
    }
    
    // public int solution(int[] A, int[] B) {
    //     int answer = 0;
    //     
    //     List<int> aList = A.ToList();
    //     List<int> bList = B.ToList();
    //     
    //     aList.Sort();
    //     bList.Sort();
    //     
    //     for(int i = 0; i < aList.Count; i++)
    //     {
    //         int temp = aList[i] * bList[bList.Count - 1 - i];
    //         answer += temp;
    //     }
    //     
    //     
    //     return answer;
    // }
    
}