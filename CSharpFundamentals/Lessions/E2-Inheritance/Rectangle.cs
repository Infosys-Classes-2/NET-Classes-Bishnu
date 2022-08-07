public class Rectanlge: IShape
{
    public Rectanlge(double l, double b)
    {
        length = l;
        breadth = b;
    }

    private double length;
    private double breadth;

    public double GetArea() => length * breadth;

    public double GetPerimeter() => 2 * (length + breadth);
}
