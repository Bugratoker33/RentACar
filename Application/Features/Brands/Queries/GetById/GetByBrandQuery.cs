using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Queries.GetById;

public class GetByIdBrandQuery : IRequest<GetByIdBrandResponse>
{
    // bana bir id verse gerekli olan oparasyonları yazarız 
    public Guid Id { get; set; }

    public class GetByIdBrandQueryHandler : IRequestHandler<GetByIdBrandQuery, GetByIdBrandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBrandRepository _brandRepository;

        public GetByIdBrandQueryHandler(IMapper mapper, IBrandRepository brandRepository)
        {
            _mapper = mapper;
            _brandRepository = brandRepository;
        }

        public async Task<GetByIdBrandResponse> Handle(GetByIdBrandQuery request, CancellationToken cancellationToken)
        {
            //get by ıd brand responsu bir branda çevirip bunda veri tabanına göndermemiz lazım 


            Brand? brand = await _brandRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);
            //veri tabanından brandı çekti biz bunu responso çekmemiz lazım

            GetByIdBrandResponse response =_mapper.Map<GetByIdBrandResponse>(brand);
            return response;
            //GetByIdBrandResponse çevir neyi çevir  _mapper.Map<GetByIdBrandResponse>(brand) içindeki branda 
            //  CreateMap<Brand, GetByIdBrandResponse>().ReverseMap(); profile bunu yazmamız lazım çünkü mapper e _mapper.Map<GetByIdBrandResponse>(brand); brandı çevir diyorz 
        }

    }





}
