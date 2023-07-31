namespace linqExample;
using System.Collections.Generic;

public class LinqTest{
    List<string> list = new List<string>();
    public LinqTest(){
        list.Add("Goku");
        list.Add("Vegeta");
        list.Add("Broly");
        list.Add("Gohan");
        list.Add("Trunks");
    }

    public void linqMethod(){
        var result = from items in list
                     where items.Contains("Gohan")
                     select items;
        foreach( var item in result){
            Console.WriteLine("This is result using query syntax "+item);
        }
       }
    public void linqMethod2(){
        var result = list.Where(x => x.Contains("Goku"));
        foreach( var item in result){
            Console.WriteLine("This is result using query method "+item);
        }
    }
}