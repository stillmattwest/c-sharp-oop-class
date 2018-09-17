using System.Collections.Generic;
public class Student{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public Degree Major {get; set;}

    private static int StudentCount;

    public List<Course> Courses = new List<Course>();

    public Student(string fn, string ln){
        ++StudentCount;
    }

}