using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Behaviour.WorkingPlace.Queries.GetWorkingPlaceByPlaceNumber
{
    public class GetWorkingPlaceByPlaceNumberQuery : IRequest<WorkingPlaceQueryResponse>
    {
        public GetWorkingPlaceByPlaceNumberQuery(int placeNum)
        {
            NumPlace = placeNum;
        }

        public int NumPlace { get; private set; }

    }
}
