class NestedIfExample
{
    static void SortingThreeNos(string[] args)
    {
        //Sort 3 real numbers in descending order.
        Console.WriteLine("enter 3 nos");
        int a = Convert.ToInt16(Console.ReadLine());
        int b = Convert.ToInt16(Console.ReadLine());
        int c = Convert.ToInt16(Console.ReadLine());
        if (a >= b)
        {
            if (b >= c)
            {
                Console.WriteLine($"{a}, {b}, {c}");
            }
            else if (a >= c)
            {
                Console.WriteLine($"{a}, {c}, {b}");
            }
            else
            {
                Console.WriteLine($"{c}, {a}, {b}");
            }
        }
        else
        {
            if (a >= c)
            {
                Console.WriteLine($"{b}, {a}, {c}");
            }
            else if (b >= c)
            {
                Console.WriteLine($"{b}, {c}, {a}");
            }
            else
            {
                Console.WriteLine($"{c}, {b}, {a}");
            }
        }

    }

}
