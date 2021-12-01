using Domain.Models;
using Dоmain.Enums;
using Dоmain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class MockedData
    {
        public static void EnsurePopulated(AppDbContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User { UserName = "Robert Speedwagon", AvatarUrl = "a", Role = RoleOfUser.User },
                    new User { UserName = "Guido Mista", AvatarUrl = "a", Role = RoleOfUser.User },
                    new User { UserName = "Enrico Pucci", AvatarUrl = "a", Role = RoleOfUser.User },
                    new User { UserName = "Muhammad Avdol", AvatarUrl = "a", Role = RoleOfUser.User },
                    new User { UserName = "Rohan Kishibe", AvatarUrl = "a", Role = RoleOfUser.User },
                    new User { UserName = "Giorno Giovanna", AvatarUrl = "a", Role = RoleOfUser.User },
                    new User { UserName = "George Joestar", AvatarUrl = "a", Role = RoleOfUser.User },
                    new User { UserName = "Jotaro Kujo", AvatarUrl = "a", Role = RoleOfUser.User },
                    new User { UserName = "Jonathan Joestar", AvatarUrl = "a", Role = RoleOfUser.User },
                    new User { UserName = "Joseph Joestar", AvatarUrl = "a", Role = RoleOfUser.User },
                    new User { UserName = "Josuke Higashikata", AvatarUrl = "a", Role = RoleOfUser.User },
                    new User { UserName = "Jolyne Cujoh", AvatarUrl = "a", Role = RoleOfUser.User },
                    new User { UserName = "Johnny Joestar", AvatarUrl = "a", Role = RoleOfUser.User },
                    new User { UserName = "Bruno Buccirati", AvatarUrl = "a", Role = RoleOfUser.User },
                    new User { UserName = "Dio Brando", AvatarUrl = "a", Role = RoleOfUser.User },
                    new User { UserName = "Noriaki Kakyoin", AvatarUrl = "a", Role = RoleOfUser.User },
                    new User { UserName = "Narancia Ghirga", AvatarUrl = "a", Role = RoleOfUser.User },
                    new User { UserName = "Yoshikage Kira", AvatarUrl = "a", Role = RoleOfUser.User },
                    new User { UserName = "Leone Abbacchio", AvatarUrl = "a", Role = RoleOfUser.User },
                    new User { UserName = "Pierre Polnareff", AvatarUrl = "a", Role = RoleOfUser.User }
                   );
                context.SaveChanges();
            }

            if (!context.WorkingPlaces.Any())
            {
                for (int i = 1; i <= 30; i++)
                {
                    context.WorkingPlaces.Add(new WorkingPlace { NumPlace = i });
                }

                context.SaveChanges();
            }

            if (!context.Meetings.Any())
            {
                context.Meetings.AddRange(
                    // 2 число
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 2, 10, 0, 0),
                        Duration = new TimeSpan(0, 30, 0),
                        MeetingTheme = "Fix bugs",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Joseph Joestar")
                    },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 2, 10, 30, 0),
                        Duration = new TimeSpan(1, 0, 0),
                        MeetingTheme = "Play Dota 2 with client",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Dio Brando")
                     },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 2, 11, 30, 0),
                        Duration = new TimeSpan(0, 30, 0),
                        MeetingTheme = "Delete project because of <because> ",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Joseph Joestar")
                    },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 2, 12, 0, 0),
                        Duration = new TimeSpan(0, 30, 0),
                        MeetingTheme = "Pop togather",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Joseph Joestar")
                    },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 2, 12, 30, 0),
                        Duration = new TimeSpan(0, 30, 0),
                        MeetingTheme = "Make a cake",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Dio Brando")
                    },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 2, 17, 0, 0),
                        Duration = new TimeSpan(0, 30, 0),
                        MeetingTheme = "Maybe to work , maybe no",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Joseph Joestar")
                    },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 2, 15, 0, 0),
                        Duration = new TimeSpan(0, 30, 0),
                        MeetingTheme = "To sleep ",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Dio Brando")
                    },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 2, 18, 0, 0),
                        Duration = new TimeSpan(0, 30, 0),
                        MeetingTheme = "To water flower",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Andriy Morozov")
                    },
                    //3 число
                     new MeetingRoom {
                         MeetingTime = new DateTime(2021, 12, 2, 10, 30, 0),
                         Duration = new TimeSpan(0, 30, 0),
                         MeetingTheme = "Fix bugs",
                         MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Joseph Joestar")
                     },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 3, 15, 30, 0),
                        Duration = new TimeSpan(1, 0, 0),
                        MeetingTheme = "Play Dota 2 with client",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Dio Brando")
                    },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 3, 11, 0, 0),
                        Duration = new TimeSpan(0, 30, 0),
                        MeetingTheme = "Delete project because of <because> ",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Joseph Joestar")
                    },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 3, 12, 0, 0),
                        Duration = new TimeSpan(0, 30, 0),
                        MeetingTheme = "Pop togather",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Dio Brando")
                    },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 3, 17, 30, 0),
                        Duration = new TimeSpan(0, 30, 0),
                        MeetingTheme = "Make a cake",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Joseph Joestar")
                    },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 3, 17, 0, 0),
                        Duration = new TimeSpan(0, 30, 0),
                        MeetingTheme = "Maybe to work , maybe no",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Dio Brando")
                    },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 3, 14, 0, 0),
                        Duration = new TimeSpan(0, 30, 0),
                        MeetingTheme = "To sleep ",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Joseph Joestar")
                    },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 3, 16, 0, 0),
                        Duration = new TimeSpan(0, 30, 0),
                        MeetingTheme = "To water flower",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Dio Brando")
                    },
                    // 4 число
                     new MeetingRoom {
                         MeetingTime = new DateTime(2021, 12, 4, 10, 0, 0),
                         Duration = new TimeSpan(0, 30, 0),
                         MeetingTheme = "Fix bugs",
                         MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Joseph Joestar")
                     },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 4, 10, 30, 0),
                        Duration = new TimeSpan(1, 0, 0),
                        MeetingTheme = "Play Dota 2 with client",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Dio Brando")
                    },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 4, 11, 30, 0),
                        Duration = new TimeSpan(0, 30, 0),
                        MeetingTheme = "Delete project because of <because> ",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Joseph Joestar")
                    },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 4, 15, 0, 0),
                        Duration = new TimeSpan(0, 30, 0),
                        MeetingTheme = "Pop togather",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Dio Brando")
                    },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 4, 12, 30, 0),
                        Duration = new TimeSpan(1, 30, 0),
                        MeetingTheme = "Make a cake",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Joseph Joestar")
                    },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 4, 17, 0, 0),
                        Duration = new TimeSpan(0, 30, 0),
                        MeetingTheme = "Maybe to work , maybe no",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Dio Brando")
                    },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 4, 14, 0, 0),
                        Duration = new TimeSpan(0, 30, 0),
                        MeetingTheme = "To sleep ",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Dio Brando")
                    },
                    new MeetingRoom {
                        MeetingTime = new DateTime(2021, 12, 4, 18, 30, 0),
                        Duration = new TimeSpan(0, 30, 0),
                        MeetingTheme = "To water flower",
                        MeetingOwner = context.Users.FirstOrDefault(user => user.UserName == "Joseph Joestar")
                    }
                );

                context.SaveChanges();
            }

            if (!context.WorkingPlaceBookings.Any())
            {

                context.WorkingPlaceBookings.AddRange(

                    new WorkingPlaceBooking {
                        Date = null,
                        User = context.Users.FirstOrDefault(user => user.UserName == "Joseph Joestar"),
                        Type = BookingType.ConstantBooking,
                        WorkingPlace = context.WorkingPlaces.FirstOrDefault(x => x.NumPlace == 15),
                        Status = BookingStatuses.Approved
                    },
                    new WorkingPlaceBooking {
                        Date = null,
                        User = context.Users.FirstOrDefault(user => user.UserName == "Dio Brando"),
                        Type = BookingType.ConstantBooking,
                        WorkingPlace = context.WorkingPlaces.FirstOrDefault(x => x.NumPlace == 9),
                        Status = BookingStatuses.Approved
                    },
                    // 2 число
                    new WorkingPlaceBooking {
                        Date = new DateTime(2021, 12, 2),
                        User = context.Users.FirstOrDefault(user => user.UserName == "Robert Speedwagon"),
                        Type = BookingType.FullDay,
                        WorkingPlace = context.WorkingPlaces.FirstOrDefault(x => x.NumPlace == 2),
                        Status = BookingStatuses.Approved
                    },
                    new WorkingPlaceBooking {
                        Date = new DateTime(2021, 12, 2),
                        User = context.Users.FirstOrDefault(user => user.UserName == "Bruno Buccirati"),
                        Type = BookingType.FullDay,
                        WorkingPlace = context.WorkingPlaces.FirstOrDefault(x => x.NumPlace == 14),
                        Status = BookingStatuses.Approved
                    },
                    new WorkingPlaceBooking {
                        Date = new DateTime(2021, 12, 2),
                        User = context.Users.FirstOrDefault(user => user.UserName == "Jotaro Kujo"),
                        Type = BookingType.FirstPartOfDay,
                        WorkingPlace = context.WorkingPlaces.FirstOrDefault(x => x.NumPlace == 28),
                        Status = BookingStatuses.Approved
                    },
                    new WorkingPlaceBooking {
                        Date = new DateTime(2021, 12, 2),
                        User = context.Users.FirstOrDefault(user => user.UserName == "Muhammad Avdol"),
                        Type = BookingType.FullDay,
                        WorkingPlace = context.WorkingPlaces.FirstOrDefault(x => x.NumPlace == 20),
                        Status = BookingStatuses.Approved
                    },
                    new WorkingPlaceBooking {
                        Date = new DateTime(2021, 12, 2),
                        User = context.Users.FirstOrDefault(user => user.UserName == "Enrico Pucci"),
                        Type = BookingType.FullDay,
                        WorkingPlace = context.WorkingPlaces.FirstOrDefault(x => x.NumPlace == 21),
                        Status = BookingStatuses.Approved
                    },
                    new WorkingPlaceBooking {
                        Date = new DateTime(2021, 12, 2),
                        User = context.Users.FirstOrDefault(user => user.UserName == "Leone Abbacchio"),
                        Type = BookingType.SecondPartOfDay,
                        WorkingPlace = context.WorkingPlaces.FirstOrDefault(x => x.NumPlace == 10),
                        Status = BookingStatuses.Approved
                    },
                    new WorkingPlaceBooking {
                        Date = new DateTime(2021, 12, 2),
                        User = context.Users.FirstOrDefault(user => user.UserName == "Yoshikage Kira"),
                        Type = BookingType.SecondPartOfDay,
                        WorkingPlace = context.WorkingPlaces.FirstOrDefault(x => x.NumPlace == 17),
                        Status = BookingStatuses.Approved
                    },
                    new WorkingPlaceBooking {
                        Date = new DateTime(2021, 12, 2),
                        User = context.Users.FirstOrDefault(user => user.UserName == "Noriaki Kakyoin"),
                        Type = BookingType.FullDay,
                        WorkingPlace = context.WorkingPlaces.FirstOrDefault(x => x.NumPlace == 26),
                        Status = BookingStatuses.Approved
                    },
                    new WorkingPlaceBooking {
                        Date = new DateTime(2021, 12, 2),
                        User = context.Users.FirstOrDefault(user => user.UserName == "Pierre Polnareff"),
                        Type = BookingType.FullDay,
                        WorkingPlace = context.WorkingPlaces.FirstOrDefault(x => x.NumPlace == 6),
                        Status = BookingStatuses.Approved
                    },
                    new WorkingPlaceBooking {
                        Date = new DateTime(2021, 12, 2),
                        User = context.Users.FirstOrDefault(user => user.UserName == "Guido Mista"),
                        Type = BookingType.FirstPartOfDay,
                        WorkingPlace = context.WorkingPlaces.FirstOrDefault(x => x.NumPlace == 17),
                        Status = BookingStatuses.Approved
                    },
                    new WorkingPlaceBooking {
                        Date = new DateTime(2021, 12, 2),
                        User = context.Users.FirstOrDefault(user => user.UserName == "Giorno Giovanna"),
                        Type = BookingType.FullDay,
                        WorkingPlace = context.WorkingPlaces.FirstOrDefault(x => x.NumPlace == 30),
                        Status = BookingStatuses.Approved
                    }


                ) ;

                context.SaveChanges();
            }
        }
    }
}
