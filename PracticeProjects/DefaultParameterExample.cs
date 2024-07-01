
    public class DefaultParameterExample
    {
        public static void PrintMessage( string secondMessage, string message = "Default")
        {
            Console.WriteLine(message);
        }
        static void DefaultParameterExampleMain()
        {
            Console.WriteLine();
            DefaultParameterExample.PrintMessage(message: "Hello", secondMessage: "World");
        }
    }
   

