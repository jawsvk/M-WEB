using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{


    public WebService()
    {
    }

    [WebMethod]
    public List<int> GetMovieIds()
    {
        return new Work().GetVideoCode();
    }

    [WebMethod]
    public Movie GetMovie(int id)
    {
        return new Work().GetMovie(id);
    }

}
