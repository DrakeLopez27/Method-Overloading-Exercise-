namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
       
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isCheck)
        {
            var sum = num1+ num2;
            

            if (isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if(isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if(isCheck == true && sum < 1)
            {
                return $"{sum} cents";
            }
            else
            {
                return sum.ToString();
            }

        }


        static void Main(string[] args)
        {
            var answer = Add(27, 50);

            var decimalAnswer = Add(27.0m, 50.1m);

            var otherAnswer = Add(5, 28, true);

            Console.WriteLine($"int add: {answer} and decimal add: {decimalAnswer}");
            Console.WriteLine(otherAnswer);


        }
    }
}
