using System;

namespace Mod2SA
{
    class Program
    {
        static void Main(string[] args)
        {
            UProgram IT = new UProgram("Information Technology");

            Course ProgrammingWithCSharp = new Course("Programming With C#");

            Student mWest = new Student("Matt","West");

            Student lWest = new Student("Lynne","West");

            Student rWest = new Student("Riley","West");

            Teacher ltWest = new Teacher("Logan","West");

             ProgrammingWithCSharp.Students.Add(mWest);

             ProgrammingWithCSharp.Students.Add(lWest);
             
             ProgrammingWithCSharp.Students.Add(rWest);

             ProgrammingWithCSharp.Teachers.Add(ltWest);

             Degree Bachelor = new Degree("Bachelor");

             Bachelor.Courses.Add(ProgrammingWithCSharp);

             IT.DegreePrograms.Add(Bachelor);

             Console.WriteLine(IT.ProgramName);

             IT.DegreePrograms.ForEach(e => Console.WriteLine(e.DegreeName));

             Bachelor.Courses.ForEach(e => Console.WriteLine(e.CourseName));

             Console.WriteLine(ProgrammingWithCSharp.Students.Count);
        }
    }
}
