using GenericsExercise.Console.Given;
using GenericsExercise.Console.Given.Services;

namespace GenericsExercise.Console
{
    public class Program
    {
        static void Main(string[] args)
        {

            Student mockStud = new Student() { Id = "01", FisrtName = "Adrian", LastName = "Tipa"};
            University mockUni = new University() { Id = "001", Address = "Iasi", Name = "Al. Ioan Cuza" };
            Menu menu = new Menu();
            menu.mainMenu();

        }
    }
}