using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase_Lab
{
    public class Movie
    {
        //Inputs go here
        private string _title { get; set; }
        private string _category { get; set; }

        //Constructor
        public Movie(string t, string c)
        {
            _title = t;
            _category = c;
        }

        //Method for category

        public string GetCategory()
        {
            return _category;
        }

        public string GetTitle()
        {
            return _title;
        }
    }
}
