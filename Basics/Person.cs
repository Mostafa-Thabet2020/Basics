using System;

namespace Basics
{
    public class Person
    {
        //modifier + data type + name
        public string firstName;
        public string lastName;
        public DateTime birthDay;
        public string Address;
        public double height;

        private string Name;// Private Modifier can not use out of this class
        public string FullName()// modifier + returning data type + function name
        {
            //Name = firstName + lastName; //easit way
            Name = $"Client full name is: {firstName} {lastName}"; //active
            //Name = string.Concat(firstName+lastName);
            return Name;
        }

        private DateTime today = DateTime.Now; // Date of today
        private int Age;

        public int CalAge()
        {
            Age = today.Year - birthDay.Year;
            return Age;
        }
    }

}
