
using CombineStrings;

public class Program
{
    //This class is for testing the functionality of the CombineStrings program.
    //The stringsLab.combine method should return the combination of two Strings 
    //(ex. "String1" + "String2" = "String1String2")
    static void Main()
    {
        Console.WriteLine("The stringLab.combine method should combine two Strings together.");

        //create a new instance of stringLab.
        stringLab sl = new stringLab();

        //create a couple tests for the stringLab.combine method.
        Console.WriteLine
            ("Here's what stringLab.combine returns when provided values 'abc' and 'xyz': ");
        String p1val1 = "abc";
        String p1val2 = "xyz";
        String output1 = sl.Combine(p1val1, p1val2);
        Console.WriteLine(output1);

        Console.WriteLine
            ("Here's what stringLab.combine returns when provided value 'hello' and 'world': ");
        String p2val1 = "hello";
        String p2val2 = "world";
        String output2 = sl.Combine(p2val1, p2val2);
        Console.WriteLine(output2);

    }

}