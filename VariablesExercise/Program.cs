namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Eric";
            int age = 24;
            char mySymbol = '$';
            bool isAlive = false;
            double monthlyIncome = 3600.00;
            decimal myDebt = 2500.00m;

            Console.WriteLine($"My name is {myName} and I am {age} years old.");
            Console.WriteLine($"My current debt to income ratio is {mySymbol}{myDebt}/{mySymbol}{monthlyIncome}");
            Console.WriteLine($"Am I still alive?");
            if (isAlive)
            {
                Console.WriteLine("I am!");
            }
            else
            {
                Console.WriteLine("...");
            }
        }
    }
}
