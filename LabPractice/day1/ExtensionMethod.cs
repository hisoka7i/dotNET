
namespace extensionMethod;
using partialclass;
public class ExtensionExample{
    public int ExtentionId{get;set;}
    public void m1(){
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("This is method One");
    } 
    public void m2(){
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine("The is method Two");
    }

}
public static class ExtensionExample1{
    public static void m3(this ExtensionExample example){
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("This is extention method 3");
    }
}
