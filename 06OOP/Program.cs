#region first project
//#region 1.
//public class Point3D
//{
//    public int X { get; set; }
//    public int Y { get; set; }
//    public int Z { get; set; }

//    // Constructor 1: Default
//    public Point3D() : this(0, 0, 0) { }

//    // Constructor 2: X only
//    public Point3D(int x) : this(x, 0, 0) { }

//    // Constructor 3: X & Y
//    public Point3D(int x, int y) : this(x, y, 0) { }

//    // Constructor 4: X, Y & Z (Main constructor)
//    public Point3D(int x, int y, int z)
//    {
//        X = x;
//        Y = y;
//        Z = z;
//    }


//#endregion
//#region 2.
//  public override string ToString()
//    {
//        return $"Point Coordinates: ({X}, {Y}, {Z})";
//    }
//}
//#endregion
//#region 3. 
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter coordinates for Point P1:");
//        Point3D P1 = ReadPoint();

//        Console.WriteLine("\nEnter coordinates for Point P2:");
//        Point3D P2 = ReadPoint();

//        Console.WriteLine($"\nP1: {P1}");
//        Console.WriteLine($"P2: {P2}");
//    }


//    static Point3D ReadPoint()
//    {
//        int x = ReadInt("X");
//        int y = ReadInt("Y");
//        int z = ReadInt("Z");

//        return new Point3D(x, y, z);
//    }

//    static int ReadInt(string coordName)
//    {
//        int value;

//        while (true)
//        {
//            Console.Write($"Enter {coordName}: ");
//            string input = Console.ReadLine();


//            if (int.TryParse(input, out value))
//                return value;


//            try
//            {
//                value = int.Parse(input);
//                return value;
//            }
//            catch
//            {
//                Console.WriteLine("Parse failed!");
//            }


//            try
//            {
//                value = Convert.ToInt32(input);
//                return value;
//            }
//            catch
//            {
//                Console.WriteLine("Convert failed! Please enter a valid integer.");
//            }
//        }
//    }
//}

//#endregion
#region 4. 
using System;

public class Point3D : IComparable<Point3D>
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Point3D(int x, int y, int z)
    {
        X = x; Y = y; Z = z;
    }

    public override string ToString()
    {
        return $"Point Coordinates: ({X}, {Y}, {Z})";
    }

    public override bool Equals(object obj)
    {
        if (obj is Point3D other)
            return X == other.X && Y == other.Y && Z == other.Z;
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y, Z);
    }

  
    public static bool operator ==(Point3D p1, Point3D p2)
    {
        if (ReferenceEquals(p1, null) && ReferenceEquals(p2, null))
            return true;
        if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
            return false;
        return p1.Equals(p2);
    }

    public static bool operator !=(Point3D p1, Point3D p2)
    {
        return !(p1 == p2);
    }

 
    public int CompareTo(Point3D other)
    {
        if (X == other.X)
            return Y.CompareTo(other.Y);
        return X.CompareTo(other.X);
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Point3D P1 = new Point3D(10, 20, 30);
        Point3D P2 = new Point3D(10, 20, 30);

        Console.WriteLine($"P1: {P1}");
        Console.WriteLine($"P2: {P2}");

        if (P1 == P2)
            Console.WriteLine("P1 and P2 are Equal");
        else
            Console.WriteLine("P1 and P2 are NOT Equal");

   
        Point3D[] points = {
            new Point3D(3,5,1),
            new Point3D(1,2,4),
            new Point3D(1,1,0),
            new Point3D(2,3,3),
            new Point3D(1,2,4) 
        };

        Array.Sort(points);

        Console.WriteLine("\nSorted Points:");
        foreach (var point in points)
            Console.WriteLine(point);
    }
}



#endregion
//#region 5. 
//using System;

//public class Point3D : IComparable<Point3D>, ICloneable
//{
//    public int X { get; set; }
//    public int Y { get; set; }
//    public int Z { get; set; }


//    public Point3D() : this(0, 0, 0) { }
//    public Point3D(int x) : this(x, 0, 0) { }
//    public Point3D(int x, int y) : this(x, y, 0) { }
//    public Point3D(int x, int y, int z)
//    {
//        X = x; Y = y; Z = z;
//    }


//    public override string ToString()
//    {
//        return $"Point Coordinates: ({X}, {Y}, {Z})";
//    }


//    public override bool Equals(object obj)
//    {
//        if (obj is Point3D other)
//            return X == other.X && Y == other.Y && Z == other.Z;
//        return false;
//    }

//    public override int GetHashCode()
//    {
//        return HashCode.Combine(X, Y, Z);
//    }

//    public static bool operator ==(Point3D p1, Point3D p2)
//    {
//        if (ReferenceEquals(p1, null) && ReferenceEquals(p2, null))
//            return true;
//        if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
//            return false;
//        return p1.Equals(p2);
//    }

//    public static bool operator !=(Point3D p1, Point3D p2)
//    {
//        return !(p1 == p2);
//    }

//    // IComparable → Sort by X then Y
//    public int CompareTo(Point3D other)
//    {
//        if (X == other.X)
//            return Y.CompareTo(other.Y);
//        return X.CompareTo(other.X);
//    }

//    // ICloneable → Deep Copy
//    public object Clone()
//    {
//        return new Point3D(X, Y, Z);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter coordinates for Point P1:");
//        Point3D P1 = ReadPoint();

//        Console.WriteLine("\nEnter coordinates for Point P2:");
//        Point3D P2 = ReadPoint();

//        Console.WriteLine($"\nP1: {P1}");
//        Console.WriteLine($"P2: {P2}");


//        if (P1 == P2)
//            Console.WriteLine("P1 and P2 are Equal");
//        else
//            Console.WriteLine("P1 and P2 are NOT Equal");


//        Point3D[] points = {
//            new Point3D(3,5,1),
//            new Point3D(1,2,4),
//            new Point3D(1,1,0),
//            new Point3D(2,3,3),
//            new Point3D(1,2,4) 
//        };

//        Array.Sort(points);

//        Console.WriteLine("\nSorted Points:");
//        foreach (var point in points)
//            Console.WriteLine(point);


//        Point3D cloneP1 = (Point3D)P1.Clone();
//        Console.WriteLine($"\nCloned P1: {cloneP1}");
//    }

//    static Point3D ReadPoint()
//    {
//        int x = ReadInt("X");
//        int y = ReadInt("Y");
//        int z = ReadInt("Z");

//        return new Point3D(x, y, z);
//    }

//    static int ReadInt(string coordName)
//    {
//        int value;
//        while (true)
//        {
//            Console.Write($"Enter {coordName}: ");
//            string input = Console.ReadLine();

//            if (int.TryParse(input, out value))
//                return value;

//            Console.WriteLine("Invalid input! Please enter an integer.");
//        }
//    }
//}
//#endregion
#endregion
