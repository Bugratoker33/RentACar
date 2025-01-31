using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create;

public class CreteBrandCommand : IRequest<CretedBrandResponse>
{
    public string Name { get; set; }

    public class CretedBrandResponseHandler : IRequestHandler<CreteBrandCommand, CretedBrandResponse>
    {
        public Task<CretedBrandResponse>? Handle(CreteBrandCommand request, CancellationToken cancellationToken)
        {
           CretedBrandResponse cretedBrandResponse = new CretedBrandResponse();
            cretedBrandResponse.Name = request.Name;
            cretedBrandResponse.Id = new Guid();
            return null;
        }
    }
}

