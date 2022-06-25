using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Movie : Title, iTitle
    {
        private string _director;
        private int _year;
        [JsonConstructor]
        public Movie(string title, string director, int index, int year, int quantity)
            : base(title,director,index,quantity,TitleType.Movie)
        {
            _director = director;
            _year = year;
            _publishDateString = _year.ToString();
        }
        public Movie(Movie movie) //konstruktor kopiujący
        {
            _title = movie._title;
            _author = movie._author;
            _director = movie._director;
            _id = movie._id;
            _publishDateString = movie._publishDateString;
            _year = movie._year;
            _type = movie._type;
        }

        public void SetAuthor(string director)
        {
            if (!string.IsNullOrWhiteSpace(director))
                _director = director;
        }
        public string GetAuthor()
        {
            return _director;
        }
        public void SetYear(int year)
        {
            if (year >= 1895) //data powstania nie może mniejsza niż data pierwszego filmu w historii
                _year = year;
        }
        public int GetYear()
        {
            return _year;
        }
        public void Edit(string director="",string title="",int quantity=-1,int year=0)
        {
            //argumenty domyślne, żeby nie wymuszać edycji wszystkich pól klasy
            SetAuthor(director);
            SetTitle(title);
            SetQuantity(quantity);
            SetYear(year);
        }
    }
}
