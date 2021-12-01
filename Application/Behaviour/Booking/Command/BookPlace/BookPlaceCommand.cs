using Dоmain.Enums;
using MediatR;
using System;

namespace Application.Behaviour.Booking.Command.BookPlace
{
    public class BookPlaceCommand : IRequest
    {
        public BookPlaceCommand(Guid id, BookingType type, Guid userId, DateTime date, int? day)
        {
            PlaceId = id;
            BookingType = type;
            UserId = userId;
            Date = date;
            Day = day;
        }

        public Guid PlaceId { get; private set; }
        public BookingType BookingType { get; private set; }
        public Guid UserId { get; private set; }
        public DateTime Date { get; private set; }
        public int? Day { get; private set; }
    }
}
