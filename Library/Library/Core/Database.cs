using Library.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Database
    {
        public int SelectedReader { get; set; } = -1; //wybrany czytelnik, domyślnie nie wybrany, czyli -1
        public int SelectedTitle { get; set; } = -1; //wybrany tytuł, domyślnie nie wybrany, czyli -1
        public int SelectedRent { get; set; } = -1; //wybrane wypożyczenie, domyślnie nie wybrany, czyli -1
        public TitleBase titleBase { get; set; }
        public RentBase rentBase { get; set; }
        public ReaderBase readerBase { get; set; }
        public Database()
        {
            titleBase = new TitleBase();
            rentBase = new RentBase();
            readerBase = new ReaderBase();
        }
        public Database(RentBase rent, ReaderBase reader, TitleBase title)
        {
            rentBase = rent;
            readerBase = reader;
            titleBase = title;
        }
        public void Save(string filePath)
        {
            //zapis do json
            if (File.Exists(filePath))
                File.Delete(filePath);
            File.WriteAllText(filePath, JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            }));
            //Dodatkowe parametry do serializacji poza obiektem, Formatting w celu sformatowania pliku, inaczej zapisuje
            //wszystko w jednym wierszu, JsonSerializerSettings w celu obsługi serializacji abstrakcyjnej klasy
        }
        public void Load(string filePath)
        {
            //wczytywanie z json
            if (File.Exists(filePath))
            {
                Database temp = JsonConvert.DeserializeObject<Database>(File.ReadAllText(filePath), new JsonSerializerSettings
                {
                    TypeNameHandling =  TypeNameHandling.All
                });
                //JsonSerializerSettings, do obsługi abstrakcyjnej klasy bez tego się sypie
                rentBase = temp.rentBase;
                readerBase = temp.readerBase;
                titleBase = temp.titleBase;
            }
        }
        public int FindTitle(string title)
        {
            int i = titleBase.Find(title);
            if (i >= 0)
                return i;
            return -1;
        }
        public int FindReader(string reader)
        {
            int i = readerBase.Find(reader);
            return i;
        }
    }
}
