using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<Student> studentList = new List<Student>();

            while (command[0] != "end")
            {
                Student student = new Student();
                student.FirstName = command[0];
                student.LastName = command[1];
                student.Age = int.Parse(command[2]);
                student.HomeTown = command[3];

                studentList.Add(student);

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            string city = Console.ReadLine();

            List<Student> filteredList = studentList.Where(x => x.HomeTown == city).ToList();
            foreach (var item in filteredList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
            }
        }
    }
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
}
