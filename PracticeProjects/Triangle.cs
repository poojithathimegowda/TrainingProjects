public class Triangle
{
    private int triangleBase { get; set; }
    private int triangleHeight { get; set; }
    //public Triangle(int triangleBase, int triangleHeight)
    //{
    //    this.triangleBase = triangleBase;
    //    this.triangleHeight = triangleHeight;
    //}

    public static double HypotenuseOfTriangle(int tBase, int tHeight)
    {
        double hyp = Math.Sqrt((tBase * tBase) + (tHeight * tHeight));
        return hyp;

    }

    static void TriangleMain()
    {
        Console.WriteLine("Enter the sides of the triangle");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine(Triangle.HypotenuseOfTriangle(x, y));
    }
}