using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Rent
    {
        public Title _rented { get; set; }
        public Reader _rentedBy { get; set; }
        private DateTime _rentDate;
        private int _rentTime;
        private double _due;
        public string Date { get; set; }
        public string ExpDate { get; set; }
        public string RentTitle { get; set; }
        public string RentName { get; set; }
        [JsonConstructor]
        public Rent()
        {

        }
        public Rent(Title title, Reader reader)
        {
            if (title._type == TitleType.Book)
                _rented = new Book((Book)title);
            if (title._type == TitleType.Movie)
                _rented = new Movie((Movie)title);
            if (title._type == TitleType.Magazine)
                _rented = new Magazine((Magazine)title);
            if (title._type == TitleType.Thesis)
                _rented = new Thesis((Thesis)title);
            _rentedBy = new Reader(reader);
            _rentDate = DateTime.Now;
            _rentTime = 14;
            _due = 0;
            Date = _rentDate.ToShortDateString();
            ExpDate = _rentDate.AddDays(_rentTime).ToShortDateString();
            RentTitle = _rented._id;
            RentName = _rentedBy._id;
        }
        public void SetRented(Title title)
        {
            if (title.GetTitle() != "")
                _rented = title;
        }
        public Title GetTitle()
        {
            return _rented;
        }
        public void SetRentedBy(Reader reader)
        {
            //if (reader.GetName() != "")
            _rentedBy = reader;
        }
        public Reader GetReader()
        {
            return _rentedBy;
        }
        public DateTime GetDate()
        {
            return _rentDate;
        }
        public void SetRentTime(int t)
        {
            if (t>0)
                _rentTime = t;
        }
        public int GetRentTime()
        {
            return _rentTime;
        }
        public void CalulateDue()
        {
            System.TimeSpan diff = DateTime.Now - _rentDate;
            if (diff.Days>_rentTime)
            {
                _due = 5.0 * (diff.Days - _rentTime);
            }
        }
        public double GetDue()
        {
            return _due;
        }
    }
}
