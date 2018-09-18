using System.Collections.Generic;
public class Degree{
    public List<Course> Courses = new List<Course>();

    public string DegreeName { get; set; }

    public Degree(string name){
        DegreeName = name;
    }
}