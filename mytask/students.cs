namespace mytask{

class students{
    string genders ,studentsnames ,startingtime ,closingtime , trainer ,sessions;
    
    
    public students() {
        genders="boys, girls";
        studentsnames="alex ,basheer ,santy ,aarif ,denial ,nancy ,pavithra ";
        startingtime="2 to 6pm";
        closingtime="6 pm";
        trainer="Dr.KarthickAg";
        sessions="lab ,class ,fun ";
        
        
    }

    public string getgenders(){
        return genders;
    }

      public string getstudentsnames(){
        return studentsnames;
    }

     public string getstartingtime(){
        return startingtime;
    } 

    public string getclosingtime(){
        return closingtime;
    }

     public string gettrainer(){
        return trainer;
    }
 
  public string getsessions(){
        return sessions;
    }
}



}