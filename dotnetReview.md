.NET App Review

C# Terms/Questions:

    OOP Stands for? Object Oriented Programming
    4 Pillars of OOP? - 
        Abstraction, 
            breaking a subject down into it's components

        Encapsulation, 
            The accessibility of items that are included in a particular section of code
            Accessor keywords - 
                public, open to everyone
                private, only accessible in the same class
                internal, only accessible in the same namespace
                protected, only accessible by a child class
        Inheritance, 
            ability of classes to inherit: 
            classes can pass down functions and properties to be used in other classes
            Child classes also implicity have the same type as their parent(or parent parent's etc) type
        Polymorphism
            The ability of a child class/object/method/property to be inherited, but overriden by a child

    What is Garbage Collection?
        Memory Management to free up space

    What is the .NET Runtime?
        CLR - Common Language Runtime
        C# is compiled into CLR machine code, JIT compiled into machine assembly code alongside a garbage collector

    Do you need an Object to call static methods? no


    What method is the entry point for your Program? the Main method

    What kinds of Classes define our API Endpoints in a MVC App? Controllers

    How many classes can a class inherit from? 1

    How many interfaces can a class implement? infinity

    What are the differences between Interfaces and Classes? 
    intefaces only contain methods; classes contains fields/properties/variables and methods


    What is an abstract class? 
    - a class that can't be instantiated and would have to be inherited from to make use of
    - defines shared attributes for derived/child classes

    void SomeMethod(); // declaration

    //definition / implementation
    void SomeMethod()
    {
        Console.WriteLine("Do Something");
    }

BONUS Questions:
    What is MVC? 
    Model View Controller - Generic App Architecture 

    Model
        class Soda
        {
            int Size;
            string Name;
        }
    View
    Soda.cshtml
    @model Soda
        <div>
            <h1>Model.Name</h1>
            <p>Size: Model.Size</p>
        </div>

    Sodas.cshtml
    @model Soda[]
        @foreach(Soda s in Model) {
            <div>
                <h1>s.Name</h1>
                <p>Size: s.Size</p>
            </div>
        }

    Controller
        class SodaController
        {
            [Route("/Soda/Get/{id}")]
            [HttpGet]
            GetSoda(int id)
            {
                Soda = new Soda(id);
                return View(Soda);
            }

            GetSodas()
            {
                Soda[] s = db.Sodas.ToArray();
                return View(s);
            }
        }
OUTPUT
    URL/Soda/Get/1
        <div>
            <h1>Tahitian Treat</h1>
            <p>Size: 2 Liter</p>
        </div>

    URL/Sodas
        <div>
            <h1>Tahitian Treat</h1>
            <p>Size: 2 Liter</p>
        </div>
        <div>
            <h1>Coke</h1>
            <p>Size: 2 Liter</p>
        </div>
        <div>
            <h1>Mr Fizz</h1>
            <p>Size: 2 Liter</p>
        </div>

        int Example = 0;
        int NEx2 = null; //null error
        int? ValidNull = null


Other architectures:
    MVP - Presenter
    MVVM - ViewModel
    MV*

We'll round robin answer questions @ 10:10


Week 21 Lab Overview
 
create new apps with Identity Framework
    dotnet new blazor --auth Individual -uld