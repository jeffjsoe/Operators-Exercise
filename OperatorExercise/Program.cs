namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;

            var sum = a += b;
            Console.WriteLine(sum);

            var diff=a-=b;
            Console.WriteLine(diff);
            //--a=a*b
            var product = a *= b;
            Console.WriteLine(product);
            //--a=a/b
            var quotient = a /= b;

            var remainder=a % b;
            //Here we plug in the declartion of the variables a and b and insert into a string
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");


        }
    }
}