namespace _05MultipleInterFace
{

    public class Cmath : I1, I2
    {
         int I1.add(int a, int b)
        {
            return a + b;
        }
         int I2.add(int a, int b)
        {
            return a + b;
        }


        public int Mul(int a, int b)
        {
            return a * b;
        }

        public int sub(int a, int b)
        {
            return a-b;
        }
    }
    internal class Program
    {

       
        static void Main(string[] args)
        {
          I1 c1 =new Cmath();
          int result=  c1.add(12,12);
            Console.WriteLine(result);
            I2 i2 = new Cmath();    
          result=  i2.add(10,12);
            Console.WriteLine(result );

        }
    }

    interface I1
    {
        public int add(int a, int b);
        public int sub(int a, int b);
    }
    interface I2
    {
        public int add(int a, int b);
        public int Mul(int a, int b);
    }
}
