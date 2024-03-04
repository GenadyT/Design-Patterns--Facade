using Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class FacadeClient
    {
        private TheaterPrint thPrint;
        private HomeTheaterFacade homeTheater;
        private string movieName;

        public FacadeClient(TheaterPrint thPrint, string movieName)
        {
            this.thPrint = thPrint;
            homeTheater = new HomeTheaterFacade(thPrint);
            this.movieName = movieName;
        }

        public void TheaterOn()
        {            
            homeTheater.TheaterOn(movieName);
        }

        public void TheaterOff()
        {
            homeTheater.TheaterOff(movieName);
        }

    }
}
