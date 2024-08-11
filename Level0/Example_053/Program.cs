namespace Example_053
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            string temp = "";
            int[] array = { 7, 77, 17 };

            for (int i = 0; i < array.Length; i++)
            {
                temp = array[i].ToString();

                for(int j = 0; j < temp.Length; j++)
                {
                    if (int.Parse(temp[j].ToString()) == 7)
                    {
                        answer++;
                    } 
                } 
            }

            Console.WriteLine(answer);

        }
    }
}
