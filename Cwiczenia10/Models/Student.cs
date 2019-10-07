using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia10.Models
{

    public class Student
    {
        public static int id;

        public int IdStudent;
        [Required(ErrorMessage = "Imie jest wymagane")]
        public string FirstName;
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        public string LastName;
        public string Studies;



        public Student(string FirstName, string LastName, string Studies)
        {

            this.IdStudent = id;
            id = IdStudent;
            id++;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Studies = Studies;
            
        }

        public Student()
        {
            this.IdStudent = id;
            id = IdStudent;
            id++;
        }
    }
}
