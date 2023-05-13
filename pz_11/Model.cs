using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_11
{
    public class Model
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void SaveToJSON()
        {
            List<Book> bookList = new List<Book>(books);
            string json = JsonConvert.SerializeObject(bookList);
            File.WriteAllText("books.json", json);
        }
    }
}
