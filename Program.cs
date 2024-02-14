using DelegatesAssignment;
using static System.Formats.Asn1.AsnWriter;
using System.Runtime.Intrinsics.Arm;
using System.Xml.Linq;
using static DelegatesAssignment.CustomSort;

class Program
{

    public static List<Student> students = new List<Student>();

    public static void Main(string[] args)
    {

        students.Add(new Student
        {
            Id = 100,
            Name = "Ram",
            Age = 15,
            Score = 99
        });
        students.Add(new Student {
            Id = 121,
            Name = "Arjun",
            Age = 19,
            Score = 89.8

        });
        students.Add(new Student
        {
            Id = 101,
            Name = "Rahul",
            Age = 15,
            Score = 99.9
        });
        students.Add(new Student
        {
            Id = 102,
            Name = "Riya",
            Age = 16,
            Score = 78.5
        });

        




        CustomSort customSort = new CustomSort();
        
        customSort.BubbleSort(students,Compare);


        for (var i = 0; i < students.Count; ++i)
        {
            Console.WriteLine(students[i]);
        }




    }
    public static int Compare(Student S1, Student S2)
    {


        int res = S1.Age.CompareTo(S2.Age);

        return res;

    }
}