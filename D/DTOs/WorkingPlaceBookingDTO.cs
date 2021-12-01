using Dоmain.Enums;
using System;


namespace Dоmain.DTOs
{
    public class WorkingPlaceBookingDTO
    {
        public Guid Id { get; set; }

        public DateTime? Date { get; set; }

        public BookingType Type { get; set; }

        public BookingStatuses Status { get; set; }

        //  EntityFramework
        public int BookingDay { get; set; }
        public UserDTO User { get; set; }

        public Guid UserId { get; set; }

        public WorkingPlaceDTO WorkingPlace { get; set; }

        public Guid WorkingPlaceId { get; set; }
    }
}
