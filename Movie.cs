using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
   public class Movie
    {
        string NameOfMovie;
        int TicketPrice;
        string Location;
        public void ShowMovie(string nmovie,int tprice,string place)
        {
            NameOfMovie = nmovie;
            TicketPrice = tprice;
            Location = place;
        }
        public void DisplayMovie()
        {
            Console.WriteLine(NameOfMovie);
            Console.WriteLine(TicketPrice);
            Console.WriteLine(Location);
        }
    }
}
