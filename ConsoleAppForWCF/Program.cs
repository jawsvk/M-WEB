using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForWCF
{
    using ServiceReference1;
    class Program
    {
        static void Main(string[] args)
        {
            ServiceClient c = new ServiceClient();
            int[] ids = c.GetMovieIds();
            foreach(int i in ids)
            {
                Console.WriteLine(i);
                WCF_Movie m = c.GetMovie(i.ToString());
                Console.WriteLine(m.MovieTitle);
            }
        }
    }
}
