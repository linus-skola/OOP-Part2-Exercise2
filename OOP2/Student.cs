using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP2
{
    public class Student : Human
    {
        private string grade;

        public Student(string firstName, string lastName, string grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }
        public string Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Grade can not be empty");
                }
                this.grade = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Name: {0} {1}\nGrade: {2}\n", this.FirstName, this.LastName, this.grade);
        }
    }
}