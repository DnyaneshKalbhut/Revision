namespace Delegates
{
    internal class Program
    {
        public delegate void Calculation(int a , int b);


        public  void Addition(int a , int b)
        {
            Console.WriteLine("Addition is {0}",a+b);
        }
        public  void Substraction(int a, int b)
        {
            Console.WriteLine("Substraction is {0}", a - b);
        }
        public  void Multiplication(int a, int b)
        {
            Console.WriteLine("Multiplication is {0}", a * b);
        }
        public  void Division(int a, int b)
        {
            Console.WriteLine("Division is {0}", a / b);
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            Calculation obj1 = new Calculation(p.Multiplication);
            //obj1(12,21);

            obj1+=p.Addition; //Multicast Delegate

            obj1(12, 21);
            


            //obj1 = Substraction;
            //obj1(12, 12);

            //obj1 = Multiplication;
            //obj1(12, 12);

            //obj1 = Division;
            //obj1(12, 12);

            
        }
    }
}
