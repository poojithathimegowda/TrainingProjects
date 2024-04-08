namespace DatatypesPractice
{
    interface IShape
    {
        public void areaOfShape(int i);


    }
    public abstract class Shape: IShape
    {
        public int height { get; set; }
        public int width { get; set; }
        public abstract void areaOfShape(int h,int w);

        public void areaOfShape(int h)
        {
            throw new NotImplementedException();
        }

        public virtual void perimeterOfShape(int h, int w)
        {
            var perimeter= ((2*h)+(2*w));
            Console.WriteLine(perimeter);
        }
    }

    public class Rectangle : Shape
    {
        public override void areaOfShape(int h, int w)
        {
            var area = ( h*w);
            Console.WriteLine(area);
        }
        public override void perimeterOfShape(int h, int w)
        {
            var perimeter = (h+h+w+w);
            Console.WriteLine(perimeter);
        }
    }

}
