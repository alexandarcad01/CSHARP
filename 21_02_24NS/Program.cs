namespace dmkfamilydisp{

class Program{
    static void Main(string[] args){
      
        Kalaingar kr=new Kalaingar();
        Console.WriteLine("Hi I am Dr. Muthuvel Karunanithi (Kalaingar)");
        Console.WriteLine("I have "+kr.getHouse());
        Console.WriteLine("I have "+kr.getNewspaper());
        Console.WriteLine("I have "+kr.getpoliticalpartyname());
        Console.WriteLine("I have "+kr.getProductioncompany());
    }
}
}