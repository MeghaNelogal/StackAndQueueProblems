namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***Welcome to Stack and Queue Problems***");

            Console.WriteLine("Please Enter the Information");
            bool check = true;
            Console.WriteLine("1.To Display Stack \n 2.To Display Queue \n");

            while (check)
            {
                Console.WriteLine("Enter The Above option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Stack.CreateStack();
                        break;
                    case 2:

                        Queue.InsertQueue();
                        break;

                    default:
                        check = false;
                        break;
                }

            }

        }
    }
}
   