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


        static void Main(string[] args)
        {
            //MyDelegate obj = delegate (int a)
            //   {
            //    a += 10;
            //       Console.WriteLine("new val is : {0}" ,a);
            //   };

            //obj(5);


            myfun(delegate (int a) { a += 10; Console.WriteLine(a);},5);
        }
    }
}
