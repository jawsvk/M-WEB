using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Work
/// </summary>
public class Work
{
    DafestyEntities context = new DafestyEntities();
    public List<Movie> GetMovies()
    {
        return context.Movies1.ToList<Movie>();
    }

    public List<int> GetVideoCode()
    {
        List<int> list = new List<int>();
        foreach (Movie p in GetMovies())
        {
            list.Add(p.VideoCode);
        }
        return list;

     }

    public Movie GetMovie(int id)
    {
        return context.Movies1.Where
                (p => p.VideoCode== id).ToList<Movie>()[0];
    }


}