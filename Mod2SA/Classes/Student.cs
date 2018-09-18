using System.Collections.Generic;
public class Student : Person
{
    public Degree Major {get; set;}

    private static int StudentCount;

    public List<Course> Courses = new List<Course>();

    public Student(string fn, string ln){
        ++StudentCount;
        LastName = ln;
        FirstName = fn;
    }

}