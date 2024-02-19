namespace OperatorsDemoCSharp_45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operators
            //Assignment operator =

            //int x = 5;
            //int y = 10;


            //Arithmetic operators

            //int addition = x + y;
            //int subtraction = x - y;
            //int multiplication = x * y;
            //int division = x / y;
            //int modulus = x % y; //remainder after divison

            //bool isEven = x % 2 == 0;

            //Unary operators
            int x = 3;
            int y = ++x; //pre increment

            Console.WriteLine(x);
            Console.WriteLine(y);

            int a = 3;
            int b = a++; //post increment

            Console.WriteLine(a);
            Console.WriteLine(b);

            int c = 5;
            Console.WriteLine(--c); //pre decrement

            int d = 4;
            Console.WriteLine(d--); //post decrement
            Console.WriteLine(d);


            //Relational operators

            int e = 5;
            int f = 3;

            bool isEqual = e == f;
            bool notEqual = e != f;
            bool greaterThan = e > f;
            bool lessThan = e < f;
            bool greaterThanEqualTo = e >= f;
            bool lessThanEqualTo = e <= f;

            //Logical operators

            bool resultOne = a == 5 && b > 5; //&& AND - both need to be true for it to evaluate to true
            bool resultTwo = b > 10 || c > 20; //|| OR - only one thing needs to be true for it evaluate to true

            //Null coalesting operator

            int? possiblyNullValue = 200;
            int notNullNumber = possiblyNullValue ?? 500;
            Console.WriteLine(notNullNumber);

        }
    }
}
