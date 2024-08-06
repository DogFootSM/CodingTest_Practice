namespace Example_014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cipher = "dfjardstddetckdaccccdegk";
            int code = 4;
            string answer = "";
            int count = 0;

            for (int i = 0; i < cipher.Length; i++)
            {
                count++;
                if (count % code == 0)
                {
                   answer += cipher[i];
                } 
            }

            Console.WriteLine(answer);

        }
    }
}
