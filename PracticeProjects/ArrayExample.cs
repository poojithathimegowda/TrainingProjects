public class ArrayExample
{
    public int Prop1;
    public static string Garland;
    public static void Demo(string A)
    {
        Garland = Garland + $"Flower from Demo {A} \n";
       
        Console.WriteLine(Garland);
    }

    public  void DemoNonStatic(string via )
    {
        //Console.WriteLine(via);
        //Garland = $"Flower from  DemoNonStatic() {via}";

        Demo(Garland);

        //Console.WriteLine(Garland);

    }


    static void ArrayExampleMain()
    {
        ArrayExample.Demo("Some one from outsider");
        ArrayExample a1 = new ArrayExample();
        a1.DemoNonStatic("\n a1");

        ArrayExample.Demo("Some one from outsider2");

        ArrayExample a2 = new ArrayExample();

        ArrayExample.Demo("Some one from outsider3");
        a2.DemoNonStatic("\n a2");
        ArrayExample.Demo("after object");

        Console.WriteLine(ArrayExample.Garland);
    }
}