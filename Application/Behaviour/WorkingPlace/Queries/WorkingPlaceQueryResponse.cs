using Dоmain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Behaviour.WorkingPlace.Queries
{
    public class WorkingPlaceQueryResponse
    {
        public WorkingPlaceQueryResponse(WorkingPlaceDTO workingPlace)
        {
            WorkingPlace = workingPlace;
        }

        public WorkingPlaceDTO WorkingPlace { get; private set; }
    }
}
