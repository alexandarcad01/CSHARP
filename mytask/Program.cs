namespace mytask{

class program {

    static void Main(string[] args){
         Brightskill br=new Brightskill();
        Console.WriteLine("Hi I am Dr.Pavithra IT kulumani");
        Console.WriteLine("courses "+br.getcourses());
        Console.WriteLine("workers "+br.getworkers());
        Console.WriteLine("Trainer "+br.gettrainer());

        cadbatch cb=new cadbatch();
        Console.WriteLine("Hi I am Dr.Pavithra IT kulumani");
        Console.WriteLine("programing languages "+cb.getprograming languages());
        Console.WriteLine("students"+cb.getstudents());
        Console.WriteLine("Trainer "+cb.gettrainer());
        Console.WriteLine("total time hours "+cb.gettotal time hours());
        
}
}
}