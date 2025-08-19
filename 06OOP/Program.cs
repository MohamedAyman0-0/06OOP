#region first project
#region 1.
public class Point3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    // Constructor 1: Default
    public Point3D() : this(0, 0, 0) { }

    // Constructor 2: X only
    public Point3D(int x) : this(x, 0, 0) { }

    // Constructor 3: X & Y
    public Point3D(int x, int y) : this(x, y, 0) { }

    // Constructor 4: X, Y & Z (Main constructor)
    public Point3D(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }


#endregion
#region 2.
  public override string ToString()
    {
        return $"Point Coordinates: ({X}, {Y}, {Z})";
    }
}
#endregion
#region 3. 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter coordinates for Point P1:");
        Point3D P1 = ReadPoint();

        Console.WriteLine("\nEnter coordinates for Point P2:");
        Point3D P2 = ReadPoint();

        Console.WriteLine($"\nP1: {P1}");
        Console.WriteLine($"P2: {P2}");
    }


    static Point3D ReadPoint()
    {
        int x = ReadInt("X");
        int y = ReadInt("Y");
        int z = ReadInt("Z");

        return new Point3D(x, y, z);
    }

    static int ReadInt(string coordName)
    {
        int value;

        while (true)
        {
            Console.Write($"Enter {coordName}: ");
            string input = Console.ReadLine();

         
            if (int.TryParse(input, out value))
                return value;

          
            try
            {
                value = int.Parse(input);
                return value;
            }
            catch
            {
                Console.WriteLine("Parse failed!");
            }

        
            try
            {
                value = Convert.ToInt32(input);
                return value;
            }
            catch
            {
                Console.WriteLine("Convert failed! Please enter a valid integer.");
            }
        }
    }
}
#endregion
#region
#endregion
#region
#endregion
#endregion
