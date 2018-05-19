using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForWebSvc
{
    using ServiceReference1;
    class Program
    {
        static void Main(string[] args)
        {
            WebServiceSoapClient c = new WebServiceSoapClient();
            ArrayOfInt ids = c.GetMovieIds();
            foreach (int i in ids)
            {
                Console.WriteLine(i);
                Movie m = c.GetMovie(i);
                Console.WriteLine(m.MovieTitle);
            }
        }
    }
}
