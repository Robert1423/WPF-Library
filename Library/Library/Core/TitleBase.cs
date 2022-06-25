using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core
{
    public class TitleBase
    {
        public ObservableCollection<Title> titles { get; set; }//Lista wszystkich zasobów
        public ObservableCollection<Title> filter { get; set; }//Lista filtrowana
        public TitleBase()
        {
            titles = new ObservableCollection<Title>();
            filter = new ObservableCollection<Title>();
        }
        public void Add(Title title)
        {
            titles.Add(title);
        }
        public void RemoveTitle(int i)
        {
            titles.RemoveAt(i);
        }
        public int Size()
        {
            return titles.Count;
        }
        public int Find(Title title)
        {
            int i = 0;
            foreach (Title search in titles)
            {
                if (search._id == title._id)
                    return i;
                i++;
            }
            return -1; //Kiedy nie znaleziono zwraca ujemną
        }
        public int Find(string thes)
        {
            int i = 0;
            foreach (Title b in titles)
            {
                if (b._id == thes || b._title == thes)
                    return i;
                i++;
            }
            return -1; //Kiedy nie znaleziono zwraca ujemną
        }
        public void Filtr(TitleType titleType)
        {
            //Składanie filtrowanej listy
            foreach (Title title in titles)
            {
                if (title._type == titleType)
                    filter.Add(title);
            }
        }
        public int CheckAvalaibleID()
        {
            for (int i = 0; i < titles.Count; i++)
            {
                if (titles.Count - i == 1)
                    return -1;
                string firstId = titles[i]._id.Substring(1);
                string secondId = titles[i + 1]._id.Substring(1);
                if (int.Parse(secondId) - int.Parse(firstId) > 1)
                    return i + 1;
            }
            return -1;
        }
        public void Insert(Title title, int i)
        {
            titles.Insert(i, title);
        }
    }
}
