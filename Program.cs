using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Assignment3._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReturEvenNumbers();
        }

        public static void ReturEvenNumbers()
        {
            
            StringBuilder sb = new StringBuilder(50);
            int j = 0;
            for (int i = 2; i < 100; j++)
            {
                sb.Append(i + " ");
                i = i + 2;
            }
            Console.WriteLine(sb.ToString());   
        }
    }
}
