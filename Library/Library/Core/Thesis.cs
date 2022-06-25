using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Thesis : Title, iTitle
    {
        private DateTime _publishDate;
        [JsonConstructor]
        public Thesis(string title, string author, int index, int quantity, DateTime date)
            : base(title,author,index,quantity,TitleType.Thesis)
        {
            _author = author;
            _publishDate = date;
            _publishDateString = date.ToShortDateString();
        }
        public Thesis(Thesis thesis)
        {
            _title = thesis._title;
            _author = thesis._author;
            _id = thesis._id;
            _publishDate = thesis._publishDate;
            _publishDateString = thesis._publishDateString;
            _quantity = thesis._quantity;
            _type = thesis._type;
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
        public void SetDate(DateTime date)
        {
            if (DateTime.Compare(date, new DateTime(1900, 1, 1, 0, 0, 0)) > 0) //założenie: prace nie mogą być starsze niż 1/01/1900
                _publishDate = date;
        }
        public string GetDate()
        {
            return _publishDate.ToShortDateString();
        }
        public void Edit(string title="", string author="", int quantity=0)
        {
            SetTitle(title);
            SetAuthor(author);
            SetQuantity(quantity);
        }
    }
}
