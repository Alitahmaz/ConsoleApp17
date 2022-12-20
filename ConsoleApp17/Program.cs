namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] birinciarray = { 1, 3, -5, 4 };
            int[] ikinciarray = { 1, 4, -5, -2 };

            Console.WriteLine("Array1: [{0}]", string.Join(", ", birinciarray));
            Console.WriteLine("Array2: [{0}]", string.Join(", ", ikinciarray));

            Console.WriteLine("iki elementin vurmasi: ");

            for (int i = 0; i < birinciarray.Length; i++)
            {

                Console.Write(birinciarray[i] * ikinciarray[i] + " ");
            }
        }
    }
}