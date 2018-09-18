using System.Collections.Generic;
public class UProgram{
    public string ProgramName { get; set; }
    public List<Degree> DegreePrograms = new List<Degree>();

    public UProgram(string name){
        ProgramName = name;
    }
}