using System.Collections.Generic;

public class Course{
    public string CourseName { get; set; }
   public List<Student> Students = new List<Student>();

   public List<Teacher> Teachers = new List<Teacher>();

   public Course(string name){
       CourseName = name;
   }
}