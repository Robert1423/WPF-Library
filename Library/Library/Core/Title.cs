using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Title : iTitle
    {
        public string _title { get; set; }
        public string _author { get; set; }
        public string _id { get; set; }
        public int _quantity { get; set; }
        public TitleType _type { get; set; }
        public string _publishDateString { get; set; }
        public Title()
        {}
        [JsonConstructor]
        public Title(string title, string author, int index, int quantity, TitleType type)
        {
            _title = title;
            _author = author;
            _quantity = quantity;
            _type = type;
            SetId(index);
        }
        public string GetTitle()
        {
            return _title;
        }
        public string GetId()
        {
            return _id;
        }
        public int GetQuantity()
        {
            return _quantity;
        }
        public void SetTitle(string title)
        {
            if (!string.IsNullOrWhiteSpace(title))
                _title = title;
        }
        public void SetQuantity(int q)
        {
            if (q >= 0)
                _quantity = q;
        }
        public void SetId(int index)
        {
            if (_type == TitleType.Book)
                _id = "B";
            else if (_type == TitleType.Magazine)
                _id = "M";
            else if (_type == TitleType.Movie)
                _id = "F";
            else
                _id = "T";
            if (index < 9)
                _id += "00" + index.ToString();
            else if (index < 99)
                _id += "0" + index.ToString();
            else
                _id += index.ToString();
        }
        public bool CheckAvalaible()
        {
            return _quantity > 0 ? true : false;
        }

        public void Rent()
        {
            _quantity--;
        }

        public void FinishRent()
        {
            _quantity++;
        }
    }
}
