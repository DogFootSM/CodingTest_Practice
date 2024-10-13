namespace Temp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[6];
            int temp = 0;
            bool check = false;
            
            Random random = new Random();
            
             
            for(int i = 0; i < 6; i++)
            {
                temp = random.Next(1,46);
                
                if(i == 0)
                {
                    arr[i] = temp;
                }

                for(int j = 0; j <= i - 1; j++)
                {
                    if(temp == arr[j])
                    {
                        j = -1;
                        temp = random.Next(1, 46);
                    } 
                }
                arr[i] = temp;
            }

             



            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
