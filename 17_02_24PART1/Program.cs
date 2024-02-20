// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Program{

  static void Main(string [] args){
    Console.WriteLine("Welcome To Class");
    test tt=new test();
    tt.PrintMSG();
    tt.PrintMSG2();

  }
}


public class test{
  string name="CAD BATCH01";

  public void PrintMSG(){
    Console.WriteLine(name);
  }

  public void PrintMSG2(){
    Console.WriteLine("hai ..! " + name);
  }

}









//class Programming{

//static void Main(string [] args){
    //Console.WriteLine("welcome to namespace demo1");
     //test tt=new test();
     //tt.print1();
       //                          }
         //       }

 //public class test{
   //string x="ALEXANDAR";
   //public void print1(){
     //Console.WriteLine(x);
   //}

 //}
