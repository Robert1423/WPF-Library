using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Magazine : Title, iTitle
    {
        private DateTime _publishDate;
        [JsonConstructor]
        public Magazine(string title, int index, int quantity, DateTime date)
            : base(title, "",index,quantity,TitleType.Magazine)
        {
            _publishDate = date;
            _publishDateString = _publishDate.ToShortDateString();
        }
        public Magazine(Magazine magazine)//konstruktor kopiujący
        {
            _title = magazine._title;
            _author = string.Empty;
            _quantity = magazine._quantity;
            _id = magazine._id;
            _publishDateString = magazine._publishDateString;
            _publishDate = magazine._publishDate;
            _type = magazine._type;
        }

        public void SetDate(DateTime date)
        {
            if (DateTime.Compare(date,new DateTime(2000,1,1,0,0,0))>0) //założenie: czasopisma nie mogą być starsze niż 1/01/2000
                _publishDate = date;
        }
        public string GetDate()
        {
            return _publishDate.ToShortDateString();
        }
        public void Edit(string title = "", int quantity = 0)
        {
            SetTitle(title);
            SetQuantity(quantity);
        }
    }
}
