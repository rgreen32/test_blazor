// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Question.DoSomething();
// Question q = new(); -- Modern C# shorthand to declare an object without double typing the type
// Question q = new Question();
// q.DoSomething();

//static exercises:
//static method in an abstract class
//static method in an class
//static method in an interface



public class Question {
    public static void DoSomething()
    {   
        Console.WriteLine("I did it");
    }
}