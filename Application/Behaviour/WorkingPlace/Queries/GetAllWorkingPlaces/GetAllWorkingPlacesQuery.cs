﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Application.Behaviour.WorkingPlace.Queries.GetAllWorkingPlaces
{
    public class GetAllWorkingPlacesQuery : IRequest<IList<WorkingPlaceQueryResponse>>
    {
    }
}
