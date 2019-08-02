using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML_Parsing_C_Sharp_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument document = XDocument.Load("./inputDoc/books.xml");
            #region Fetch All the Books 
            var books = from r in document.Descendants("book")
                        select new
                        {
                            Author = r.Element("author").Value,
                            Title = r.Element("title").Value,
                            Genere = r.Element("genre").Value,
                            Price = r.Element("price").Value,
                            PublishDate = r.Element("publish_date").Value,
                            Description = r.Element("description").Value,

                        };

            foreach (var r in books)
            {
                Console.WriteLine("Title:- " + r.Title + "\nPublish Date:- " + r.PublishDate + "\nAuthor:-" + r.Author + "\n\n");

            }

            Console.ReadKey(true);
            #endregion 


            /*
            
            #region Fetching a particular  Book            
            var selectedBook = from r in document.Descendants("book").Where
                                   (r=>(string)r.Attribute("id")=="bk102")
                        select new
                        {
                            Author = r.Element("author").Value,
                            Title = r.Element("title").Value,
                            Genere = r.Element("genre").Value,
                            Price = r.Element("price").Value,
                            PublishDate = r.Element("publish_date").Value,
                            Description = r.Element("description").Value,
 
                        };
 
            foreach (var r in selectedBook)
            {
                Console.WriteLine(r.PublishDate + r.Title + r.Author);
            }
            Console.ReadKey(true);
            #endregion 
 
          
 
            #region Fetching a particular  Book
 
          
            var selectedBookAttribute = (from r in document.Descendants("book").Where
                                        (r => (string)r.Attribute("id") == "bk102")
                                        select r.Element("author").Attribute("id").Value).FirstOrDefault();
            
            Console.WriteLine(selectedBookAttribute);         
                        
            Console.ReadKey(true);                                  
 
            #endregion
 
 
            #region Fetching all Authors 
 
           
            var allauthors = from r in document.Descendants("book")
                                         select r.Element("author").Value; 
            foreach(var r in allauthors)
            {
                Console.WriteLine(r.ToString());
            }
           
 
            Console.ReadKey(true);
 
            #endregion
 

             */



        }
    }
}
