using System.Linq;
namespace day1EF
{

    public class Subject
    {
        public int Code {  get; set; }
        public String Name { get; set; }

    }
    public class Student
    {
        public int ID { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List <Subject> subjects { get; set; }

    }






    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
                
            List<int> list = new List<int>() {2,4,6,7,1,4,2,9,1 };
            var q = list.Distinct().OrderBy(n=>n);


            var q2 = list.Distinct().OrderBy(n => n).Select(n=>new {number = n , mul = n*n});





            String[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            var q3 = names.Where(n => n.Length == 3);

            var q4 = names .Where (n => n.ToLower().Contains("a")).OrderBy(n=>n.Length);
            var q5 = names.Take(2);


            List<Student> students = 
                new List<Student>() { new Student() { ID = 1, FirstName = "Ali", LastName = "Mohammed", subjects 
                = new List<Subject> { new Subject() { Code = 10, Name = "math" } } } };

            var q6 = students.Select(s => new { fullneam = s.FirstName + "" + s.LastName, subcount = s.subjects.Count });



            var q7 = students.OrderByDescending(n=> n.FirstName).ThenBy(n => n.LastName);



            var q8 = students.SelectMany(s => s.subjects,
                                (s, subj) => new { s.FirstName, Subject = subj.Name });


            var q9 = students.SelectMany(s => s.subjects.Select(subj => new { s.FirstName, subj.Name }))
                    .GroupBy(x => x.Name);

        }
    }
}
