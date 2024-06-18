public class ParamsExample
{
    public int Sum(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    static void ParamsExampleMain(string[] args)
    {
        ParamsExample example = new ParamsExample();

        // Call with multiple arguments
        int result1 = example.Sum(1, 2, 3, 4, 5);
        Console.WriteLine("Sum: " + result1);

        // Call with array
        int[] nums = { 10, 20, 30 };
        int result2 = example.Sum(nums);
        Console.WriteLine("Sum: " + result2);
    }
}

