using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
    [OperationContract]
    List<int> GetMovieIds();

    [OperationContract]
    WCF_Movie GetMovie(string id);
}


[DataContract]
public class WCF_Movie
{
    [DataMember]
    public int VideoCode;

    [DataMember]
    public string MovieTitle;

    [DataMember]
    public decimal RentalPrice;

    [DataMember]
    public short TotalStock;

    public WCF_Movie(int VideoCode, string MovieTitle, decimal RentalPrice, short TotalStock)
    {
        this.VideoCode = VideoCode;
        this.RentalPrice = RentalPrice;
        this.MovieTitle = MovieTitle;
        this.TotalStock = TotalStock;
    }
}