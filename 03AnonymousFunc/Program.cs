namespace _03AnonymousFunc
{
    internal class Program
    {
        public delegate void MyDelegate(int a);


        public static void myfun(MyDelegate obj , int a)
        {
            a += 10;
            obj(a);
        }

        public static int Add(int a , int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            //MyDelegate obj = delegate (int a)
            //   {
            //    a += 10;
            //       Console.WriteLine("new val is : {0}" ,a);
            //   };

            //obj(5);

            Add(1,2);
            myfun(delegate (int a) { a += 10; Console.WriteLine(a);},5);
        }
    }
}
