using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Movie
    {
        //public means it can be accesed by any part of the program
        //private means only code within the class can access the property
        public string title;
        public string director;
        private string rating;

        public Movie (string aTitle, string aDirector, string aRating)
        {
            title = aTitle; 
            director = aDirector; 
            Rating = aRating;
        }

        //propery is special method for getters and setters
        //static attribute is an attribute that is shared by all the objects in that class, not just the object itself
        public string Rating
        {
            get 
            {
                return rating; 
            }
            set 
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR") 
                { 
                    rating = value;
                }
                else 
                { 
                    rating = "NR"; 
                }
            }
        }
    }
}
