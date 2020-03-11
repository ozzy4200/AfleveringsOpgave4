using System;

namespace AfleveringsOpgave4.Model
{
    public class Book
    {
        private string _forfatter;
        private int _sidetal;
        private string _isbn13;
        public string Titel { get; set; }

        public Book()
        {
            
        }
        public Book(string forfatter, int sidetal, string isbn13, string titel)
        {
            forfatter = forfatter;
            sidetal = sidetal;
            isbn13 = isbn13;
            titel = titel;
        }
        public string Isbn13
        {
            get => _isbn13;
            set
            {
                if (value.Length == 13) throw new ArgumentOutOfRangeException();
                {
                    _isbn13 = value;
                }

            }
        }

        public string Forfatter
        {
            get => _forfatter;
            set
            {
                if (value.Length < 2) throw new ArgumentOutOfRangeException();
                {
                    _forfatter = value;
                }

            }
        }

        public int Sidetal
        {
            get => _sidetal;
            set
            {
                if (value <= 4 || value >= 1000) throw new ArgumentOutOfRangeException();
                {
                    _sidetal = value;
                }

            }
        }
        public override string ToString()
        {
            return $"Titel: {Titel}, Forfatter: {Forfatter}, Isbn: {Isbn13}, Sidetal:{Sidetal}";
        }
    }
}
