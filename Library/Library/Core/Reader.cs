using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Reader
    {
        public string _name { get; set; } 
        public string _id { get; set; }
        public ObservableCollection<Rent> _rented { get; set; }
        public double _dueSum { get; set; } //suma wszystkich kar
        public double _duePaid { get; set; } //suma wpłat
        public Reader()
        {
            _rented = new ObservableCollection<Rent>();
        }
        [JsonConstructor]
        public Reader(string name, int index)
        {
            _name = name;
            _duePaid = 0;
            _dueSum = 0;
            SetId(index);
            _rented = new ObservableCollection<Rent>();
        }
        public Reader(Reader reader)
        {
            _id = reader._id;
            _name = reader._name;
            _duePaid = reader._duePaid;
            _dueSum = reader._dueSum;
        }
        public void SetId(int index)
        {
            if (index < 9)
                _id = "R00" + index.ToString();
            else if (index < 99)
                _id = "R0" + index.ToString();
            else
                _id = "R" + index.ToString();
        }
        public void SetName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                _name = name;
        }
        public string GetName()
        {
            return _name;
        }
        public string GetId()
        {
            return _id;
        }
        //public Rent GetRent(int i)
        //{
        //    return _rented[i];
        //}
        public bool CanRent()
        {
            return _dueSum <= 0 ? true : false;
        }
        public void AddRent(Rent rent)
        {
            if (CanRent())
                _rented.Add(rent);
        }
        public void FinishRent(int i)
        {
            _rented.RemoveAt(i);
        }
        //public void CalculateDue()
        //{
        //    _dueSum = 0;
        //    foreach(Rent r in _rented)
        //    {
        //        r.CalulateDue();
        //        _dueSum += r.GetDue();
        //    }
        //    if (_duePaid > _dueSum)
        //        _dueSum -= _duePaid;
        //    else if (_duePaid==_dueSum)
        //    {
        //        _dueSum = 0;
        //        _duePaid = 0;
        //    }
        //}
        public void Pay(double pay)
        {
            _duePaid += pay;
        }
        public int FindRent(string search)
        {
            int i = 0;
            foreach (Rent r in _rented)
            {
                if (r.RentTitle == search || r.RentName == search)
                    return i;
                i++;
            }
            return -1;
        }
    }
}
