namespace GenericsProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Welcome To Generics Problem ---------");

            // GenericsProgram genericsProgram = new GenericsProgram();

            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'S', 'E', 'L', 'L', 'O' };

            Generics.toPrint(intArray);
            Generics.toPrint(doubleArray);
            Generics.toPrint(charArray);
        }
    }
}