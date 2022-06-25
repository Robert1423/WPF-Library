using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ReaderBase
    {
        public ObservableCollection<Reader> readers { get; set; }
        public ReaderBase()
        {
            readers = new ObservableCollection<Reader>();
        }
        public void AddReader(Reader reader)
        {
            readers.Add(reader);
        }
        public void RemoveReader(int i)
        {
            readers.RemoveAt(i);
        }
        public int Size()
        {
            return readers.Count;
        }
        public int Find(string name)
        {
            int i = 0;
            foreach (Reader r in readers)
            {
                if (r._name == name || r._id == name)
                    return i;
                i++;
            }
            return -1;
        }
        public int CheckAvalaibleID()
        {
            for (int i=0; i<readers.Count; i++)
            {
                if (readers.Count - i == 1)
                    return -1;
                string firstId = readers[i]._id.Substring(1);
                string secondId = readers[i+1]._id.Substring(1);
                if (int.Parse(secondId) - int.Parse(firstId) > 1)
                    return i+1;
            }
            return -1;
        }
        public void Insert(Reader reader, int i)
        {
            readers.Insert(i, reader);
        }
    }
}
