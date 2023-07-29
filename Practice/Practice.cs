using interface3;
using System.ComponentModel;


namespace practice;

struct Struct1{
    public int x{get;set;}

}
public class Practice1:IDisposable, Interface2{
    //methodOne();
    public void methodOne(){
        Console.WriteLine("This default methodOne was overridden");
    }
    public void methodTwo(){
        Console.WriteLine("This is methodTwo"); 
    }

    public void Dispose(){
        Console.WriteLine("This is over ridden dispose function. It is used to release un managed resources");
    }

    ~Practice1(){
        Console.WriteLine("This is a destructor");
    }
}