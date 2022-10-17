namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------EXERCISE 1-------------------
            //If we declare a variable we can use it for whatever purpose we want later in the code, so we dont have to constantly write 17 or 4. Instead we can assign a value and declare it earlier in the code. 
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
            //------------EXERCISE 2---------------
            //This takes raduis as a string and convers it into a double and stores it in radius
            //-Make sure to write a desrption so the user doesnt get confused on what your asking for it to input for
            Console.WriteLine("What is the radius of your circle");
            var radius = double.Parse(Console.ReadLine());
            //--Make sure to solve it- 
            //-Here what it does is that it takes pi and multplies it by the power thingy. Which for example if radius is 4 it will be somethibng like var radius==4, then it will be (radius,2)--WHich is essentaly 4 to the power of 2*the math pi which is pi from the math library. 
            var answer = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of a circle with a radius of {radius} is {answer}");
            //-------------------Exercise 2----------------

        }
    }
}