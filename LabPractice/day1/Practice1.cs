namespace Practice1;

class Practice{
    public string authorName{get;set;}
    public string bookName{get;set;}

    static Practice(){
        Console.WriteLine("This is a static constructor. It is called only once, doesn't matter the number of objects");
    }

    public Practice(){
        Console.WriteLine("This is a normal constructor!!");
    }

    public int add(params int [] values){
        int total=0;
        foreach(int i in values){
            total+=i;
        }
        return total;
    }

    public void methodOne(string firstparameter, string secondparameter){
        this.authorName = firstparameter;
        this.bookName = secondparameter;
        Console.WriteLine("The firstparameter: "+authorName);
        Console.WriteLine("The secondparameter: "+bookName);
    }
}
