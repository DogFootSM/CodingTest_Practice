namespace Example_048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string my_string = "1000a";
            int answer = 0;

            List<int> list = new List<int>();
            string temp = "0";
            bool isCheck = false;

            for(int i = 0; i< my_string.Length; i++)
            {
                //isCheck = int.TryParse(my_string[i].ToString(), out int a);

                if (char.IsNumber(my_string[i]))
                {
                    temp += string.Concat(my_string[i]); 
                }
                else
                {
                    list.Add(int.Parse(temp));
                    temp = "0";
                } 
                //문자를 만나지 않으면 저장이 안됨...

            }

            foreach (int i in list)
            {
                Console.WriteLine(i);

                answer += i;
            }
            Console.WriteLine(answer);

        }
    }
}
