using System;
namespace AA
{
    class AA
    {
        static void Main()
        {
            for (int i = 0; i < 5; )
            {
                int n;
                int l;
                Console.WriteLine("Enter  num1 ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter  num2");
                int z = int.Parse(Console.ReadLine());
                if (z > x && x > 0 && z > 0)
                {
                    while (x <= z)
                    {
                        n = 0;
                        for (l = 1; l < x; l++)
                        {
                            if (x % l == 0)
                            {
                                n = l + n;





                            }


                        }
                        if (n == x)
                        {
                            Console.WriteLine(x+" Is a perfect num");
                            Console.WriteLine("THE  MULTI OF {0}", x);
                            for (n = 1; n < x; n++)
                            {
                                if (x % n == 0)
                                {
                                    Console.WriteLine(n);

                                }

                            }
                            Console.WriteLine("--------------");

                        }
                        x++;
                    }

                }
                else
                    Console.WriteLine("incrroct input\n" +
                        "Please ensure that:\n" +
                        "1/num1 and num2 are positive \n" +
                        "2/num2 is bigger than num1\n");
            }
        }
    }
}