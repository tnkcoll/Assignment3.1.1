using System.Security.Cryptography.X509Certificates;

namespace Assignment3._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[49];
            
            numbers = ReturvEvenNumbers(numbers);
            PrintEvenNumbers(numbers);
        }

        public static int[] ReturvEvenNumbers(int[] nums)
        {
            int j = 0;
            for (int i = 2; j < nums.Length; j++)
            {
                
                nums[j] = i;
                i = i + 2;
            }
            return nums;
        }

        public static void PrintEvenNumbers(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
            }
            Console.WriteLine();
        }
    }
}
