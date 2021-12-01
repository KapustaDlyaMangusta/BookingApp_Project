using Application.Mappers;
using Application.Repos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Behaviour.WorkingPlace.Queries.GetWorkingPlaceByPlaceNumber
{
    public class GetWorkingPlaceByPlaceNumberQueryHandler : IRequestHandler<GetWorkingPlaceByPlaceNumberQuery, WorkingPlaceQueryResponse>
    {
        private readonly IWorkingPlaceRepos _repos;

        public GetWorkingPlaceByPlaceNumberQueryHandler(IWorkingPlaceRepos repos)
        {
            _repos = repos;
        }

        public async Task<WorkingPlaceQueryResponse> Handle(GetWorkingPlaceByPlaceNumberQuery request, CancellationToken cancellationToken)
        {
            var place = await _repos.GetWorkingPlaceByPlaceNumber(request.NumPlace);
            return new WorkingPlaceQueryResponse(WorkingPlaceMapper.MappingDTO(place));
        }
    }
}
