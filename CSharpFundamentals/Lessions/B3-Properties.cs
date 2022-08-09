
namespace AboutClasses;
public class Planet
{
    private string name;

    // Full property
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value.Length > 0)
                name = value;
        }
    }

    // Auto-implemented property
    public double Mass { get; set; }

    // Read-only property
    public double DistanceFromSun { get; }
}

public class Test2
{
    void Do()
    {
        Planet earth = new();
        earth.Name = "Earth";
        earth.Mass = 3513525.435;
        var x = earth.Name;
    }
}
