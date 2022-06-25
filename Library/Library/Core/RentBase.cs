using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class RentBase
    {
        public ObservableCollection<Rent> rents { get; set; }
        public RentBase()
        {
            rents = new ObservableCollection<Rent>();
        }
        public void AddRent(Rent rent)
        {
            rents.Add(rent);
        }
        public void RemoveRent(int i)
        {
            rents.RemoveAt(i);
        }
        public int Size()
        {
            return rents.Count;
        }
        public int Find(string search)
        {
            int i = 0;
            foreach (Rent r in rents)
            {
                if (r.RentTitle == search || r.RentName == search)
                    return i;
                i++;
            }
            return -1;
        }
    }
}
