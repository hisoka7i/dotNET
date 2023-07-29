namespace gen;
public class Program<T>{

    public void genMethod<X>(T value) where X : struct{
        Console.WriteLine("The value of generic method is "+value);
    }
    public void println1(T value){
        Console.WriteLine("The value of the generic is "+value);
    }
}