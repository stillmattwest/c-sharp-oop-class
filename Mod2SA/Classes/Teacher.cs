using System.Collections.Generic;
public class Teacher : Person
{

    public List<string>Subjects = new List<string>();

    public Teacher(string fn, string ln){
        LastName = ln;
        FirstName = fn;
    }
}