using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book : Title, iTitle
    {
        private int _published; //rok publikacji
        [JsonConstructor]
        public Book(string title, string author, int index, int quantity, int publish)
            : base(title,author,index,quantity, TitleType.Book)
        {
            _author = author;
            _published = publish;
            _publishDateString = _published.ToString();
        }
        public Book(Book book) //konstruktor kopiujący
        {
            _title = book._title;
            _author = book._author;
            _id = book._id;
            _published = book._published;
            _publishDateString = book._publishDateString;
            _quantity = book._quantity;
            _type = book._type;
        }

        public void SetAuthor(string author)
        {
            if (!string.IsNullOrWhiteSpace(author))
                _author = author;
        }
        public string GetAuthor()
        {
            return _author;
        }
        public void SetDate(int date)
        {
            if (date > 1900) //dla uproszczenia, data publikacji nie może być starsza niż 1901
                _published = date;
        }
        public int GetDate()
        {
            return _published;
        }
        public void Edit(string author="", string title="", int quantity=-1, int publish=0)
        {
            //argumenty domyślne, żeby nie wymuszać edycji wszystkich pól klasy
            SetAuthor(author);
            SetTitle(title);
            SetQuantity(quantity);
            SetDate(publish);
        }
    }
}
