namespace reflectionExample;

[AttributeUsage(AttributeTargets.All, AllowMultiple =false, Inherited =true)]
public class FirstAttribute: Attribute{
    private string firstname;

    public string Firstname{
        get{return firstname;}
        set{this.firstname=value;}
    }
}