using GenericsExercise.Console.Given;
using GenericsExercise.Console.Given.Services;

namespace GenericsExercise.Console
{
    public class Program
    {
        static ApplicationService<Student> studentsService = new ApplicationService<Student>();
        static ApplicationService<University> uniService = new ApplicationService<University>();

        static void Main(string[] args)
        {

            Student mockStud = new Student() { Id = "01", FisrtName = "Adrian", LastName = "Tipa"};
            University mockUni = new University() { Id = "001", Address = "Iasi", Name = "Al. Ioan Cuza" };

            studentsService.insertUser(mockStud);
            uniService.insertUser(mockUni);

            System.Console.WriteLine(studentsService.getUsers());
            foreach(var aux in uniService.getUsers())
            {
                System.Console.WriteLine("{0}", aux);

            }
        }
    }
}