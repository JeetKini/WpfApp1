namespace Day5
{
    public class Student  {
        
      public  int id;
        public string name; 
      
        public Student() {
        
        }

        public Student(int id) 
        :this()
        {
        this.id = id;
            
        }
    

        public Student(int id,string name)
        :this(id)
        { 
        this.id = id;
        this.name = name;
        }
       

    }
}
