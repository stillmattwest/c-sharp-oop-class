using System.Collections.Generic;
public class Teacher{
    public string LastName { get; set; }
    public string FirstName { get; set; }

    public List<string>Subjects = new List<string>();

    public Teacher(string fn, string ln){
        LastName = ln;
        FirstName = fn;
    }
}