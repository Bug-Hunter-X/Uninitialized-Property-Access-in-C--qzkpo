public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int initialValue)
    {
        MyProperty = initialValue; //Initialize property in constructor
    }

    public void MyMethod()
    {
        int value = MyProperty; 
        Console.WriteLine(value); 
    }
}