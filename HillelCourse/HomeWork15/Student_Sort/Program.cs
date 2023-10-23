namespace Student_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Student student = new Student();

            student.AddStudent(new Student { Name = "Олена", Grade = 95, Course = 3 });
            student.AddStudent(new Student { Name = "Іван", Grade = 88, Course = 2 });
            student.AddStudent(new Student { Name = "Марія", Grade = 92, Course = 3 });
            student.AddStudent(new Student { Name = "Петро", Grade = 78, Course = 2 });
            student.AddStudent(new Student { Name = "Анна", Grade = 90, Course = 3 });
            student.AddStudent(new Student { Name = "Василь", Grade = 85, Course = 2 });

            // Фільтрація: Знайдіть усіх студентів, які мають оцінку більше або рівну 90.
            student.FilterStudent();
            // Сортування: Відсортуйте студентів за оцінкою в спадаючому порядку.
            student.SortStudent();
            // Групування: Згрупуйте студентів за курсами і виведіть список студентів на кожному курсі.
            student.GroupStudent();
            // Підрахунок: Порахуйте кількість студентів на кожному курсі.
            student.CountStudent();
            // Проекція: Створіть список рядків, які містять ім'я та оцінку кожного студента.
            student.ListOfStudents();
            Console.ReadKey();
        }
    }
}