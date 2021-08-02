using System;


namespace FirstNodd_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("Give a Value ");
            int a = Int32.Parse(Console.ReadLine());
            int b = 0;
            int c = 1;
            while ( b <= a )
            {
                c += 2;
                b += 1;  
            }
            Console.WriteLine("Sum of First " + a  + " Elements : " +  c);
            Console.ReadKey();
        }
    }
}
