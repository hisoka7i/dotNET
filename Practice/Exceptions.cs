namespace Exceptions;

public class ExceptionsTest{
    public void checkedEx(){
        checked{
            int x = int.MaxValue;
            try{Console.WriteLine(x+10);}
            catch(OverflowException oe){
                Console.WriteLine(oe.Message);
            }
            
        }  
    }
    public void unCheckedEx(){
        unchecked{
            int x = int.MaxValue;
            Console.WriteLine(x+10);
        }        
    }
}