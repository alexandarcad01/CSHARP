namespace mytask{

class Brightskill{
    string courses, workers, trainer ;
    
    
    public Brightskill() {
        courses="aibatch , cadbatch";
        workers="nightshift";
        trainer="Dr.KarthickAg";
        
        
    }

    public string getcourses(){
        return courses;
    }

      public string getworkers(){
        return workers;
    }

     public string gettrainer(){
        return trainer;
    }

}



}