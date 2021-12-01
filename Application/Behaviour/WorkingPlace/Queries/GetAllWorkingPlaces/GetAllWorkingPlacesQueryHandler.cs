using Application.Mappers;
using Application.Repos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Behaviour.WorkingPlace.Queries.GetAllWorkingPlaces
{
    public class GetWorkPlacesQueryHandler : IRequestHandler<GetAllWorkingPlacesQuery, IList<WorkingPlaceQueryResponse>>
    {
        private readonly IWorkingPlaceRepos _repos;

        public GetWorkPlacesQueryHandler(IWorkingPlaceRepos repos)
        {
            _repos = repos;
        }

        public async Task<IList<WorkingPlaceQueryResponse>> Handle(GetAllWorkingPlacesQuery request, CancellationToken cancellationToken)
        {
            var workPlaces = await _repos.GetAllWorkingPlaces();
            return workPlaces.Select(x => new WorkingPlaceQueryResponse(WorkingPlaceMapper.MappingDTO(x))).ToList();
        }
    }
}
