// See https://aka.ms/new-console-template for more information
namespace MethodsEx2
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }     
            static void Main(string[] args)
        {
            var amountOfCars = Sum(2, 6);
            var blah = Multiply(60, 2, 4);
        
        }
    }
}