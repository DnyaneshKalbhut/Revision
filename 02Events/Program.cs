
namespace _02Events
{
    internal class Program
    {

        public delegate string MyDelegate(string str1, string str2);
        event MyDelegate myEvent;

        Program()
        {
            this.myEvent += MyEventExample;
        }

        private string MyEventExample(string str1, string str2)
        {
            return "Hello" + str1 + str2;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            string str3 = p.myEvent("D", "K");
            Console.WriteLine(str3);
        }
    }
}
