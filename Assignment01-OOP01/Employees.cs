using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_OOP01
{
    internal class Program
    {
        // Enums
        public enum SecurityLevel
        {
            Guest,
            Developer,
            Secretary,
            DBA
        }

        public enum Gender
        {
            Male,
            Female
        }

        // Class to hold hiring date data
        public class HiringDate
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

            public HiringDate(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }

            public override string ToString()
            {
                return $"{Day:D2}/{Month:D2}/{Year}";
            }
        }

        // Employee class
        public class Employee
        {
            // Private fields
            private int _id;
            private string? _name;
            private decimal _salary;
            private SecurityLevel _security;
            private HiringDate _hireDate;
            private Gender _gender;

            // Constructor
            public Employee(int id, string? name, decimal salary, SecurityLevel security, HiringDate hireDate, Gender gender)
            {
                _id = id;
                _name = name;
                _salary = salary;
                _security = security;
                _hireDate = hireDate;
                _gender = gender;
            }

            // Properties
            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }

            public string? Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public decimal Salary
            {
                get { return _salary; }
                set { _salary = value; }
            }

            public SecurityLevel Security
            {
                get { return _security; }
                set { _security = value; }
            }

            public HiringDate HireDate
            {
                get { return _hireDate; }
                set { _hireDate = value; }
            }

            public Gender Gender
            {
                get { return _gender; }
                set { _gender = value; }
            }

            // Override ToString
            public override string ToString()
            {
                return $"ID = {_id}\n" +
                       $"Name = {_name}\n" +
                       $"Salary = {String.Format("{0:C}", _salary)}\n" +
                       $"Security Level = {_security}\n" +
                       $"Hire Date = {_hireDate}\n" +
                       $"Gender = {_gender}";
            }
        }
    }
}
