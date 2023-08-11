using System.Text;

namespace SingleResponsability;
public class ExportHelper
{
    public static void ExportStudent(IEnumerable<Student> students)
    {
        string csv = String.Join(",", students.Select(x => x.ToString()).ToArray());
        System.Text.StringBuilder sb = new();
        sb.AppendLine("Id;Fullname;Grades");
        foreach (var item in students)
        {
            sb.AppendLine($"{item.Id};{item.Fullname};{string.Join("|", item.Grades)}");
        }
        System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), Encoding.Unicode);
    }
}