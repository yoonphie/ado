using System;
using System.Collections.Generic;
using System.Text;

namespace task22
{
    class Author
    {
        
        private string name;
        private string surname;
        private int birthYear;
       
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect name!");
                }
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (value != null)
                {
                    surname = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect suname!");
                }
            }
        }
        public int BirthYear
        {
            get
            {
                return birthYear;
            }
            set
            {
                if (value >= 0 && birthYear <= DateTime.Now.Year)
                {
                    birthYear = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect year of birth!");
                }
            }
        }

        public Author(string newName, string newSurname, int newBirthYear)
        {
            Name = newName;
            Surname = newSurname;
            BirthYear = newBirthYear;
        }

        public override string ToString()
        {
            return Name + " " + Surname + " " + BirthYear;
        }

    }
}
