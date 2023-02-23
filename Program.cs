namespace Homework3;
class Program
{
        static void Main(string[] args)

        //Question 1
    {
        Console.WriteLine("Input an integer:");
        int N = Convert.ToInt16(Console.ReadLine());
       
            for(int p = 2; p <= N-1; p++)
            {
                if (N % p ==0)
                {
                    Console.WriteLine("N is non-prime");
                    return; // end the program when N is non-prime
                }
            }
        Console.WriteLine("N is prime");

        //Question 2
        Console.WriteLine("Assign an int value to N:");
        int N1 = Convert.ToInt16(Console.ReadLine());
        for (int row = 0; row<6; row++)
        {
            Console.WriteLine("#");
        }
        Console.WriteLine("");

        //Question 3
        Console.WriteLine("Assign an int value to N:");
        int N2 = Convert.ToInt16(Console.ReadLine());
        for (int row = 0; row<6; row++){
            for(int col = 0; col<6; col++)
        {
            if(row>=col)
            Console.Write("*");
        }
        Console.WriteLine("");
        }


    }
    }
