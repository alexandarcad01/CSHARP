namespace mytask{

class cadbatch{
    string programinglanguages, students, trainer, totaltimehours;
    
    
    public cadbatch() {
        programinglanguages=" html, css, js, mysql, c#";
        students="boys, girls";
        trainer="Dr.KarthickAg";
        totaltimehours="four";
        
        
    }

    public string getprograminglanguages(){
        return programinglanguages;
    }

      public string getstudents(){
        return students;
    }

     public string gettrainer(){
        return trainer;
    }
 
  public string gettotaltimehours(){
        return totaltimehours;
    }
}



}