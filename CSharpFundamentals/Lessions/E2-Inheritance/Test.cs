public class Test
{
    void CalculateAreas()
    {
        IShape rect1 = new Rectanlge(23.4, 12.5);
        var area1 = rect1.GetArea();   
        var per1 = rect1.GetPerimeter(); 

        IShape square1 = new Square(56.4);
        var area2 = square1.GetArea();
        var per2 = square1.GetPerimeter();

        IShape triangle1 = new Triangle(23.4, 56.1, 12.7);
        var area3 = triangle1.GetArea();
        var per3 = triangle1.GetPerimeter();
    }
}
