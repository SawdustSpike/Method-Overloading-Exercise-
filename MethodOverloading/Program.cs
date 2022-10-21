namespace MethodOverloading
{
    public class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }
        static double Add(double x, double y)
        {
            return x + y;
        }
        static string Add(int x, int y, bool z)
        {
            if (z = true && (x + y > 1))
                return $"{x + y} dollars";
            else if (z = true && x + y == 1)
                return $"{x + y} dollar";
            else
                return "Something has gone wrong";
                            }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 5));
            Console.WriteLine(Add(1.3, 6.3));
            Console.WriteLine(Add(2, 3, true));

        }
    }
}
