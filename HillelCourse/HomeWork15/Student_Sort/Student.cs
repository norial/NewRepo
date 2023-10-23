using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Sort
{
    internal class Student
    {
        List<Student> students;
        public Student()
        {
            students = new List<Student>();
        }
        public string Name { get; set; }
        public int Grade { get; set; }
        public int Course { get; set; }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        // Фільтрація: Знайдіть усіх студентів, які мають оцінку більше або рівну 90.
        public void FilterStudent()
        {
            var highAchievers = students.Where(student => student.Grade >= 90);
            Console.WriteLine("Студенти з оцінкою 90 і вище:");
            foreach (var student in highAchievers)
            {
                Console.WriteLine($"Ім'я: {student.Name}, Оцінка: {student.Grade}, Курс: {student.Course}");
            }
            Console.WriteLine();
        }
        // Сортування: Відсортуйте студентів за оцінкою в спадаючому порядку.
        public void SortStudent()
        {
            var sortedStudents = students.OrderByDescending(student => student.Grade);
            Console.WriteLine("\nСтуденти відсортовані за оцінкою в спадаючому порядку:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Ім'я: {student.Name}, Оцінка: {student.Grade}, Курс: {student.Course}");
            }
            Console.WriteLine();
        }
        // Групування: Згрупуйте студентів за курсами і виведіть список студентів на кожному курсі.
        public void GroupStudent()
        {
            var groupedByCourse = students.GroupBy(student => student.Course);
            Console.WriteLine("\nГрупування студентів за курсами:");
            foreach (var courseGroup in groupedByCourse)
            {
                Console.WriteLine($"Курс {courseGroup.Key}:");
                foreach (var student in courseGroup)
                {
                    Console.WriteLine($"Ім'я: {student.Name}, Оцінка: {student.Grade}");
                }
            }
            Console.WriteLine();
        }
        // Підрахунок: Порахуйте кількість студентів на кожному курсі.
        public void CountStudent()
        {
            var countByCourse = students.GroupBy(student => student.Course)
                .Select(group => new { Course = group.Key, Count = group.Count() });
            Console.WriteLine("\nКількість студентів на кожному курсі:");
            foreach (var courseCount in countByCourse)
            {
                Console.WriteLine($"Курс {courseCount.Course}: {courseCount.Count} студентів");
            }
            Console.WriteLine();
        }
        // Проекція: Створіть список рядків, які містять ім'я та оцінку кожного студента.
        public void ListOfStudents()
        {
            var projection = students.Select(student => $"Ім'я: {student.Name}, Оцінка: {student.Grade}");
            Console.WriteLine("\nПроекція студентів на рядки:");
            foreach (var info in projection)
            {
                Console.WriteLine(info);
            }
            Console.WriteLine();
        }
    }
}
