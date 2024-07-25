using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace employee
{

    internal class Employee
    {
        public Employee() { }

        public string Id 
            { get { return _id; } set 
            {
                if ( string.IsNullOrEmpty(value) || value.Length != 9 || !Regex.IsMatch(value, @"^\d{9}$"))
                {
                    throw new ArgumentException("Inpot is not valid!");
                }
                _id = value;
            }
        }
        public string FirstName 
            { get { return _firstName; } set
            {
                if (string.IsNullOrEmpty(value) || Regex.IsMatch(value, @"[^a-zA-Z]"))
                {
                    throw new ArgumentException("First name must be non-empty and contain only letters.");
                }
                _firstName = value;
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrEmpty(value) || Regex.IsMatch(value, @"[^a-zA-Z]"))
                {
                    throw new ArgumentException("Last name must be non-empty and contain only letters.");
                }
                _lastName = value;
            }
        }
       
        public string FullName { get { return FirstName + LastName; } }
        public DateTime Date { get; set; }
        public int Age { get { return DateTime.Now.Year - Date.Year; } }
        public string Street { get; set; }
        public int Number { get; set; }
        public string City { get; set; }
        public string Adress { get { return $"{City}, {Street}, {Number}"; } }
        public bool IsMale { get; set; }
        public string MaritalStatus { get; set; }
        public byte[] Picture { get; set; }
        public int Landline 
            { get { return _landLine; } set
            {

            } 
        }
        public int CellPhone { get; set; }
        public int Code { get; set; }

        private string _id;
        private string _firstName;
        private string _lastName;
        private int _landLine;
        private int _cellPhone;
    }
}
