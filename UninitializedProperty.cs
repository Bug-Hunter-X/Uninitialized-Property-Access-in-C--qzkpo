public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized can lead to unexpected behavior.
        int value = MyProperty; //Uninitialized value
        Console.WriteLine(value); //value will be 0, may not always be expected
    }
}