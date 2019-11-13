using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP2
{
    public class Worker : Human
    {
        int weekSalary = 0;
        int workHours = 0;
        
        public Worker(string firstName, string lastName, int weekSalary, int workHours) :base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHours;
        }

        public int WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHours;
            }
            set
            {
                this.workHours = value;
            }
        }

        public int MoneyPerHour()
        {
            int daySalary = weekSalary / 5;
            int moneyPerHour = daySalary / workHours;

            return moneyPerHour;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}\nWeek salary: {2}\nWork hours/day: {3}\nMoney/hour: {4}\n", this.FirstName, this.LastName, this.weekSalary, this.workHours, MoneyPerHour());
        }
    }
}