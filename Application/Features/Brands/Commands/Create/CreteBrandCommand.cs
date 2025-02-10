using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create;
               //request                      //response
public class CreteBrandCommand : IRequest<CretedBrandResponse>//bu işlem sonucunda döndüreceğimiz Responseyi döndür 
{
    public string Name { get; set; } //requestir dışarıdan almak için
 
   

    public class CretedBrandResponseHandler : IRequestHandler<CreteBrandCommand, CretedBrandResponse>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public CretedBrandResponseHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<CretedBrandResponse>? Handle(CreteBrandCommand request, CancellationToken cancellationToken)
        {
            Brand brand = _mapper.Map<Brand>(request);//REQUESTEN GELEN NESNEYİ BRANDA ÇEVİR MAPPLE YANİ 
            brand.Id = Guid.NewGuid();
          
          
            var result = await _brandRepository.AddAsync(brand);

           CretedBrandResponse cretedBrandResponse =_mapper.Map<CretedBrandResponse>(result);
           
            return cretedBrandResponse;
        }
    }
}

