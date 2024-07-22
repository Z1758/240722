namespace _240722
{
   /* class Chracter
    {
        int level;
        int hp;
        int moveSpeed;
        int attack;

        public void FowardMove()
        {
        }
        public void BackMove()
        {

        }

        public void TurnLeft()
        {

        }
        public void TurnRight()
        {

        }
        public void Attack()
        {

        }
        public void Hit()
        {

        }

    }
   */
    public class MyCalculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if(a == 0 || b== 0)
            {
                Console.WriteLine("0으로 나눌수 없습니다.");

                return 0;
            }

            return a / b;
        }

        public static double Squared(double a, double b)
        {
            double sum = a;
            for(int i = 0; i < b-1; i++)
            {
                sum *= a;
            }

            return sum;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
           //Chracter chracter = new Chracter();

           Console.WriteLine(MyCalculator.Squared(2, 4));
        }
    }
}
