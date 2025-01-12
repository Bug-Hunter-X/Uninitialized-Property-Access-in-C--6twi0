public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass()
    {
        // Initialize the property in the constructor
        MyProperty = 0; // Or any other appropriate default value
    }

    public void MyMethod()
    {
        int value = MyProperty; // Now this line is safe
    }
}