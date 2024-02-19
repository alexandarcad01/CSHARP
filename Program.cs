// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//int a=10;
//Console.WriteLine(a);
//Console.WriteLine("the given value for a is" +a);

//int ,float , double ,string ,char ,long ,boolean ,array
//float b=26.5f;
//Console.WriteLine(b);
//Console.WriteLine("the given value for b is" +b);


//double c=10.5d;
//Console.WriteLine(c);
//Console.WriteLine("the given value for c is" +c);

//check datatypes
//Console.WriteLine(c.GetType());

//char s='z';
//Console.WriteLine(s);
//Console.WriteLine("the given value for s is " + s);
//Console.WriteLine(s.GetType());

//string app="welcome to all";
//Console.WriteLine(app);
//Console.WriteLine("the given value for c is " + app);
//Console.WriteLine(app.GetType());


*//int getvalue;
//getvalue=int.Parse(Console.ReadLine());
//Console.WriteLine("getvalue");
//Console.WriteLine("the given value through  console for getvalue  is " + getvalue);


class Program{

  static void Main(string [] args){
    Console.WriteLine("Welcome To Classes");
    test tt=new test();
    tt.PrintMSG();
    tt.PrintMSG2();

  }
}


public class test{
  string name="CAD BATCH 01";

  public void PrintMSG(){
    Console.WriteLine(name);
  }

  public void PrintMSG2(){
    Console.WriteLine("hi ..! " + name);
  }

}
