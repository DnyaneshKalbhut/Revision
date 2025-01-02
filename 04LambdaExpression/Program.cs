namespace _04LambdaExpression
{
    internal class Program
    {
        public delegate int MyDelegate(int a);
        static void Main(string[] args)
        {
            MyDelegate obj = (a) =>
            {
               return a += 10;
            };

            int a=obj(2);
            Console.WriteLine(a);
        }
    }
}
