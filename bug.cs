public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass obj)
    {
        return obj.MyProperty;
    }

    public static implicit operator MyClass(int value)
    {
        return new MyClass(value);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyClass obj1 = 5; // Implicit conversion from int to MyClass
        int value = obj1; // Implicit conversion from MyClass to int

        MyClass obj2 = new MyClass(10);
        int result = obj2 + 5; // Implicit conversion from MyClass to int and then addition

        Console.WriteLine(value); // Output: 5
        Console.WriteLine(result); // Output: 15
    }
}