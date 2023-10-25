using System;

namespace Penkov_Lab_1.Models
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private DateTime birthday;

        public Person(
            string firstName,
            string lastName,
            DateTime birthday)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
        }

        public Person()
        {
            this.firstName = "Penkov";
            this.lastName = "Stepan";
            this.birthday = new DateTime(2004, 10, 23);
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public DateTime Birthday
        {
            get { return this.birthday; }
            set { this.birthday = value; }
        }

        public int BirthdayYear
        {
            get { return this.birthday.Year; }
            set
            {
                this.birthday = new DateTime(
                value,
                this.birthday.Month,
                this.birthday.Day);
            }
        }

        public override string ToString()
        {
            return $"Name: {this.firstName} Last name: {this.lastName} birthday: {this.birthday}";
        }

        public virtual string ToShortString()
        {
            return $"{this.firstName} {this.lastName}";
        }
    }
}