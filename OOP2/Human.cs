using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP2
{
    public abstract class Human
    {
        private string firstName, lastName;
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName
        {
            get 
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name can not be empty!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name can not be empty!");
                }
                this.lastName = value;
            }
        }
    }
}