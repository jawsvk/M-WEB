using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public List<int> GetMovieIds()
    {
        return new Work().GetVideoCode();
    }

    public WCF_Movie GetMovie(string id)
    {
        int n = Int32.Parse(id);
        Movie p = new Work().GetMovie(n);
        decimal price = (decimal)(p.RentalPrice.HasValue ? p.RentalPrice.Value : 0);
        short units = (p.TotalStock.HasValue ? p.TotalStock.Value : (short)0);
        return new WCF_Movie(p.VideoCode, p.MovieTitle, price, units);
    }
}
