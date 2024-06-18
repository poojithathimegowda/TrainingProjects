class ProgramFactorial
{
    static void FactorialMethod(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        // "decimal" is the biggest C# type that can hold integer values
        int factorial = 1;
        // Perform an "infinite loop"
        while (true)
        {
            if (n <= 1)
            {
                break;
            }


            factorial *= n;
            n--;
        }

        Console.WriteLine("n! = " + factorial);



    }
}
