using System;

namespace Exceções_Personalizadas.Entities
{
    class Reservation
    {
        

        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public Reservation()
        {
        }


        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return "Rum"
                + RoomNumber
                + ", Check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ","
                + Duration()
                + " nights";

        }

        
            public void UpdateDates(DateTime checkIn, DateTime checkOut)
            {

                DateTime now = DateTime.Now;
                if (checkIn < now || checkOut < now)
                {
                    throw new DomainException("Reservation dates for update must be future dates");
                }
                else if (checkOut <= checkIn)
                {
                    throw new DomainException("Check-out date must be after check-in date");
                }

                CheckIn = checkIn;
                CheckOut = checkOut;
            }
    }
}

