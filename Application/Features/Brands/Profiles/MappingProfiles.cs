using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Commands.Deleted;
using Application.Features.Brands.Commands.Update;
using Application.Features.Brands.Queries.GetById;
using Application.Features.Brands.Queries.GetList;
using AutoMapper;
using Core.Aplication.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Profiles;

public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        //neyle neyi map edicem 
        CreateMap<Brand, CreteBrandCommand>().ReverseMap();
        //reverse map Commandan branda da maplama yaap 
        //mapin = ilgili alanlara göre mapla biz elinde sonunda müşteriye creteBranCommandan 
        //CretedBrandResponse döndürüyoruz o yüden lazım
        CreateMap<Brand, CretedBrandResponse>().ReverseMap();
        //UPDATE DLET VE ADD DE LAZIM OLUCAK 


        CreateMap<Brand, GetListBrandListItemDto>().ReverseMap();
        //BRANDLE BUNUN ARASINDA ÇEVİRME YAPICAK SONRADA ALTAKİ ÇEVİRMEDEN DEVAM EDİCEK 
        CreateMap<Paginate<Brand>,GetListResponse<GetListBrandListItemDto>>().ReverseMap();//sana paginete of brand geldiğinde onu get listresponse of getlistBrandDlistItemDto ya çevir


        //Paginate<Brand> veri tabanından bu geliyor  GetListResponse<GetListBrandListItemDto>> ve buna çevir 
        CreateMap<Brand, GetByIdBrandResponse>().ReverseMap();


        CreateMap<Brand, UpdateBrandCommand>().ReverseMap();
        CreateMap<Brand, UpdatedBrandResponse>().ReverseMap();

        CreateMap<Brand, DeletedBrandResponse>().ReverseMap();
        CreateMap<Brand, DeleteBrandCommand>().ReverseMap();

    }
}
