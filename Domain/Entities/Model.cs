using Core.Persistence.Repositories;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Model:Entity<Guid>
{
    public Guid BrandId { get; set; }
    public Guid FuelId { get; set; }//yakıt tipini burada da kulanıyoruz
    public Guid TransmissionId { get; set; }//vites tipini burada kulanıyoruz 
    //ilişkisel veri tabanı misali 
    public string Name { get; set; }
    public decimal DailyPrice { get; set; }
    public string ImageUrl { get; set; }


    //bir modelin markası var
    public virtual Brand? Brand { get; set; }
    public virtual Fuel? Fuel { get;set; }
    public virtual Transmission? Transmission { get; set; }

    //bir  modelin birçok arabası olur 
    public virtual ICollection<Car> Cars { get; set;}

    public Model()
    {
        Cars = new HashSet<Car>();
    }

    public Model(Guid id ,Guid brandId,Guid fuelId,Guid transmissionId, string name,decimal dailyPrice,string imageUrl ):this()
    {
        Id = id;
        BrandId = brandId;
        FuelId = fuelId;
        TransmissionId = transmissionId;
        Name = name;
        DailyPrice = dailyPrice;
        ImageUrl = imageUrl;

    }


}
