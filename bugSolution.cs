public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    // Removed implicit operators
    // public static implicit operator int(MyClass obj) { return obj.MyProperty; }
    // public static implicit operator MyClass(int value) { return new MyClass(value); }

    public static explicit operator int(MyClass obj)
    {
        return obj.MyProperty;
    }

    public static explicit operator MyClass(int value)
    {
        return new MyClass(value);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(5); // Explicit creation
        int value = (int)obj1; // Explicit conversion from MyClass to int

        MyClass obj2 = new MyClass(10);
        int result = (int)obj2 + 5; // Explicit conversion from MyClass to int before addition

        Console.WriteLine(value); // Output: 5
        Console.WriteLine(result); // Output: 15
    }
}