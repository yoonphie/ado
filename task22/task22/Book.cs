using System;
using System.Collections.Generic;
using System.Text;

namespace task22
{
    class Book
    {
      
        private string name;
        private int pages;
        private string publisher;
        private DateTime? publicationDate;
        private DateTime? writtenDate;
        private Author author;
   

 
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
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                if (value > 0)
                {
                    pages = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect number of pages!");
                }
            }
        }
        public string Publisher
        {
            get
            {
                return publisher;
            }
            set
            {
                if (value != null)
                {
                    publisher = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect name of publisher!");
                }
            }
        }
        public DateTime? PublicationDate
        {
            get
            {
                return publicationDate;
            }
            set
            {
                if (value != null)
                {
                    publicationDate = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect date!");
                }
            }
        }
        public DateTime? WrittenDate
        {
            get
            {
                return writtenDate;
            }
            set
            {
                if (value != null && value <= publicationDate)
                {
                    writtenDate = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect date!");
                }
            }
        }
        public Author Author
        {
            get
            {
                return author;
            }
            set
            {
                if (value != null && value.BirthYear <= ((DateTime)WrittenDate).Year)
                {
                    author = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect!");
                }
            }
        }
        
        public Book(string name, int pages, string publisher, DateTime? publicationDate, DateTime? writtenDate, Author author)
        {
            Name = name;
            Pages = pages;
            Publisher = publisher;
            PublicationDate = publicationDate;
            WrittenDate = writtenDate;
            Author = author;
        }

        public override string ToString()
        {
            return this.name + ", " + this.pages + " page, publisher - " + this.publisher +
                ", publication date -  " + this.publicationDate + ", written gate - " + this.writtenDate +
                ", author - " + Author.ToString();
        }
        
    }
}
