using Practice1;
using extensionMethod;
using partialclass;
using linqExample;

Practice practice = new Practice(){ //This is example of object initalizer
            authorName = "Robert Green",
            bookName = "48 laws of power"
        };
Practice practice1 = new Practice();
Partial1 partial1 = new Partial1();
LinqTest linqTest = new LinqTest();

        //practice.methodOne(secondparameter: "Goblet of fire", "Savita"); This will cause error. //OUTOF POSTION ERROR
        Console.WriteLine("The sum of:"+practice.add(23,3423,34,234,2,3));
        //Example of named parameter
        practice.methodOne(secondparameter:"48 laws of powers", firstparameter:"Robert Green");
        //Example of named parameter with positional parameter
        practice.methodOne(firstparameter:"Robert Green", "Laws of human nature");
        Console.WriteLine("The name of the author is: "+practice.authorName);
        Console.WriteLine("The name of the book is: "+practice.bookName);

ExtensionExample extensionExample = new ExtensionExample();
extensionExample.m1();
extensionExample.m2();
extensionExample.m3();

//Calling the partial class
partial1.add();
partial1.add2();
linqTest.linqMethod();
linqTest.linqMethod2();