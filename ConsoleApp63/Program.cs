namespace ConsoleApp63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition addition = new Addition();
            Console.WriteLine(addition.Operate(5,8));

            Substraction sub = new Substraction();
            Console.WriteLine(sub.Operate(15, 6));

            Multiplication multip = new Multiplication();
            Console.WriteLine(multip.Operate(1, 9));

            Division div = new Division();
            Console.WriteLine(div.Operate(20, 5));

        }
    }
}
