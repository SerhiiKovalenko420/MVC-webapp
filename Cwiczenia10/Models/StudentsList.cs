using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia10.Models
{
    public class StudentsList
    {
        public List<Student> students;
        private static StudentsList instance; 

        private StudentsList()
        {
            students = new List<Student>();
            students.Add(new Student("Jan", "Kovalski", "IT"));
            students.Add(new Student("Michal", "Jankowski", "IT"));
            students.Add(new Student("Maciej", "Kovalski", "Grafika"));
        }

        public static StudentsList getInstance()
        {
            if(instance == null)
            {
                instance = new StudentsList();
            }
            return instance;
        }






    }
}
