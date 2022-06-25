using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core
{
    public static class GlobalData
    {
        //Zmienne globalne dla całego projektu
        public static Database LibraryData { get; set; } = new Database(); //Baza danych
        public static string FileName { get; set; } = "Data.json"; //ścieżka do pliku serializacji
    }
}
