public class ListExample
{
    static void ListExampleMain()
    {
        List<string> names = new List<string>()
          {"Peter", "Michael", "George", "Victor", "John" };
        names.Sort();
        Console.WriteLine(string.Join(", ", names));
        // George, John, Michael, Peter, Victor
        names.Sort();
        names.Reverse();
        Console.WriteLine(string.Join(", ", names));
        // Victor, Peter, Michael, John, George
    }
}
