using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    class Movie1
    {
        string NameOfMovie;
        int TicketPrice;
        string Location;
        public void ShowMovie(string NameOfMovie, int TicketPrice, string Location)
        {
            this.NameOfMovie = NameOfMovie;
            this.TicketPrice = TicketPrice;
            this.Location = Location;
        }
        public void DisplayMovie()
        {
            Console.WriteLine(NameOfMovie);
            Console.WriteLine(TicketPrice);
            Console.WriteLine(Location);
        }
    }
}
