namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            string answer;
            int result;
            Console.WriteLine("welcome to the calculator program");

            Console.WriteLine("please enter your first number");

           num1=  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter your second number");
           num2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("type of operation ud like to do");
            Console.WriteLine("please enter a for addition , s for subtraction ,m for multiplication or any other key for division");
            answer = Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2;

            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if(answer =="m")
            {
                result = num1 * num2;
            }
            else 
            {
                result= num1 / num2;
            }

            Console.WriteLine("the result is  "+ result);

            
        }
    }
}
