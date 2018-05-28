using System;
using System.Collections.ObjectModel;

namespace Bio2
{
    public class Movie :DomainClassBase
    {
        private string _name;
        private int _time;
        private string _image;

        public Movie(string Name, int Time, string Image)
        {
            _name = Name;
            _time = Time;
            _image = Image;
        }

   
        public string Name
        {
            get { return _name; }
        }

        public int Time
        {
            get { return _time; }
        }

        public string Image
        {
            get { return _image; }
        }

        public override string ToString()
        {
            return $"{Name} ({Time})";
        }

        public override int Key { get; set; }
    }
}