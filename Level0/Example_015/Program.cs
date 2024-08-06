namespace Example_015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string my_string = "cccCCC";
            string answer = "";

            //char.IsUpper(x) ? x.ToString().ToLower() : x.ToString().ToLower();
        
            for (int i =0; i< my_string.Length; i++)
            {
                if (char.IsUpper(my_string[i]))
                {
                   answer += my_string[i].ToString().ToLower();
                }
                else
                {
                   answer +=my_string[i].ToString().ToUpper();
                }
            }

            Console.WriteLine(answer);
        }
    }
}
