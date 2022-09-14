using System;
namespace DotNet.Docker
{
    public class Person
    {
        private string _middleName = "Granola Bar";

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public string MiddleName
        {
            get => _middleName;
            set => _middleName = value;
        }

        public string GetFullName()
        {
            return $"{FirstName} {_middleName} {LastName}";
        }
    }
}