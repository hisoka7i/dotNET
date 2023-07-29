using practice;
using interface3;
using gen;
using Collect;
using System.Collections.Generic;
using FuncDelegate;
using Exceptions;
using PredicateDelegate;
using student;

Practice1 practice1 = new Practice1();
Program<int> program = new Program<int>(); 
Program<float> program2 = new Program<float>();
FunctDelegate functDelegate = new FunctDelegate();
//CollectionEx collectionEx = new CollectionEx();
Predelegate predicateDelegate= new Predelegate(); 
ExceptionsTest exceptionsTest = new ExceptionsTest();
  
exceptionsTest.checkedEx();
exceptionsTest.unCheckedEx();
    //list.Add(43);

Func<int, int, int> add = functDelegate.addNum;
Predicate<int> predicate = predicateDelegate.checkif;

//Anonymous types

var studentExample = new {rollNo=1, firstname="Sasuke", lastname="Uchiha"};

Console.WriteLine("This is anonymous type student roll number: "+studentExample.rollNo);



Console.WriteLine("The output of predicate delegate is "+predicate(9));

Console.WriteLine("This is output of functional delegate "+add(4,21));
List<int> list = new List<int>();
IDictionary<string,string> dictionary = new Dictionary<string,string>();   
ICollection<string> list2 = new List<string>();
//IDictionary<Tkey,TValue> hash = new HashTable<Tkey, Tvalue>();


list.Add(99);
list.Add(91);
list.Add(89);
list.Add(99);


list2.Add("Hisoka");
list2.Add("Gojo");
list2.Add("Marumi");

foreach(object o in list){
    Console.WriteLine("The object is correspoding list is "+o.ToString());
}


dictionary.Add("first","Book number 1");
dictionary.Add("second","Book number 2");
dictionary.Add("third","Book number 3");

//foreach(Object s in dictionary){
//    Console.WriteLine(s.Key+"---> key "+s.Value+" --> value");
//}

Console.WriteLine("Elements of the list :"+list);

program.println1(99);
program.genMethod<int>(34);
program2.println1(10.22f);
program2.genMethod<float>(34.33f);

Interface2 interface2= practice1;
interface2.methodOne();
interface2.methodTwo();

Struct1 struct1=new Struct1(); 
struct1.x=9;
int?xNull=null;

Console.WriteLine("The value inside the structure is: "+struct1.x);
Console.WriteLine("This is a nullable type"+xNull);