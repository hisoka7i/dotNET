namespace partialclass;
public partial class Partial1{
    public int PartialId{get;set;}
    public string PartialName{get;set;} 

    public Partial1(){
        this.PartialId=10;
        this.PartialName="Partial class 1";
    }

    public void add(){
        Console.WriteLine("The is a partial class add method: "+(PartialId+12));
        return;
    }
}

public partial class Partial1
{
    public void add2() => Console.WriteLine("This is metthod of partial class 2");
    //public partial void display();
}