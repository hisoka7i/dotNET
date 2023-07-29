namespace student;

public class StudentExample{
    public int RollNumber{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}

    public StudentExample(){
        this.RollNumber = 1;
        this.FirstName = "Jojo";
        this.LastName = "Fusiguru";
    }

    public StudentExample(int RollNumber, string Firstname, string Lastname){
        this.RollNumber = RollNumber;
        this.FirstName = Firstname;
        this.LastName = Lastname;
    }
}