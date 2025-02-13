using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Models.Queries.GetList;

public class GetListModelListItemDto
{
    public Guid Id { get; set; }
    //ilk 3 BrandName FuelName TransmissionName ıd lerini değilde namini getiriyorum çünkü bunları joinliyeceğim
    public string BrandName { get; set; }
    public string FuelName { get; set; }
    public string TransmissionName { get; set; }
    public string Name { get; set; }
    public decimal DailyPrice { get; set; }
    public string ImageUrl { get; set; }
}
